using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace proyectdioni
{
    public partial class FormCliente : Form
    {

        private string connectionString = "Data Source=DESKTOP-DE-NAS;Initial Catalog=SISTEMA_VENTASS;User ID=sa;Password=0311";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public FormCliente()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            try
            {
                connection = new SqlConnection(connectionString);
                connection.Open();

                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar a la base de datos: " + ex.Message);
            }
        }
        

            private void LoadData()
            {
                try
                {
                    string query = "SELECT * FROM Clientes";
                    adapter = new SqlDataAdapter(query, connection);
                    SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                    dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dgv_cliente.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al cargar datos: " + ex.Message);
                }
            }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = dataTable.NewRow();
                newRow["Nombre"] = txt_Nombre.Text;
                newRow["Apellido"] = txt_Apellido.Text;
                newRow["Cedula"] = Convert.ToInt32(txt_Cedula.Text);
                newRow["Direccion"] = txt_Direccion.Text;
           

                dataTable.Rows.Add(newRow);
                adapter.Update(dataTable);
                LoadData(); // recargar inserción
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar empleado: " + ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_cliente.SelectedRows.Count > 0)
            {
                int selectedIndex = dgv_cliente.SelectedRows[0].Index;
                dgv_cliente.Rows.RemoveAt(selectedIndex);
                adapter.Update(dataTable);
                LoadData(); // recargar datos
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dataTable);
                LoadData(); // recargar datos en el DataGridView después de la actualización
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Nombre.Clear();
            txt_Apellido.Clear();
            txt_Cedula.Clear();
            txt_Direccion.Clear();
            txt_Telefono.Clear();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT * FROM Clientes";
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_cliente.DataSource = dataTable;

                // Edición
                dgv_cliente.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            string searchTerm = textBox1.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                var resultados = from DataRow row in dataTable.Rows
                                 where row.Field<string>("Nombre").Contains(searchTerm)
                                 select row;

                DataTable filteredDataTable = resultados.Any() ? resultados.CopyToDataTable() : dataTable.Clone();
                dgv_cliente.DataSource = filteredDataTable;
            }
            else
            {
                dgv_cliente.DataSource = dataTable;
            }
        }
    }
    }

