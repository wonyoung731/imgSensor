using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace imgSensor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double imgsensor = Convert.ToDouble(textBox1.Text);
            double focalLength = Convert.ToDouble(textBox2.Text);
            double pixelResolution = Convert.ToDouble(textBox3.Text);
            //int wd = Convert.ToInt32(textBox4.Text);
            double fov = (imgsensor * pixelResolution);
            double wd = (focalLength * fov) / imgsensor;

            textBox4.Text = wd.ToString();
        }

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    int imgsensor = Convert.ToInt32(textBox1.Text);
        //    int focalLength = Convert.ToInt32(textBox2.Text);
        //    int wd = Convert.ToInt32(textBox4.Text);
        //    int fov = (imgsensor * wd) / focalLength;

        //    textBox5.Text = fov.ToString();
        //}

        private void button2_Click_1(object sender, EventArgs e)
        {
            double imgsensor = Convert.ToDouble(textBox1.Text);
            double pixelResolution = Convert.ToDouble(textBox3.Text);
            double fov = (imgsensor * pixelResolution);

            textBox5.Text = fov.ToString();
        }

    }
}
