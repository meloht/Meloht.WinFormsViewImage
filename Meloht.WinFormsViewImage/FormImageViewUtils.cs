namespace Meloht.WinFormsViewImage
{
    public class FormImageViewUtils
    {

        public static void Show(string fileName, byte[] imgData)
        {
            FormShowImage showImage = new FormShowImage(fileName, imgData);
            showImage.Show();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <param name="onImageViewerClose">onImageViewerClose is a callback action that will be invoked when the image viewer is closed, passing the image path as a parameter.</param>
        public static void Show(string fileName, string filePath, Action<string> onImageViewerClose = null)
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
        /// <summary>
        /// 
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <param name="onImageViewerClose">onImageViewerClose is a callback action that will be invoked when the image viewer is closed, passing the image path as a parameter.</param>
        public static void ShowDialog(string fileName, string filePath, Action<string> onImageViewerClose = null)
        {
            FormShowImage showImage = new FormShowImage(fileName, filePath, onImageViewerClose);
            showImage.ShowDialog();
        }
        public static void ShowDialog(string filePath, Action<string> onImageViewerClose = null)
        {
            FormShowImage showImage = new FormShowImage(filePath, onImageViewerClose);
            showImage.ShowDialog();
        }
    }
}
