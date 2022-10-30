namespace Login
{
    partial class Productos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgProductos = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.combCategoria = new System.Windows.Forms.ComboBox();
            this.combProveedor = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgProductos
            // 
            this.dgProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgProductos.Location = new System.Drawing.Point(26, 285);
            this.dgProductos.Name = "dgProductos";
            this.dgProductos.RowTemplate.Height = 25;
            this.dgProductos.Size = new System.Drawing.Size(1027, 353);
            this.dgProductos.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Roboto Condensed", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(29, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 22);
            this.label3.TabIndex = 11;
            this.label3.Text = "PRODUCTOS";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtCantidad, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNombre, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecioCompra, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtPrecioVenta, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.combCategoria, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.combProveedor, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(205, 66);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(649, 141);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtCantidad.Location = new System.Drawing.Point(327, 9);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.PlaceholderText = "Cantidad";
            this.txtCantidad.Size = new System.Drawing.Size(319, 23);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtNombre.Location = new System.Drawing.Point(3, 9);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PlaceholderText = "Nombre";
            this.txtNombre.Size = new System.Drawing.Size(318, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPrecioCompra.Location = new System.Drawing.Point(327, 44);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.PlaceholderText = "Precio de compra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(319, 23);
            this.txtPrecioCompra.TabIndex = 2;
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPrecioVenta.Location = new System.Drawing.Point(327, 79);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.PlaceholderText = "Precio de venta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(319, 23);
            this.txtPrecioVenta.TabIndex = 3;
            // 
            // combCategoria
            // 
            this.combCategoria.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCategoria.FormattingEnabled = true;
            this.combCategoria.Location = new System.Drawing.Point(3, 44);
            this.combCategoria.Name = "combCategoria";
            this.combCategoria.Size = new System.Drawing.Size(318, 23);
            this.combCategoria.TabIndex = 1;
            // 
            // combProveedor
            // 
            this.combProveedor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.combProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combProveedor.FormattingEnabled = true;
            this.combProveedor.Location = new System.Drawing.Point(3, 79);
            this.combProveedor.Name = "combProveedor";
            this.combProveedor.Size = new System.Drawing.Size(318, 23);
            this.combProveedor.TabIndex = 6;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 5;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnReset, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnEliminar, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGuardar, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnBuscar, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(208, 228);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(848, 51);
            this.tableLayoutPanel2.TabIndex = 14;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(172, 3);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(163, 45);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(341, 3);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(163, 45);
            this.btnGuardar.TabIndex = 1;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(510, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(163, 45);
            this.btnActualizar.TabIndex = 2;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(679, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 45);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(3, 3);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(163, 45);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Productos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 650);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.dgProductos);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Productos";
            this.Text = "Productos";
            this.Load += new System.EventHandler(this.Productos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgProductos)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dgProductos;
        private Label label3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private ComboBox combProveedor;
        private TextBox txtCantidad;
        private TextBox txtNombre;
        private ComboBox combCategoria;
        private TextBox txtPrecioCompra;
        private TextBox txtPrecioVenta;
        private Button btnBuscar;
        private Button btnGuardar;
        private Button btnActualizar;
        private Button btnEliminar;
        private Button btnReset;
    }
}