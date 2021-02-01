using System;
using System.Windows.Forms;
using System.Drawing;
using Patagames.Ocr;

namespace TextFlow
{
    public partial class Main : Form
    {
        private readonly string supportedFilesFormat = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
        public Main()
        {
            InitializeComponent();
        }

        private string RecognizeText(string filename) 
        {
            using (var ocrEntity = OcrApi.Create())
            {
                ocrEntity.Init(Patagames.Ocr.Enums.Languages.English);
                string recognizedText = ocrEntity.GetTextFromImage(filename);
                return recognizedText;
            }
        }

        private void OpenDialog()
        {
            using (OpenFileDialog ofd = new OpenFileDialog() { Multiselect = false, Filter = supportedFilesFormat })
            {
                ofd.ShowDialog(this);
                recognizedTextBox.Text = RecognizeText(ofd.FileName);
            }
        }

        private void RecognizeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenDialog();
            }
            catch (Exception ex)
            {
                recognizedTextBox.Text = ex.Message;
            }
        }
    }
}
