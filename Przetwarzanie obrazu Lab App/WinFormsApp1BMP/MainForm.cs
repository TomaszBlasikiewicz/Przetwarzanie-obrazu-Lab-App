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
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections;
using Emgu.CV.Flann;
namespace WinFormsApp1BMP
{

    //Install-Package Emgu.CV
    //Install-Package Emgu.CV.Bitmap
    //
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

        private void LoadImage1btn_Click(object sender, EventArgs e)
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
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void LoadImage2btn_Click(object sender, EventArgs e)
        {
            var loaded = LoadBitmapFileWindow();
            _imageLoaded2 = loaded.Bitmap;
            this.Text = loaded.Filename;
            pictureBox2.Image = _imageLoaded2;
            PictureWindow pictureWindow = new PictureWindow(_imageLoaded2, "original");
            pictureWindow.Show();
            Recalculate();
        }


        public void Recalculate()
        {
            //var img=AdjustBrightnessContrast(_imageLoaded1, H.Value, S.Value);
           // var img=ROzciagnijHistogram(_imageLoaded1)
           // pictureBox2.Image = img;

            //var win = new PictureWindow(img, "Contrast");

            // pobranie wymiarów obrazu
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

        private void HistBtn_Click(object sender, EventArgs e)
        {

            //stworzenie nowej serii danych na wykres
            //Series seriesRed = new Series
            //{
            //    Name = "Red",
            //    Color = Color.Red,
            //    ChartType = SeriesChartType.Column
            //};
            //
            //dodanie do serii danych punktów na wykres
            //seriesRed.AddXY(wartośćX, WartośćY);
            //
            //stworzenie nowej kolekcji dla wielu serii  
            //List<Series> series = new List<Series>();
            //
            //dodanie do kolekcji utworzonej wczesniej serii danych
            //series.Add(seriesRed);
            //
            //przekazanie kolekcji danych do okna wykresu
            //ChartWindow chart = new ChartWindow(series, "histogram obrazu");
            //chart.Show();

            Series seriesRed = new Series
            {
                Name = "Red",
                Color = Color.Red,
                ChartType = SeriesChartType.FastLine
            };


            List<Series> series = new List<Series>() { seriesRed };

            
            ChartWindow chart = new ChartWindow(series, $"histogram obrazu ");
            chart.Show();

        }


    }
}
    

