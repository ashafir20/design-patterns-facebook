using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace B14_Ex01_Daniel_301840724_Aviv_301547659.Helpers.Static
{
    static class RageImageHelper
    {
        private const string k_SampleImageFileName = "ragefacesample.jpg";
        private const string k_PaintProccessName = "mspaint.exe";
        private const string k_FilterFileExtenstion = "JPG Image (*.JPG)|*.jpg|All Files (*.*)|*.*";

        public static void ShowImageInPaint(Image i_Image)
        {
            runPaintProgram(SaveImageToDesktopAndReturnFilePath(i_Image));
        }
    
        public static void ShowSaveImageDialog(Image i_Image)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Convert.ToString(Environment.SpecialFolder.MyDocuments);
            saveFileDialog.Filter = k_FilterFileExtenstion;
            saveFileDialog.FilterIndex = 1;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                i_Image.Save(saveFileDialog.FileName);
            }
        }

        public static byte[] GetJpegByteStream(Image i_Image)
        {
            MemoryStream ms = new MemoryStream();
            i_Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
            return ms.GetBuffer();
        }

        private static void runPaintProgram(string i_Path)
        {
            System.Diagnostics.ProcessStartInfo procInfo = new System.Diagnostics.ProcessStartInfo();
            procInfo.FileName = k_PaintProccessName;
            procInfo.Arguments = i_Path;
            System.Diagnostics.Process.Start(procInfo);
        }

        private static string SaveImageToDesktopAndReturnFilePath(Image i_Image)
        {
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), k_SampleImageFileName);
            using (FileStream fileStream = File.Create(filePath))
            {
                i_Image.Save(fileStream, System.Drawing.Imaging.ImageFormat.Jpeg);
            }

            return filePath;
        }
    }
}
