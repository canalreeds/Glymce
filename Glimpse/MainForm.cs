using System;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace Glimpse
{
    public partial class mainForm : Form
    {
        bool isZoomed = true;
        string fileName = "";
        int extIndex = 1;
        public mainForm()
        {
            InitializeComponent();
        }
        private void Window_Resized(object sender, EventArgs e)
        {
            picPanel.Width = this.Width - 16;
            picPanel.Height = this.Height - 73;
            SetZoom(isZoomed);
        }
        private void openButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp;*.tif;*.tiff";
            openFile.Title = "Select an Image File";
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileStream openStream = (FileStream)openFile.OpenFile();
                picBox.Image = Image.FromStream(openStream);
                openStream.Dispose();
                fileName = Path.GetFileNameWithoutExtension(openFile.SafeFileName);
                extIndex = Ext_to_Index(Path.GetExtension(openFile.SafeFileName).ToLower());
            }
        }
        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (isZoomed == true)
            {
                resizeButton.Text = "Fit Window";
                isZoomed = false;
            }
            else if (resizeButton.Text == "Fit Window")
            {
                resizeButton.Text = "Actual Size";
                isZoomed = true;
            }
            SetZoom(isZoomed);
        }
        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "*JPEG Image|*.jpg|PNG Image|*.png|GIF Image|*.gif|Bitmap Image|*.bmp|TIFF Image|*.tif";
            saveFile.FilterIndex = extIndex;
            saveFile.FileName = fileName;
            saveFile.AddExtension = true;
            saveFile.Title = "Save Image As...";
            if (saveFile.ShowDialog() == DialogResult.OK && saveFile.FileName != "")
            {
                FileStream saveStream = (FileStream)saveFile.OpenFile();
                switch(saveFile.FilterIndex)
                {
                    case 1:
                        picBox.Image.Save(saveStream, ImageFormat.Jpeg);
                        break;
                    case 2:
                        picBox.Image.Save(saveStream, ImageFormat.Png);
                        break;
                    case 3:
                        picBox.Image.Save(saveStream, ImageFormat.Gif);
                        break;
                    case 4:
                        picBox.Image.Save(saveStream, ImageFormat.Bmp);
                        break;
                    case 5:
                        picBox.Image.Save(saveStream, ImageFormat.Tiff);
                        break;
                }
                saveStream.Dispose();
                fileName = saveFile.FileName;
            }
        }
        private void SetZoom(bool areZoomed)
        {
            if (areZoomed == true)
            {
                picBox.Dock = DockStyle.Fill;
                picBox.Size = picPanel.Size;
                picBox.SizeMode = PictureBoxSizeMode.Zoom;                
            }
            else
            {
                if (picBox.Image.Height > picPanel.Height)
                {
                    picBox.Dock = DockStyle.None;
                    if (picBox.Image.Width > picPanel.Width)
                    {                        
                        picBox.Size = picBox.Image.Size;
                    }
                    else
                    {
                        picBox.Height = picBox.Image.Height;
                        picBox.Width = picPanel.Width - 17;
                    }
                }
                else
                {
                    if (picBox.Image.Width > picPanel.Width)
                    {
                        picBox.Dock = DockStyle.None;
                        picBox.Height = picPanel.Height - 17;
                        picBox.Width = picBox.Image.Width;
                    }
                    else
                    {
                        picBox.Dock = DockStyle.Fill;
                    }
                }
                picBox.SizeMode = PictureBoxSizeMode.CenterImage;
            }
        }
        private int Ext_to_Index(string fileExt)
        {
            int newIndex = 1;
            switch (fileExt)
            {
                case ".jpg":
                    newIndex = 1;
                    break;
                case ".jpeg":
                    newIndex = 1;
                    break;
                case ".png":
                    newIndex = 2;
                    break;
                case ".gif":
                    newIndex = 3;
                    break;
                case ".bmp":
                    newIndex = 4;
                    break;
                case ".tif":
                    newIndex = 5;
                    break;
                case ".tiff":
                    newIndex = 5;
                    break;
            }
            return newIndex;
        }
    }
}