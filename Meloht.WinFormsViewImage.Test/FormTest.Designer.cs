namespace Meloht.WinFormsViewImage.Test
{
    partial class FormTest
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxImagePath = new TextBox();
            btnSelect = new Button();
            btnShow = new Button();
            openFileDialog1 = new OpenFileDialog();
            btnByteShow = new Button();
            SuspendLayout();
            // 
            // textBoxImagePath
            // 
            textBoxImagePath.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxImagePath.Location = new Point(12, 12);
            textBoxImagePath.Name = "textBoxImagePath";
            textBoxImagePath.ReadOnly = true;
            textBoxImagePath.Size = new Size(393, 23);
            textBoxImagePath.TabIndex = 0;
            // 
            // btnSelect
            // 
            btnSelect.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSelect.Location = new Point(411, 12);
            btnSelect.Name = "btnSelect";
            btnSelect.Size = new Size(103, 23);
            btnSelect.TabIndex = 1;
            btnSelect.Text = "SelectImage";
            btnSelect.UseVisualStyleBackColor = true;
            btnSelect.Click += btnSelect_Click;
            // 
            // btnShow
            // 
            btnShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnShow.Location = new Point(526, 12);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(101, 23);
            btnShow.TabIndex = 2;
            btnShow.Text = "Show";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShow_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnByteShow
            // 
            btnByteShow.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnByteShow.Location = new Point(526, 41);
            btnByteShow.Name = "btnByteShow";
            btnByteShow.Size = new Size(101, 23);
            btnByteShow.TabIndex = 3;
            btnByteShow.Text = "ByteShow";
            btnByteShow.UseVisualStyleBackColor = true;
            btnByteShow.Click += btnByteShow_Click;
            // 
            // FormTest
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 219);
            Controls.Add(btnByteShow);
            Controls.Add(btnShow);
            Controls.Add(btnSelect);
            Controls.Add(textBoxImagePath);
            Name = "FormTest";
            Text = "FormTest";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxImagePath;
        private Button btnSelect;
        private Button btnShow;
        private OpenFileDialog openFileDialog1;
        private Button btnByteShow;
    }
}
