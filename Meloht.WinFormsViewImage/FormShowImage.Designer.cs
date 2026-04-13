namespace Meloht.WinFormsViewImage
{
    partial class FormShowImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormShowImage));
            pictureBox1 = new PictureBox();
            toolStrip1 = new ToolStrip();
            toolStripBtnZoomIn = new ToolStripButton();
            toolStripBtnZoomOut = new ToolStripButton();
            panel1 = new Panel();
            panelImage = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            toolStrip1.SuspendLayout();
            panel1.SuspendLayout();
            panelImage.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(827, 493);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripBtnZoomIn, toolStripBtnZoomOut });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(830, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripBtnZoomIn
            // 
            toolStripBtnZoomIn.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnZoomIn.Image = (Image)resources.GetObject("toolStripBtnZoomIn.Image");
            toolStripBtnZoomIn.ImageTransparentColor = Color.Magenta;
            toolStripBtnZoomIn.Name = "toolStripBtnZoomIn";
            toolStripBtnZoomIn.Size = new Size(82, 22);
            toolStripBtnZoomIn.Text = "Zoom In (+)";
            toolStripBtnZoomIn.Click += toolStripBtnZoomIn_Click;
            // 
            // toolStripBtnZoomOut
            // 
            toolStripBtnZoomOut.DisplayStyle = ToolStripItemDisplayStyle.Text;
            toolStripBtnZoomOut.Image = (Image)resources.GetObject("toolStripBtnZoomOut.Image");
            toolStripBtnZoomOut.ImageTransparentColor = Color.Magenta;
            toolStripBtnZoomOut.Name = "toolStripBtnZoomOut";
            toolStripBtnZoomOut.Size = new Size(88, 22);
            toolStripBtnZoomOut.Text = "Zoom Out (-)";
            toolStripBtnZoomOut.Click += toolStripBtnZoomOut_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(827, 493);
            panel1.TabIndex = 2;
            // 
            // panelImage
            // 
            panelImage.AutoScroll = true;
            panelImage.Controls.Add(panel1);
            panelImage.Dock = DockStyle.Fill;
            panelImage.Location = new Point(0, 25);
            panelImage.Name = "panelImage";
            panelImage.Size = new Size(830, 500);
            panelImage.TabIndex = 3;
            // 
            // FormShowImage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(830, 525);
            Controls.Add(panelImage);
            Controls.Add(toolStrip1);
            Name = "FormShowImage";
            Text = "FormShowImage";
            FormClosed += FormShowImage_FormClosed;
            SizeChanged += FormShowImage_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            panel1.ResumeLayout(false);
            panelImage.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripBtnZoomIn;
        private ToolStripButton toolStripBtnZoomOut;
        private Panel panel1;
        private Panel panelImage;
    }
}