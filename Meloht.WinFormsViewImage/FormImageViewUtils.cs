namespace Meloht.WinFormsViewImage
{
    public class FormImageViewUtils
    {
        /// <summary>
        /// Displays an image in a new window using the specified file name and image data.
        /// </summary>
        /// <param name="fileName">The name of the file to display as the window title. Cannot be null.</param>
        /// <param name="imgData">The image data to display, as a byte array. Cannot be null.</param>
        public static void Show(string fileName, byte[] imgData)
        {
            FormShowImage showImage = new FormShowImage(fileName, imgData);
            showImage.Show();
        }


        public static void Show(string fileName, Stream imgStream)
        {
            FormShowImage showImage = new FormShowImage(fileName, imgStream);
            showImage.Show();
        }

        /// <summary>
        /// Displays an image viewer form for the specified file byte array.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <param name="onImageViewerClose">onImageViewerClose is a callback action that will be invoked when the image viewer is closed, passing the image path as a parameter.</param>
        public static void Show(string fileName, string filePath, Action<string> onImageViewerClose = null)
        {
            FormShowImage showImage = new FormShowImage(fileName, filePath, onImageViewerClose);
            showImage.Show();
        }
        /// <summary>
        /// Displays an image viewer form for the specified file byte array.
        /// </summary>
        /// <param name="filePath"></param>
        /// <param name="onImageViewerClose">onImageViewerClose is a callback action that will be invoked when the image viewer is closed, passing the image path as a parameter.</param>
        public static void Show(string filePath, Action<string> onImageViewerClose = null)
        {
            FormShowImage showImage = new FormShowImage(filePath, onImageViewerClose);
            showImage.Show();
        }

        /// <summary>
        /// Displays an image in a modal dialog using the specified file name and image data.
        /// </summary>
        /// <param name="fileName">The name of the file to display as the dialog title. Cannot be null.</param>
        /// <param name="imgData">The image data to display in the dialog, as a byte array. Cannot be null.</param>
        public static void ShowDialog(string fileName, byte[] imgData)
        {
            FormShowImage showImage = new FormShowImage(fileName, imgData);
            showImage.ShowDialog();
        }
        /// <summary>
        /// Displays an image viewer dialog for the specified file path.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="filePath"></param>
        /// <param name="onImageViewerClose">onImageViewerClose is a callback action that will be invoked when the image viewer is closed, passing the image path as a parameter.</param>
        public static void ShowDialog(string fileName, string filePath, Action<string> onImageViewerClose = null)
        {
            FormShowImage showImage = new FormShowImage(fileName, filePath, onImageViewerClose);
            showImage.ShowDialog();
        }
        /// <summary>
        /// Displays an image viewer dialog for the specified file path.
        /// </summary>
        /// <param name="filePath">The path to the image file to display. Cannot be null or empty.</param>
        /// <param name="onImageViewerClose">An optional callback that is invoked with the file path when the image viewer dialog is closed. If null, no action is taken on close.</param>
        public static void ShowDialog(string filePath, Action<string> onImageViewerClose = null)
        {
            FormShowImage showImage = new FormShowImage(filePath, onImageViewerClose);
            showImage.ShowDialog();
        }
    }
}
