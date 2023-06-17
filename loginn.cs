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
using WindowsFormsApp20.db;

namespace WindowsFormsApp20
{
    public partial class loginn : Form
    {
        lastdbEntities db = new lastdbEntities();
        public loginn()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        

        private void loginn_Load(object sender, EventArgs e)
        {
            textBox3.Text = "Enter your email";
            textBox4.Text = "Enter your password";
            textBox3.ForeColor = Color.LightGray;
            textBox4.ForeColor = Color.LightGray;
        }
        private void textBox3_Enter(object sender, EventArgs e)
        {

            if (textBox3.Text == "Enter your email")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;


            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                textBox3.Text = "Enter your email";
                textBox3.ForeColor = Color.LightGray;


            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == "Enter your password")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;


            }
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                textBox4.Text = "Enter your password";
                textBox4.ForeColor = Color.LightGray;


            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(open_Form1Page);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();


        }
        void open_Form1Page()
        {
            Application.Run(new sign_up());
        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            var result = db.users.Where(y => y.email == textBox3.Text && y.password == textBox4.Text).ToList();
             if (result.Count() > 0)
             {
                 
                this.Close();
                Thread th = new Thread(open_home1);
                th.SetApartmentState(ApartmentState.STA);
                th.Start();
                void open_home1()
                {
                    Application.Run(new home());
                }
                
                 
             }
             else
             {
                 MessageBox.Show("email or password are invalid");
             }
        }
    }
}
