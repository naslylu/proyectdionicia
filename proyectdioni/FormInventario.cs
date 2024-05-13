using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectdioni
{
    public partial class FormInventario : Form
    {
        private string connectionString = "Data Source=DESKTOP-DE-NAS;Initial Catalog=SISTEMA_VENTASS;User ID=sa;Password=0311";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public FormInventario()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txt_Producto.Clear();
            txt_Descripcion.Clear();
            txt_Stock.Clear();
            txt_Entrada.Clear();
            txt_Salida.Clear();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                adapter.Update(dataTable);
                LoadData(); // recargar datos 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar datos: " + ex.Message);
            }
        }

        private void FormInventario_Load(object sender, EventArgs e)
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
                string query = "SELECT * FROM inventario_Producto";
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dataTable = new DataTable();
                adapter.Fill(dataTable);
                dgv_inventario.DataSource = dataTable;
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
                newRow["Nombre_producto"] = txt_Producto.Text;
                newRow["Descripción"] = txt_Descripcion.Text;
                newRow["Stock_inicial"] = Convert.ToDecimal(txt_Stock.Text);
                newRow["Entrada_producto"] = Convert.ToDecimal(txt_Entrada.Text);
                newRow["Salida_producto"] = Convert.ToDecimal(txt_Salida.Text);

                DateTime fechaEntrada = DateTime.ParseExact(txt_Fechaentrada.Text, "dd/MM/yyyy", null);
                DateTime fechaSalida = DateTime.ParseExact(txt_Fechasalida.Text, "dd/MM/yyyy", null);

                newRow["Fecha_entrada"] = fechaEntrada;
                newRow["Fecha_salida"] = fechaSalida;

                decimal stockInicial = Convert.ToDecimal(txt_Stock.Text);
                decimal entradaProducto = Convert.ToDecimal(txt_Entrada.Text);
                decimal salidaProducto = Convert.ToDecimal(txt_Salida.Text);
                decimal total = stockInicial + entradaProducto - salidaProducto;

                newRow["Total"] = total;

                dataTable.Rows.Add(newRow);
                adapter.Update(dataTable);
                LoadData(); // Recargar inserción
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar producto: " + ex.Message);
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dgv_inventario.SelectedRows.Count > 0)
            {
                int selectedIndex = dgv_inventario.SelectedRows[0].Index;
                dgv_inventario.Rows.RemoveAt(selectedIndex);
                adapter.Update(dataTable);
                LoadData(); // Recargar datos
            }
            else
            {
                MessageBox.Show("Seleccione una fila para eliminar.");
            }
        }

        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_Buscar_TextChanged(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }

        private void RealizarBusqueda()
        {
            string searchTerm = txt_Buscar.Text.Trim();

            try
            {
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    var resultados = from DataRow row in dataTable.Rows
                                     where row.Field<string>("Nombre_producto").Contains(searchTerm) ||
                                           row.Field<string>("Descripción").Contains(searchTerm)
                                     select row;

                    DataTable filteredDataTable = resultados.Any() ? resultados.CopyToDataTable() : dataTable.Clone();
                    dgv_inventario.DataSource = filteredDataTable;
                }
                else
                {
                    LoadData(); // Recargar 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar la búsqueda: " + ex.Message);
            }
        }
    }
}

