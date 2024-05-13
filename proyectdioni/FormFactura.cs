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
using System.Data.Common;
using System.Data.SqlTypes;

namespace proyectdioni
{
    public partial class FormFactura : Form
    {
        private string connectionString = "Data Source=DESKTOP-DE-NAS;Initial Catalog=SISTEMA_VENTASS;User ID=sa;Password=0311;Trust Server Certificate=True";
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable dataTable;
        public FormFactura()
        {
            InitializeComponent();

            dgv_factura.DataError += DataGridView_DataError;
            dgv_factura.RowErrorTextNeeded += DataGridView_RowErrorTextNeeded;
        }

        private void DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            // Manejar errores de datos en el DataGridView
            MessageBox.Show("Error al procesar datos en la fila " + e.RowIndex + ", columna " + e.ColumnIndex + ": " + e.Exception.Message);
        }

        private void DataGridView_RowErrorTextNeeded(object sender, DataGridViewRowErrorTextNeededEventArgs e)
        {
            // Proporcionar texto de error para las filas del DataGridView
            e.ErrorText = "Error en la fila " + e.RowIndex;
        }
    

        private void FormFactura_Load(object sender, EventArgs e)
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
                string query = "SELECT * FROM factura2";
                adapter = new SqlDataAdapter(query, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                dataTable = new DataTable();
                adapter.Fill(dataTable);

                // Limpiar las columnas existentes en el DataGridView
                dgv_factura.Columns.Clear();

                // Configurar manualmente todas las columnas en el DataGridView
                foreach (DataColumn column in dataTable.Columns)
                {
                    DataGridViewTextBoxColumn dgvColumn = new DataGridViewTextBoxColumn();
                    dgvColumn.DataPropertyName = column.ColumnName; // Nombre de la columna en la tabla
                    dgvColumn.HeaderText = column.ColumnName; // Encabezado de la columna
                    dgv_factura.Columns.Add(dgvColumn);
                }

                // Asignar el DataTable como fuente de datos del DataGridView
                dgv_factura.DataSource = dataTable;
                dgv_factura.ReadOnly = false;

                MessageBox.Show("Datos cargados correctamente en el DataGridView.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }
    

            private void label1_Click(object sender, EventArgs e)
            {

            }

            private void btn_Agregar_Click(object sender, EventArgs e)
            {
                try
                {
                    // Asegurarse de que el DataTable esté inicializado
                    if (dataTable == null)
                    {
                        LoadData(); // Cargar datos si el DataTable no está inicializado
                    }
                    {
                        DataRow newRow = dataTable.NewRow();
                        newRow["fecha_factura"] = DateTime.ParseExact(txt_Fecha.Text, "dd/MM/yyyy", null);
                        newRow["nombre_producto"] = txt_Name.Text;
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
                    MessageBox.Show("Factura agregada correctamente.");
                }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar factura: " + ex.Message);
                }
            }

           

        }

   
        }
    
