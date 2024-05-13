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
    public partial class FormFacctura : Form
    {
        private const string V = "SELECT * FROM factura2";
        private string connectionString = "Data Source=DESKTOP-DE-NAS;Initial Catalog=SISTEMA_VENTASS;User ID=sa;Password=0311";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public FormFacctura()
        {
            InitializeComponent();
        }

       
        private void LoadData()
        {
            try
            {
                string query = V;
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_facturr.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
            btn_Buscar.Click += btn_Buscar_Click;
        }
                private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow newRow = dataTable.NewRow();
                newRow["fecha_factura"] = DateTime.ParseExact(txt_Fecha.Text, "dd/MM/yyyy", null);
                newRow["nombre_producto"] = txt_Producto.Text;
                newRow["cantidad"] = Convert.ToDecimal(txt_Cantidad.Text);
                newRow["Itbis"] = Convert.ToDecimal(txt_Itbis.Text);
                newRow["precio_producto"] = Convert.ToDecimal(txt_Precio.Text);

                decimal cantidad = Convert.ToDecimal(txt_Cantidad.Text);
                decimal itbis = Convert.ToDecimal(txt_Itbis.Text);
                decimal precioProducto = Convert.ToDecimal(txt_Precio.Text);
                decimal total = cantidad * precioProducto * (1 + itbis / 100);

                newRow["total"] = total;

                dataTable.Rows.Add(newRow);
                adapter.Update(dataTable);
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar factura: " + ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_facturr.SelectedRows.Count > 0)
            {
                int selectedIndex = dgv_facturr.SelectedRows[0].Index;
                dgv_facturr.Rows.RemoveAt(selectedIndex);
                adapter.Update(dataTable);
                LoadData();
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
                LoadData(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
        }

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            txt_Fecha.Clear();
            txt_Producto.Clear();
            txt_Cantidad.Clear();
            txt_Itbis.Clear();
            txt_Precio.Clear();
            txt_Total.Clear();
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            string searchTerm = txt_Buscar.Text.Trim();

            if (!string.IsNullOrEmpty(searchTerm))
            {
                
                var resultados = from DataRow row in dataTable.Rows
                                 where row.Field<string>("nombre_producto").Contains(searchTerm)
                                 select row;

                
                DataTable filteredDataTable = resultados.Any() ? resultados.CopyToDataTable() : dataTable.Clone();

                
                dgv_facturr.DataSource = filteredDataTable;
            }
            else
            {
              
                dgv_facturr.DataSource = dataTable;
            }
        }

        private void dgv_facturr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            LoadData();
        }

        private void FormFacctura_Load_1(object sender, EventArgs e)
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
    }
}
