using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp20
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void class11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void class31_Click(object sender, EventArgs e)
        {

        }

        private void class25_Click(object sender, EventArgs e)
        {

        }

        private void class23_Click(object sender, EventArgs e)
        {

        }

        private void class27_Click(object sender, EventArgs e)
        {
            
        }

        private void class27_Enter(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(open_patient);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
            void open_patient()
            {
                Application.Run(new patients());
            }
        }
    }
}
