using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qak_numbers
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
        }

        private void btnNumri_Click(object sender, EventArgs e)
        {
            int numri_pare = Convert.ToInt32(txtNumrat.Text);
            int numri_dyte = Convert.ToInt32(txtRendor.Text);
            int numri_tret = Convert.ToInt32(txt_viti_.Text);
            //e Para
            lbl_nr1.Text = numri_pare.ToString();
            lbl_nr2.Text = (numri_pare + 99).ToString();
            nr_rendor1.Text = numri_dyte.ToString();
            lbl_viti.Text = numri_tret.ToString() + "/A";
            //e Dyta
            lbl_nr3.Text = (numri_pare + 100).ToString();
            lbl_nr4.Text = (numri_pare + 199).ToString();
            nr_rendor2.Text = (numri_dyte+1).ToString();
            lbl_viti1.Text = numri_tret.ToString() + "/A";
            //e Treta
            lbl_nr5.Text = (numri_pare + 200).ToString();
            lbl_nr6.Text = (numri_pare + 299).ToString();
            nr_rendor3.Text = (numri_dyte+2).ToString();
            lbl_viti2.Text = numri_tret.ToString() + "/A";
            //e katerta
            lbl_nr7.Text = (numri_pare + 300).ToString();
            lbl_nr8.Text = (numri_pare + 399).ToString();
            nr_rendor5.Text = (numri_dyte+3).ToString();
            lbl_viti3.Text = numri_tret.ToString() + "/A";
            //e pesta
            lbl_nr9.Text = (numri_pare + 400).ToString();
            lbl_nr10.Text = (numri_pare + 499).ToString();
            nr_rendor7.Text = (numri_dyte + 4).ToString();
            lbl_viti4.Text = numri_tret.ToString() + "/A";





        }
        Bitmap memoryImage;

        private void CaptureScreen()
        {
            Graphics myGraphics = this.CreateGraphics();
            Size s = this.Size;
            memoryImage = new Bitmap(s.Width, s.Height, myGraphics);
            Graphics memoryGraphics = Graphics.FromImage(memoryImage);
            memoryGraphics.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, s);
        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            CaptureScreen();
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(memoryImage, 0, 0);
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }
    }
}
