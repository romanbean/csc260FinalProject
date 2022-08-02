using System;
using System.IO;
using System.Windows.Forms;

namespace BakingUnitConverter
{
    /*
     * This class defines the ways the user can either share, download, or upload their files into our form
     */
    internal class Share : Recipe
    {
        public bool AbleToUpload(RichTextBox textbox)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.DefaultExt = ".txt"; // Required file extension 
            fileDialog.Filter = "Text documents (.txt)|*.txt"; // Optional file extensions

            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new System.IO.StreamReader(fileDialog.FileName);
                textbox.Text = sr.ReadToEnd();
                sr.Close(); // always close the file when we are done with it.
                return true;
            }

            return false;
        }

        public bool AbleToDownload(RichTextBox textbox)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text file(*.txt)|*.txt";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(saveFileDialog.FileName, textbox.Text);
                return true;
            }

            return false;
        }
    }
}
