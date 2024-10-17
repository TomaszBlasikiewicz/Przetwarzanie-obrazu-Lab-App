using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1BMP
{
    public partial class PictureWindow : Form
    {
        public PictureWindow(Bitmap bitmap, string title="")
        {
            InitializeComponent();
            this.Text= title;
            pictureBox1.Image = bitmap;
            var size=bitmap.Size;
            this.Height = size.Height+pictureBox1.Top*2+40;
            this.Width=size.Width+pictureBox1.Left*2+20;
        }

        public PictureWindow()
        {
            InitializeComponent();
        }

        private void PictureWindows_Load(object sender, EventArgs e)
        {

        }
    }
}
