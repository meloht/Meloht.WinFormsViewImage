namespace Meloht.WinFormsViewImage.Test
{
    public partial class FormTest : Form
    {
        public FormTest()
        {
            InitializeComponent();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.openFileDialog1.Filter = "*.*|*.bmp;*.jpg;*.jpeg;*.tiff;*.tiff;*.png";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.textBoxImagePath.Text = openFileDialog1.FileName;
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxImagePath.Text))
            {
                MessageBox.Show("Please select an image file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FormImageViewUtils.Show(this.textBoxImagePath.Text);
        }

        private void btnByteShow_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxImagePath.Text))
            {
                MessageBox.Show("Please select an image file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            byte[] bytes = File.ReadAllBytes(this.textBoxImagePath.Text);
            string fileName = Path.GetFileName(this.textBoxImagePath.Text);
            FormImageViewUtils.Show(fileName, bytes);
        }

        private void btnStream_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.textBoxImagePath.Text))
            {
                MessageBox.Show("Please select an image file first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using FileStream fs = new FileStream(this.textBoxImagePath.Text, FileMode.Open, FileAccess.Read);
            string fileName = Path.GetFileName(this.textBoxImagePath.Text);
            FormImageViewUtils.Show(fileName, fs);
        }
    }
}
