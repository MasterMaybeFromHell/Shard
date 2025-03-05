using System;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace Shard
{
    public partial class ShardWindow : Form
    {
        private string _filePath = "";
        private string _gameName = "";
        private string _pathToFile = "";
        private string _gameBit = "";
        private string _codeArchitecture = "";
        private string _bepInEx = "";
        private string _melonLoader = "";
        private string[] _gameDirectories;
        private string[] _gameFiles;

        public ShardWindow()
        {
            DoubleBuffered = true;
            InitializeComponent();
        }

        private void browseFileButton_Click(object sender, EventArgs e)
        {
            if (browseFileDialog.ShowDialog() == DialogResult.OK)
            {
                _filePath = browseFileDialog.FileName;

                if (IsUnityGame())
                {
                    SetStatus("Ready to Proceed");

                    filePathTextBox.Content = browseFileDialog.FileName;
                    _gameName = browseFileDialog.SafeFileName.Replace(".exe", "");
                    _pathToFile = Path.GetDirectoryName(_filePath);

                    return;
                }

                _filePath = null;
                SetStatus("Not a Unity game");

                return;
            }

            SetStatus("Error while Choosing Game");
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            ProcessSelectedFile();
        }

        private bool IsUnityGame()
        {
            string directoryPath = _filePath.Replace(".exe", "_Data");

            if (Directory.Exists(directoryPath))
                return true;

            return false;
        }

        private void SetStatus(string text)
        {
            statusLabel.Text = $"Status: {text}";
        }

        private void ProcessSelectedFile()
        {
            if (string.IsNullOrEmpty(_filePath))
                return;

            PerformGameChecks();
        }

        private void PerformGameChecks()
        {
            GetGameFilesAndDirectories();
            CheckGameBit();
            CheckCodeArchitecture();
            CheckBepInEx();
            CheckMelonLoader();
            CreateLog();
            SetStatus("Game Perform Compeleted");
        }

        private void GetGameFilesAndDirectories()
        {
            _gameFiles = new string[Directory.GetFiles(_pathToFile).Length];
            _gameDirectories = new string[Directory.GetDirectories(_pathToFile).Length];

            for (int i = 0; i < Directory.GetFiles(_pathToFile).Length; i++)
            {
                _gameFiles[i] = Directory.GetFiles(_pathToFile)[i];
            }

            for (int i = 0; i < Directory.GetDirectories(_pathToFile).Length; i++)
            {
                _gameDirectories[i] = Directory.GetDirectories(_pathToFile)[i];
            }
        }

        private void CheckGameBit()
        {
            SetStatus("Checking Game Bit...");

            using (var stream = new FileStream(_filePath, FileMode.Open, FileAccess.Read))
            {
                using (var reader = new BinaryReader(stream))
                {
                    // Перемещаем указатель на 0x3C для чтения PE-заголовка
                    stream.Seek(0x3C, SeekOrigin.Begin);
                    int peHeaderOffset = reader.ReadInt32();

                    // Переходим к PE-заголовку
                    stream.Seek(peHeaderOffset, SeekOrigin.Begin);
                    uint peSignature = reader.ReadUInt32();

                    // Проверяем на наличие 'PE' сигнатуры
                    if (peSignature != 0x00004550) // 'PE\0\0' в little-endian
                    {
                        _gameBit = "Error PE Signature";
                        return;
                    }

                    // Пропускаем стандартные поля заголовка PE
                    stream.Seek(20, SeekOrigin.Current);

                    // Читаем "Magic" поле OptionalHeader для определения битности
                    ushort magic = reader.ReadUInt16();

                    // Значения для Magic:
                    // 0x010B — 32-bit (PE32)
                    // 0x020B — 64-bit (PE32+)
                    if (magic == 0x020B)
                    {
                        _gameBit = "64 Bit"; // 64-битный исполняемый файл
                        return;
                    }
                    else if (magic == 0x010B)
                    {
                        _gameBit = "32 Bit"; // 32-битный исполняемый файл
                        return;
                    }

                    _gameBit = "Unknown";
                }
            }
        }

        private void CheckCodeArchitecture()
        {
            SetStatus("Checking Code Acthitecture...");

            string directoryPath = $"{_filePath.Replace(".exe", "_Data")}\\Managed";

            if (Directory.Exists(directoryPath))
            {
                _codeArchitecture = "Mono";
                return;
            }

            _codeArchitecture = "IL2CPP";
        }

        private void CheckBepInEx()
        {
            SetStatus("Checking BepInEx...");

            if (_codeArchitecture == "IL2CPP")
            {
                _bepInEx = "Not Working";
                return;
            }

            if (_gameBit == "64 Bit")
            {
                DownloadFile("https://www.dropbox.com/scl/fi/e7wlhhy0emj4szvdwkv45/BepInEx64.zip?rlkey=acxzykp5vf1xgo5bocsygqq6w&st=4v0q8okr&dl=1", "BepInEx64.zip");
                UnpackFile("BepInEx64.zip", _pathToFile);
            }
            else
            {
                DownloadFile("https://www.dropbox.com/scl/fi/kb3f362v43z7wcpuiin98/BepInEx32.zip?rlkey=dl8ykonp5e2johocqm7nffic3&st=r9ylrvl8&dl=1", "BepInEx32.zip");
                UnpackFile("BepInEx32.zip", _pathToFile);
            }

            Process commandLine = Process.Start(_filePath);

            WaitForExit(commandLine, ref _bepInEx);
        }

        private void CheckMelonLoader()
        {
            SetStatus("Checking MelonLoader...");

            if (_gameBit == "64 Bit")
            {
                DownloadFile("https://www.dropbox.com/scl/fi/0y6z4jfp4vgsc0w49t2o8/MelonLoader64.zip?rlkey=d2soadi3tbprlpsxfbwrwcs5t&st=oxqifvbf&dl=1", "MelonLoader64.zip");
                UnpackFile("MelonLoader64.zip", _pathToFile);
            }
            else
            {
                DownloadFile("https://www.dropbox.com/scl/fi/io6gxzpx97l4w92pbt9bg/MelonLoader32.zip?rlkey=y72uk3ruktf0hhnjb60t3hfgb&st=nipsuu70&dl=1", "MelonLoader32.zip");
                UnpackFile("MelonLoader32.zip", _pathToFile);
            }

            Process commandLine = Process.Start(_filePath);

            WaitForExit(commandLine, ref _melonLoader);
        }

        private void CreateLog()
        {
            File.WriteAllText($"{_gameName}_log.txt",
                "--------------[RESULT]---------------\r\n" +
                $"| GameBit: {_gameBit}\r\n" +
                $"| Code Architecture: {_codeArchitecture}\r\n" +
                $"| BepInEx: {_bepInEx}\r\n" +
                $"| MelonLoader: {_melonLoader}\r\n" +
                "-------------------------------------"
            );
        }

        private void DownloadFile(string address, string fileName)
        {
            using (var webClient = new WebClient())
            {
                Uri uri = new Uri(address);
                webClient.DownloadFile(uri, fileName);
            }
        }

        private void UnpackFile(string fileName, string pathTo)
        {
            ZipFile.ExtractToDirectory(fileName, pathTo);
            File.Delete(fileName);
        }

        private void WaitForExit(Process process, ref string variable)
        {
            process.WaitForExit(1000 * 10);

            if (process.HasExited)
            {
                variable = "Not Working";
                return;
            }

            process.CloseMainWindow();

            Thread.Sleep(1000 * 1);

            variable = "Working";

            CleanFiles();
        }

        private void CleanFiles()
        {
            foreach (string file in Directory.GetFiles(_pathToFile))
            {
                if (!_gameFiles.Contains(file))
                    File.Delete(file);
            }

            foreach (string directory in Directory.GetDirectories(_pathToFile))
            {
                if (!_gameDirectories.Contains(directory))
                    Directory.Delete(directory, true);
            }
        }
    }
}