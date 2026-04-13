namespace Meloht.WinFormsViewImage
{
    public class FormImageViewUtils
    {
        public static void Show(string fileName, byte[] imgData)
        {
            FormShowImage showImage = new FormShowImage(fileName, imgData);
            showImage.Show();
        }
        public static void Show(string fileName, string filePath)
        {
            FormShowImage showImage = new FormShowImage(fileName, filePath);
            showImage.Show();
        }
        public static void Show(string filePath)
        {
            FormShowImage showImage = new FormShowImage(filePath);
            showImage.Show();
        }


        public static void ShowDialog(string fileName, byte[] imgData)
        {
            FormShowImage showImage = new FormShowImage(fileName, imgData);
            showImage.ShowDialog();
        }
        public static void ShowDialog(string fileName, string filePath)
        {
            FormShowImage showImage = new FormShowImage(fileName, filePath);
            showImage.ShowDialog();
        }
        public static void ShowDialog(string filePath)
        {
            FormShowImage showImage = new FormShowImage(filePath);
            showImage.ShowDialog();
        }
    }
}
