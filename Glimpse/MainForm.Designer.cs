namespace Glymce
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.openButton = new System.Windows.Forms.Button();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.resizeButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.picPanel = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.picPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openButton
            // 
            this.openButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.openButton.BackColor = System.Drawing.Color.Transparent;
            this.openButton.BackgroundImage = global::Glymce.Properties.Resources.icons8_open_50;
            this.openButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.openButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.openButton.Location = new System.Drawing.Point(290, 341);
            this.openButton.Name = "openButton";
            this.openButton.Size = new System.Drawing.Size(50, 50);
            this.openButton.TabIndex = 1;
            this.openButton.UseVisualStyleBackColor = false;
            this.openButton.Click += new System.EventHandler(this.openButton_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Black;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(0, 0);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(631, 327);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox.TabIndex = 2;
            this.picBox.TabStop = false;
            // 
            // resizeButton
            // 
            this.resizeButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.resizeButton.BackColor = System.Drawing.Color.Transparent;
            this.resizeButton.BackgroundImage = global::Glymce.Properties.Resources.icons8_collapse_50;
            this.resizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.resizeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.resizeButton.Location = new System.Drawing.Point(220, 341);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(50, 50);
            this.resizeButton.TabIndex = 3;
            this.resizeButton.UseVisualStyleBackColor = false;
            this.resizeButton.Visible = false;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BackgroundImage = global::Glymce.Properties.Resources.icons8_save_as_50;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.saveButton.Location = new System.Drawing.Point(360, 341);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(50, 50);
            this.saveButton.TabIndex = 2;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Visible = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // picPanel
            // 
            this.picPanel.AutoScroll = true;
            this.picPanel.Controls.Add(this.picBox);
            this.picPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.picPanel.Location = new System.Drawing.Point(0, 0);
            this.picPanel.Name = "picPanel";
            this.picPanel.Size = new System.Drawing.Size(631, 327);
            this.picPanel.TabIndex = 5;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(631, 403);
            this.Controls.Add(this.picPanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.resizeButton);
            this.Controls.Add(this.openButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(240, 158);
            this.Name = "mainForm";
            this.Text = "Glymce";
            this.Resize += new System.EventHandler(this.Window_Resized);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.picPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openButton;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button resizeButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Panel picPanel;
    }
}

