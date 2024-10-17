using System.Diagnostics;
using System.Drawing.Imaging;
using Emgu.CV;
using Emgu.Util.TypeEnum;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using Emgu.CV.Util;
using static System.Net.Mime.MediaTypeNames;
using Emgu.CV.Reg;
using static Emgu.Util.Platform;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices.JavaScript;
using System.Text;
using System;
using System.Runtime.CompilerServices;
using System.Windows.Forms.Design;
namespace WinFormsApp1BMP
{

    //Install-Package Emgu.CV
    public partial class MainForm : Form
    {
        
        
        Mat _image;
        Bitmap _imageLoaded1;
        Bitmap _imageLoaded2;
        public MainForm()
        {
            InitializeComponent();
            Htxt.Text = H.Value.ToString();
            Stxt.Text = S.Value.ToString();
            Vtxt.Text = V.Value.ToString();
            H2txt.Text = H2.Value.ToString();
            S2txt.Text = S2.Value.ToString();
            V2txt.Text = V2.Value.ToString();

        }
            
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var loaded = LoadBitmapFileWindow();
                _imageLoaded1 = loaded.Bitmap;

                pictureBox1.Image = _imageLoaded1;
                Image1Label.Text = loaded.Filename;
                PictureWindow pictureWindow = new PictureWindow(_imageLoaded1, "original");
                pictureWindow.Show();

                Recalculate();
            }
            catch (Exception ex) {
                throw ex;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            var loaded = LoadBitmapFileWindow();
            _imageLoaded2 = loaded.Bitmap ;
            this.Text = loaded.Filename;
            pictureBox2.Image = _imageLoaded2;
            PictureWindow pictureWindow = new PictureWindow(_imageLoaded2, "original");
            pictureWindow.Show();
            Recalculate();
        }


        public void Recalculate()
        {
            // pobranie wymiarób obrazu
            // int wysokosc = naszObraz.Height;
            // int szerokosc = naszObraz.Width;
            //
            // utworzenie nowej bitmapy
            // Bitmap bmp = new Bitmap(szerokosc, wysokosc);
            //
            // pobranie wartości pixela
            // bmp.GetPixel(x, y);
            //
            // ustawienie wartości pixela
            // bmp.SetPixel(x, y, color);
            //
            // stworzenie zmiennej typu color
            // Color c = Color.FromArgb(redValue, greenValue, blueValue);
            //
            // zapisanie Bitmapy do pliku 
            // bmp.Save("example.bmp");

        }
        private void H_Scroll(object sender, EventArgs e)
        {
            Htxt.Text = H.Value.ToString();
        }
        private void S_Scroll(object sender, EventArgs e)
        {
            Stxt.Text = S.Value.ToString();
        }
        private void V_Scroll(object sender, EventArgs e)
        {
            Vtxt.Text = V.Value.ToString();
        }
        private void H2_Scroll(object sender, EventArgs e)
        {
            H2txt.Text = H2.Value.ToString();
        }
        private void S2_Scroll(object sender, EventArgs e)
        {
            S2txt.Text = S2.Value.ToString();
        }
        private void V2_Scroll(object sender, EventArgs e)
        {
            V2txt.Text = V2.Value.ToString();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Recalculate();
        }
        private void Htxt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(Htxt.Text.Trim(), out int val))
            {
                H.Value = val;
            }
        }
        private void Stxt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(Stxt.Text.Trim(), out int val))
            {
                S.Value = val;
            }
        }
        private void Vtxt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(Vtxt.Text.Trim(), out int val))
            {
                V.Value = val;
            }
        }
        private void H2txt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(H2txt.Text.Trim(), out int val))
            {
                H2.Value = val;
            }
        }
        private void S2txt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(S2txt.Text.Trim(), out int val))
            {
                S2.Value = val;
            }
        }
        private void V2txt_Leave(object sender, EventArgs e)
        {
            if (int.TryParse(V2txt.Text.Trim(), out int val))
            {
                V2.Value = val;
            }
        }
        private (Bitmap Bitmap, string Filename) LoadBitmapFileWindow()
        {
            Bitmap image = null;
            string filename = string.Empty;
            try
            {
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.PNG)|*.PNG;*.JPG;*.JPEG;*.BMP";
                if (openFileDialog1.ShowDialog(this) == DialogResult.OK)
                {
                    var file = openFileDialog1.FileName;
                    this.Text = file;
                    image = new Bitmap(file);
                }
            }
            catch (Exception ex) { throw ex; }
            return (image, filename);
        }

    }
}
