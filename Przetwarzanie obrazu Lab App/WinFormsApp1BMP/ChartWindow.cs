using Emgu.CV.Reg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace WinFormsApp1BMP
{//Install-Package WinForms.DataVisualization -Version 1.9.2

    public partial class ChartWindow : Form
    {
        private List<Series> series;

        public ChartWindow()
        {

            InitializeComponent();

        }

        public ChartWindow(List<Series> series, string title = "") : this()
        {
            chart1.Series.Clear();
            int row = 0;
            foreach (var item in series)
            {
                chart1.Series.Add(item);
                Button button = new Button();
                button.Dock=DockStyle.Fill;
                button.Text = item.Name;
                button.Tag = item;
                button.Click += SeriesButton_Click;
                tableLayoutPanel1.Controls.Add(button, 1, row++);
            }
            this.Text = title;
        }

        private void SeriesButton_Click(object? sender, EventArgs e)
        {
            var obj = (Button)sender;
            var item = (Series)obj.Tag;
            item.Enabled=!item.Enabled;
            obj.Text = item.Enabled ? item.Name : item.Name + " wył";
        }

        private void PictureWindows_Load(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
