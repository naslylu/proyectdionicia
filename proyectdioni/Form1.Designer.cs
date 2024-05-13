namespace proyectdioni
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btn_Cliente = new System.Windows.Forms.Button();
            this.btn_Empleado = new System.Windows.Forms.Button();
            this.btn_Factura = new System.Windows.Forms.Button();
            this.btn_Inventario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Cerrar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panelformulario = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Cliente
            // 
            this.btn_Cliente.BackColor = System.Drawing.Color.Plum;
            this.btn_Cliente.CausesValidation = false;
            this.btn_Cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cliente.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cliente.ForeColor = System.Drawing.Color.White;
            this.btn_Cliente.Location = new System.Drawing.Point(12, 149);
            this.btn_Cliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Cliente.Name = "btn_Cliente";
            this.btn_Cliente.Size = new System.Drawing.Size(201, 55);
            this.btn_Cliente.TabIndex = 0;
            this.btn_Cliente.Text = "Clientes";
            this.btn_Cliente.UseVisualStyleBackColor = false;
            this.btn_Cliente.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Empleado
            // 
            this.btn_Empleado.BackColor = System.Drawing.Color.Plum;
            this.btn_Empleado.CausesValidation = false;
            this.btn_Empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Empleado.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Empleado.ForeColor = System.Drawing.Color.White;
            this.btn_Empleado.Location = new System.Drawing.Point(11, 223);
            this.btn_Empleado.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Empleado.Name = "btn_Empleado";
            this.btn_Empleado.Size = new System.Drawing.Size(201, 56);
            this.btn_Empleado.TabIndex = 1;
            this.btn_Empleado.Text = "Empleados";
            this.btn_Empleado.UseVisualStyleBackColor = false;
            this.btn_Empleado.Click += new System.EventHandler(this.btn_Empleado_Click);
            // 
            // btn_Factura
            // 
            this.btn_Factura.BackColor = System.Drawing.Color.Plum;
            this.btn_Factura.CausesValidation = false;
            this.btn_Factura.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Factura.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Factura.ForeColor = System.Drawing.Color.White;
            this.btn_Factura.Location = new System.Drawing.Point(11, 300);
            this.btn_Factura.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Factura.Name = "btn_Factura";
            this.btn_Factura.Size = new System.Drawing.Size(201, 53);
            this.btn_Factura.TabIndex = 2;
            this.btn_Factura.Text = "Facturas";
            this.btn_Factura.UseVisualStyleBackColor = false;
            this.btn_Factura.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_Inventario
            // 
            this.btn_Inventario.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btn_Inventario.BackColor = System.Drawing.Color.Plum;
            this.btn_Inventario.CausesValidation = false;
            this.btn_Inventario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Inventario.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inventario.ForeColor = System.Drawing.Color.White;
            this.btn_Inventario.Location = new System.Drawing.Point(11, 374);
            this.btn_Inventario.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Inventario.Name = "btn_Inventario";
            this.btn_Inventario.Size = new System.Drawing.Size(201, 52);
            this.btn_Inventario.TabIndex = 3;
            this.btn_Inventario.Text = "Inventario";
            this.btn_Inventario.UseVisualStyleBackColor = false;
            this.btn_Inventario.Click += new System.EventHandler(this.btn_Inventario_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Purple;
            this.panel1.Controls.Add(this.btn_Cerrar);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btn_Cliente);
            this.panel1.Controls.Add(this.btn_Inventario);
            this.panel1.Controls.Add(this.btn_Empleado);
            this.panel1.Controls.Add(this.btn_Factura);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 719);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.BackColor = System.Drawing.Color.Plum;
            this.btn_Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Cerrar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cerrar.ForeColor = System.Drawing.Color.White;
            this.btn_Cerrar.Location = new System.Drawing.Point(34, 458);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(160, 70);
            this.btn_Cerrar.TabIndex = 6;
            this.btn_Cerrar.Text = "Cerrar";
            this.btn_Cerrar.UseVisualStyleBackColor = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::proyectdioni.Properties.Resources.Copia_de_logo_marca_empresa_circular_redondo_blanco;
            this.pictureBox1.Location = new System.Drawing.Point(11, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(511, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(415, 34);
            this.label1.TabIndex = 5;
            this.label1.Text = "MINIMARKET HEALTHY";
            // 
            // panelformulario
            // 
            this.panelformulario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelformulario.BackgroundImage")));
            this.panelformulario.Location = new System.Drawing.Point(246, 71);
            this.panelformulario.Name = "panelformulario";
            this.panelformulario.Size = new System.Drawing.Size(1391, 710);
            this.panelformulario.TabIndex = 6;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Violet;
            this.ClientSize = new System.Drawing.Size(1370, 749);
            this.Controls.Add(this.panelformulario);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Cliente;
        private System.Windows.Forms.Button btn_Empleado;
        private System.Windows.Forms.Button btn_Factura;
        private System.Windows.Forms.Button btn_Inventario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelformulario;
        private System.Windows.Forms.Button btn_Cerrar;
    }
}

