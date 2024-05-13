using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectdioni
{
    public partial class FormLogin : Form
    {

        public FormLogin()
        {
            InitializeComponent();
            this.Load += FormLogin_Load;
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Form1 secundario = new Form1();


            secundario.Show();
        }


        private void btn_Login_Click(object sender, EventArgs e)
        {
            if (txt_Usuario.Text == "naslita" && txt_Contraseña.Text == "031107")
            {
                Form1 form1 = new Form1();
                this.Hide();
                form1.ShowDialog();
            }
            else
            {
                MessageBox.Show("El usuario o contraseña ingresado es incorrecto.");
                txt_Usuario.Clear();
                txt_Contraseña.Clear();
            }
        }
    }
   
        }
    