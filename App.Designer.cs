using System.Drawing;
using System.Windows.Forms;

namespace Shard
{
    partial class ShardWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ShardWindow));
            this.browseFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.creditLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.browseFileButton = new CuoreUI.Controls.cuiButton();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.filePathTextBox = new cuiTextBox();
            this.checkButton = new CuoreUI.Controls.cuiButton();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // browseFileDialog
            // 
            this.browseFileDialog.FileName = "game.exe";
            this.browseFileDialog.Filter = "Executable (*.exe)|*.exe|All files (*.*)|*.*";
            this.browseFileDialog.Title = "Choose your game...";
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.BackColor = System.Drawing.Color.Transparent;
            this.creditLabel.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.creditLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.creditLabel.Location = new System.Drawing.Point(12, 537);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(228, 27);
            this.creditLabel.TabIndex = 11;
            this.creditLabel.Text = "Made by MasterHell";
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.statusLabel.Font = new System.Drawing.Font("Cascadia Code", 15F);
            this.statusLabel.ForeColor = System.Drawing.SystemColors.Control;
            this.statusLabel.Location = new System.Drawing.Point(349, 350);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(312, 27);
            this.statusLabel.TabIndex = 13;
            this.statusLabel.Text = "Status: Choose Unity Game";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 14;
            // 
            // browseFileButton
            // 
            this.browseFileButton.BackColor = System.Drawing.Color.Transparent;
            this.browseFileButton.BackgroundImage = global::Shard.Properties.Resources.BrowseFileButton;
            this.browseFileButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.browseFileButton.CheckButton = false;
            this.browseFileButton.Checked = false;
            this.browseFileButton.CheckedBackground = System.Drawing.Color.Transparent;
            this.browseFileButton.CheckedImageTint = System.Drawing.Color.LightGray;
            this.browseFileButton.CheckedOutline = System.Drawing.Color.Transparent;
            this.browseFileButton.Content = "...";
            this.browseFileButton.Font = new System.Drawing.Font("Cascadia Code", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseFileButton.ForeColor = System.Drawing.SystemColors.Control;
            this.browseFileButton.HoverBackground = System.Drawing.SystemColors.ActiveBorder;
            this.browseFileButton.HoveredImageTint = System.Drawing.Color.White;
            this.browseFileButton.HoverOutline = System.Drawing.SystemColors.ActiveBorder;
            this.browseFileButton.Image = null;
            this.browseFileButton.ImageAutoCenter = true;
            this.browseFileButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.browseFileButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.browseFileButton.ImageTint = System.Drawing.Color.Transparent;
            this.browseFileButton.Location = new System.Drawing.Point(708, 190);
            this.browseFileButton.Name = "browseFileButton";
            this.browseFileButton.NormalBackground = System.Drawing.Color.Transparent;
            this.browseFileButton.NormalOutline = System.Drawing.Color.Transparent;
            this.browseFileButton.OutlineThickness = 1.5F;
            this.browseFileButton.PressedBackground = System.Drawing.SystemColors.ControlDark;
            this.browseFileButton.PressedImageTint = System.Drawing.Color.White;
            this.browseFileButton.PressedOutline = System.Drawing.SystemColors.ControlDark;
            this.browseFileButton.Rounding = new System.Windows.Forms.Padding(19);
            this.browseFileButton.Size = new System.Drawing.Size(86, 40);
            this.browseFileButton.TabIndex = 17;
            this.browseFileButton.TextOffset = new System.Drawing.Point(0, 0);
            this.browseFileButton.Click += new System.EventHandler(this.browseFileButton_Click);
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.BackgroundImage = global::Shard.Properties.Resources.Shard;
            this.logoPicture.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.logoPicture.Location = new System.Drawing.Point(12, 22);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(991, 85);
            this.logoPicture.TabIndex = 18;
            this.logoPicture.TabStop = false;
            // 
            // filePathTextBox
            // 
            this.filePathTextBox.BackColor = System.Drawing.Color.Transparent;
            this.filePathTextBox.Background = System.Drawing.Color.Transparent;
            this.filePathTextBox.BackgroundImage = global::Shard.Properties.Resources.TextBox;
            this.filePathTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.filePathTextBox.Border = System.Drawing.Color.Transparent;
            this.filePathTextBox.BorderRadius = new System.Windows.Forms.Padding(20);
            this.filePathTextBox.BorderSize = 0F;
            this.filePathTextBox.Content = "";
            this.filePathTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filePathTextBox.DesignStyle = cuiTextBox.Styles.Partial;
            this.filePathTextBox.FocusedBackground = System.Drawing.Color.Transparent;
            this.filePathTextBox.FocusedBorder = System.Drawing.Color.Transparent;
            this.filePathTextBox.Font = new System.Drawing.Font("Cascadia Code", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathTextBox.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.filePathTextBox.Location = new System.Drawing.Point(190, 190);
            this.filePathTextBox.Name = "filePathTextBox";
            this.filePathTextBox.PartialThickness = 0F;
            this.filePathTextBox.Placeholder = "";
            this.filePathTextBox.PlaceholderColor = System.Drawing.SystemColors.Control;
            this.filePathTextBox.Size = new System.Drawing.Size(502, 40);
            this.filePathTextBox.TabIndex = 19;
            // 
            // checkButton
            // 
            this.checkButton.BackColor = System.Drawing.Color.Transparent;
            this.checkButton.BackgroundImage = global::Shard.Properties.Resources.CheckButton;
            this.checkButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.checkButton.CheckButton = false;
            this.checkButton.Checked = false;
            this.checkButton.CheckedBackground = System.Drawing.Color.Transparent;
            this.checkButton.CheckedImageTint = System.Drawing.Color.LightGray;
            this.checkButton.CheckedOutline = System.Drawing.Color.Transparent;
            this.checkButton.Content = "Check";
            this.checkButton.Font = new System.Drawing.Font("Cascadia Code", 25F);
            this.checkButton.ForeColor = System.Drawing.SystemColors.Control;
            this.checkButton.HoverBackground = System.Drawing.SystemColors.ActiveBorder;
            this.checkButton.HoveredImageTint = System.Drawing.Color.White;
            this.checkButton.HoverOutline = System.Drawing.SystemColors.ActiveBorder;
            this.checkButton.Image = null;
            this.checkButton.ImageAutoCenter = true;
            this.checkButton.ImageExpand = new System.Drawing.Point(0, 0);
            this.checkButton.ImageOffset = new System.Drawing.Point(0, 0);
            this.checkButton.ImageTint = System.Drawing.Color.Transparent;
            this.checkButton.Location = new System.Drawing.Point(349, 260);
            this.checkButton.Name = "checkButton";
            this.checkButton.NormalBackground = System.Drawing.Color.Transparent;
            this.checkButton.NormalOutline = System.Drawing.Color.Transparent;
            this.checkButton.OutlineThickness = 1.5F;
            this.checkButton.PressedBackground = System.Drawing.SystemColors.ControlDark;
            this.checkButton.PressedImageTint = System.Drawing.Color.White;
            this.checkButton.PressedOutline = System.Drawing.SystemColors.ControlDark;
            this.checkButton.Rounding = new System.Windows.Forms.Padding(16);
            this.checkButton.Size = new System.Drawing.Size(312, 57);
            this.checkButton.TabIndex = 20;
            this.checkButton.TextOffset = new System.Drawing.Point(0, 0);
            this.checkButton.Click += new System.EventHandler(this.checkButton_Click);
            // 
            // ShardWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::Shard.Properties.Resources.Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1015, 573);
            this.Controls.Add(this.checkButton);
            this.Controls.Add(this.filePathTextBox);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.browseFileButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.creditLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1031, 612);
            this.MinimumSize = new System.Drawing.Size(1031, 612);
            this.Name = "ShardWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shard";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OpenFileDialog browseFileDialog;
        private Label creditLabel;
        private Label statusLabel;
        private Label label1;
        private CuoreUI.Controls.cuiButton browseFileButton;
        private PictureBox logoPicture;
        private cuiTextBox filePathTextBox;
        private CuoreUI.Controls.cuiButton checkButton;
    }
}

