using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlTypes;
using System.Data.SqlClient;
using System.Data.Common;

namespace proyectdioni
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            
            //RUTA CONEXION
        }

        private void button1_Click(object sender, EventArgs e)
        {
          

            panelformulario_Paint (new FormCliente());


        }

        private void button3_Click(object sender, EventArgs e)
        {
      

            panelformulario_Paint(new FormFacctura());
        }

        private void btn_Empleado_Click(object sender, EventArgs e)
        {

            panelformulario_Paint(new FormEmpleado());
        }

        private void btn_Inventario_Click(object sender, EventArgs e)
        {
           

            panelformulario_Paint(new FormInventario());
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private Form activeForm = null;
        private void panelformulario_Paint (Form formularioh)
        {
    
            if (activeForm != null)
                activeForm.Close();
            activeForm = formularioh;
            formularioh.TopLevel = false;
            formularioh.Dock = DockStyle.Fill;
            panelformulario.Controls.Add(formularioh);
            panelformulario.Tag = formularioh;
            formularioh.BringToFront();
            formularioh.Show();


        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
    

}
