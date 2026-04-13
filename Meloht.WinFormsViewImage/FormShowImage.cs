using Meloht.WinFormsViewImage;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Meloht.WinFormsViewImage
{
    public partial class FormShowImage : Form
    {
        private bool isImage = false;
        private string _imagePath;
        public Action<string> _onImageViewerClose;
        public FormShowImage()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer |
                          ControlStyles.AllPaintingInWmPaint |
                          ControlStyles.UserPaint, true);
            this.UpdateStyles();
            isImage = false;
        }

        public FormShowImage(string fileName, byte[] imgData) : this()
        {
            //this.pictureBox1.MouseWheel += PictureBox1_MouseWheel;
            this.Text = fileName;

            if (imgData != null && imgData.Length > 0)
            {
                using (MemoryStream memoryStream = new MemoryStream(imgData))
                {
                    isImage = true;
                    this.pictureBox1.Image = Image.FromStream(memoryStream);
                }
            }
        }
        public FormShowImage(string fileName, string filePath, Action<string> onImageViewerClose = null) : this()
        {
            //this.pictureBox1.MouseWheel += PictureBox1_MouseWheel;
            InitFilePath(fileName, filePath, onImageViewerClose);
        }
        public FormShowImage(string filePath, Action<string> onImageViewerClose = null) : this()
        {
            string fileName = Path.GetFileName(filePath);

            InitFilePath(fileName, filePath, onImageViewerClose);
        }

        private void InitFilePath(string fileName, string filePath, Action<string> onImageViewerClose)
        {
            this.Text = fileName;
            _imagePath = filePath;
            _onImageViewerClose = onImageViewerClose;
            if (filePath != null && filePath.Length > 0)
            {
                isImage = true;
                this.pictureBox1.Image = Image.FromFile(filePath);
            }
        }


        private void PictureBox1_MouseWheel(object? sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                toolStripBtnZoomIn_Click(null, null);
            }
            else
            {
                toolStripBtnZoomOut_Click(null, null);
            }
        }

        private void ApplyZoom(float zoomFactor)
        {
            if (!isImage) return;

            // 限制缩放范围
            zoomFactor = Math.Max(0.1f, Math.Min(10.0f, zoomFactor));

            // 计算新尺寸并调整PictureBox
            int newWidth = Math.Max((int)(panel1.ClientSize.Width * zoomFactor), this.panelImage.Width - 3);
            int newHeight = Math.Max((int)(panel1.ClientSize.Height * zoomFactor), this.panelImage.Height - 3);

            panel1.Size = new Size(newWidth, newHeight);


        }

        private void toolStripBtnZoomIn_Click(object sender, EventArgs e)
        {
            float zoomFactor = 1.1f;
            ApplyZoom(zoomFactor);
        }

        private void toolStripBtnZoomOut_Click(object sender, EventArgs e)
        {
            float zoomFactor = 0.9f;
            ApplyZoom(zoomFactor);
        }

        private void FormShowImage_SizeChanged(object sender, EventArgs e)
        {
            panel1.Size = new Size(this.panelImage.Size.Width - 3, this.panelImage.Height - 3);

        }

        private void FormShowImage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
                this.pictureBox1.Image = null;
            }
            if (_onImageViewerClose != null)
            {
                _onImageViewerClose(_imagePath);
            }
        }
    }
}
