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
    public partial class sign_up : Form
    {
        public sign_up()
        {
            InitializeComponent();
        }

        private void sign_up_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Enter your email";
            textBox2.Text = "Enter your password";
            textLaboratory.Text = "Enter your LabName";
            textBox1.ForeColor = Color.LightGray;
            textBox2.ForeColor = Color.LightGray;
            textLaboratory.ForeColor = Color.LightGray;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == "Enter your email")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;


            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                textBox1.Text = "Enter your email";
                textBox1.ForeColor = Color.LightGray;


            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Enter your password")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;


            }
        }

        

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Enter your password";
                textBox2.ForeColor = Color.LightGray;


            }
        }

        private void textLaboratory_Enter(object sender, EventArgs e)
        {
            if (textLaboratory.Text == "Enter your LabName")
            {
                textLaboratory.Text = "";
                textLaboratory.ForeColor = Color.Black;


            }
        }

        private void textLaboratory_Leave(object sender, EventArgs e)
        {
            if (textLaboratory.Text == "")
            {
                textLaboratory.Text = "Enter your LabName";
                textLaboratory.ForeColor = Color.LightGray;


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
            Thread th = new Thread(open_loginPage);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();
        }
        void open_loginPage()
        {
            Application.Run(new loginn());
        }
        //db
        lastdbEntities db = new lastdbEntities();
        private void button1_Click(object sender, EventArgs e)
        {
            user obj = new user();
            obj.email = textBox1.Text;
            obj.password = textBox2.Text;
            obj.lab_name = textLaboratory.Text;
            db.users.Add(obj);
            db.SaveChanges();
            this.Close();
            Thread th = new Thread(open_home);
            th.SetApartmentState(ApartmentState.STA);
            th.Start();

        }
        void open_home()
        {
            Application.Run(new home());
        }
    }
}
