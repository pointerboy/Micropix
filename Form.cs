using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading;
using System.Windows.Forms;

namespace Micropix
{
    public partial class Form : System.Windows.Forms.Form
    {
        private bool isFreeFormSnipActive = true;

        private void SetupSnipButtonIcon()
        {
            snipBtn.Image = Image.FromFile(@"favicon_.ico");
            snipBtn.ImageAlign = ContentAlignment.MiddleCenter;
        }

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            SetupSnipButtonIcon();
        }

        private void snipBtn_Click(object sender, EventArgs e)
        {
            if(timerCombobox.SelectedIndex != -1)
            {
                Hide();
                Thread.Sleep(timerCombobox.SelectedIndex+1 * 1000);
            }

            if (isFreeFormSnipActive)
            {
                var takenPictureBmp = Snip.Snipping();
                if (takenPictureBmp != null)
                {
                    Show();
                    notificationLabel.Text = "Picture taken sucessfuly! Ready to be exported";
                    notificationLabel.ForeColor = Color.Green;

                    if (autosaveCheckBox.Checked)
                    {
                        Clipboard.SetImage(takenPictureBmp);
                        notificationLabel.Text = "Picture saved to clipboard";
                    }
                    else
                    {
                        SaveFileDialog saveDialog = new SaveFileDialog();
                        saveDialog.Filter = "Images|*.png;*.bmp;*.jpg";
                        ImageFormat format = ImageFormat.Png;
                        if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {
                            string ext = System.IO.Path.GetExtension(saveDialog.FileName);
                            switch (ext)
                            {
                                case ".jpg":
                                    format = ImageFormat.Jpeg;
                                    break;
                                case ".bmp":
                                    format = ImageFormat.Bmp;
                                    break;
                            }
                            Bitmap pictureToSave = new Bitmap(takenPictureBmp);
                            pictureToSave.Save(saveDialog.FileName, format);
                        }
                    }
                }
            }
            else
            {
               
            }
           
        }

        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

        }

        private void freeformToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFreeFormSnipActive = true;
        }

        private void fullScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            isFreeFormSnipActive = false;
        }
    }
}
