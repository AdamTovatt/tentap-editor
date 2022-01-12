using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TentaPEditor
{
    public partial class ImageViewer : Form
    {
        public delegate void ClosedHandler();
        public event ClosedHandler OnClosed;

        public ImageViewer(Image image)
        {
            InitializeComponent();

            pictureBox.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox.Image = image;

            Size windowSize = new Size(pictureBox.Width + 20, pictureBox.Height + 100);
            Size = windowSize;

            imageInfoLabel.Text = string.Format("Image resolution: {0}x{1}", image.Width, image.Height);
        }

        private void ImageViewer_Load(object sender, EventArgs e)
        {

        }

        private void CloseButtonClick(object sender, EventArgs e)
        {
            Close();
            OnClosed?.Invoke();
            OnClosed = null;
        }

        private void ImageViewerFormClosing(object sender, FormClosingEventArgs e)
        {
            OnClosed?.Invoke();
            OnClosed = null;
        }
    }
}
