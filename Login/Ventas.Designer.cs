namespace Login
{
    partial class Ventas
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
            this.label1 = new System.Windows.Forms.Label();
            this.combProducto = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.combNombreProducto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNumericBox = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAgregarAVenta = new System.Windows.Forms.Button();
            this.dataGridDetalleVenta = new System.Windows.Forms.DataGridView();
            this.TipoProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.combCliente = new System.Windows.Forms.ComboBox();
            this.combTipoComprobante = new System.Windows.Forms.ComboBox();
            this.combFormaPago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutNuevaFactura = new System.Windows.Forms.TableLayoutPanel();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleVenta)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutNuevaFactura.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS";
            // 
            // combProducto
            // 
            this.combProducto.FormattingEnabled = true;
            this.combProducto.Location = new System.Drawing.Point(3, 23);
            this.combProducto.Name = "combProducto";
            this.combProducto.Size = new System.Drawing.Size(121, 23);
            this.combProducto.TabIndex = 1;
            this.combProducto.SelectionChangeCommitted += new System.EventHandler(this.combProducto_SelectionChangeCommitted);
            this.combProducto.SelectedValueChanged += new System.EventHandler(this.combProducto_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Producto";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // combNombreProducto
            // 
            this.combNombreProducto.Enabled = false;
            this.combNombreProducto.FormattingEnabled = true;
            this.combNombreProducto.Location = new System.Drawing.Point(177, 23);
            this.combNombreProducto.Name = "combNombreProducto";
            this.combNombreProducto.Size = new System.Drawing.Size(168, 23);
            this.combNombreProducto.TabIndex = 3;
            this.combNombreProducto.SelectionChangeCommitted += new System.EventHandler(this.combNombreProducto_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del producto";
            // 
            // txtNumericBox
            // 
            this.txtNumericBox.Enabled = false;
            this.txtNumericBox.Location = new System.Drawing.Point(351, 23);
            this.txtNumericBox.Name = "txtNumericBox";
            this.txtNumericBox.Size = new System.Drawing.Size(55, 23);
            this.txtNumericBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // btnAgregarAVenta
            // 
            this.btnAgregarAVenta.Location = new System.Drawing.Point(525, 23);
            this.btnAgregarAVenta.Name = "btnAgregarAVenta";
            this.btnAgregarAVenta.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarAVenta.TabIndex = 7;
            this.btnAgregarAVenta.Text = "Agregar a pedido";
            this.btnAgregarAVenta.UseVisualStyleBackColor = true;
            this.btnAgregarAVenta.Click += new System.EventHandler(this.btnAgregarAVenta_Click);
            // 
            // dataGridDetalleVenta
            // 
            this.dataGridDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoProducto,
            this.NombreProducto,
            this.Cantidad});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridDetalleVenta, 4);
            this.dataGridDetalleVenta.Location = new System.Drawing.Point(3, 63);
            this.dataGridDetalleVenta.Name = "dataGridDetalleVenta";
            this.dataGridDetalleVenta.RowTemplate.Height = 25;
            this.dataGridDetalleVenta.Size = new System.Drawing.Size(588, 201);
            this.dataGridDetalleVenta.TabIndex = 8;
            // 
            // TipoProducto
            // 
            this.TipoProducto.HeaderText = "Tipo de producto";
            this.TipoProducto.Name = "TipoProducto";
            this.TipoProducto.ReadOnly = true;
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre del producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarAVenta, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dataGridDetalleVenta, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumericBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.combNombreProducto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.combProducto, 0, 1);
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 372);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 312);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // combCliente
            // 
            this.combCliente.FormattingEnabled = true;
            this.combCliente.Location = new System.Drawing.Point(3, 24);
            this.combCliente.Name = "combCliente";
            this.combCliente.Size = new System.Drawing.Size(141, 23);
            this.combCliente.TabIndex = 10;
            // 
            // combTipoComprobante
            // 
            this.combTipoComprobante.FormattingEnabled = true;
            this.combTipoComprobante.Location = new System.Drawing.Point(150, 24);
            this.combTipoComprobante.Name = "combTipoComprobante";
            this.combTipoComprobante.Size = new System.Drawing.Size(141, 23);
            this.combTipoComprobante.TabIndex = 11;
            // 
            // combFormaPago
            // 
            this.combFormaPago.FormattingEnabled = true;
            this.combFormaPago.Location = new System.Drawing.Point(297, 24);
            this.combFormaPago.Name = "combFormaPago";
            this.combFormaPago.Size = new System.Drawing.Size(111, 23);
            this.combFormaPago.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 15);
            this.label5.TabIndex = 13;
            this.label5.Text = "Cliente";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(150, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de comprobante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(297, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Forma de pago";
            // 
            // tableLayoutNuevaFactura
            // 
            this.tableLayoutNuevaFactura.ColumnCount = 3;
            this.tableLayoutNuevaFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutNuevaFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutNuevaFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutNuevaFactura.Controls.Add(this.combCliente, 0, 1);
            this.tableLayoutNuevaFactura.Controls.Add(this.combTipoComprobante, 1, 1);
            this.tableLayoutNuevaFactura.Controls.Add(this.label6, 1, 0);
            this.tableLayoutNuevaFactura.Controls.Add(this.combFormaPago, 2, 1);
            this.tableLayoutNuevaFactura.Controls.Add(this.label5, 0, 0);
            this.tableLayoutNuevaFactura.Controls.Add(this.label7, 2, 0);
            this.tableLayoutNuevaFactura.Enabled = false;
            this.tableLayoutNuevaFactura.Location = new System.Drawing.Point(28, 93);
            this.tableLayoutNuevaFactura.Name = "tableLayoutNuevaFactura";
            this.tableLayoutNuevaFactura.RowCount = 2;
            this.tableLayoutNuevaFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.59649F));
            this.tableLayoutNuevaFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.40351F));
            this.tableLayoutNuevaFactura.Size = new System.Drawing.Size(411, 57);
            this.tableLayoutNuevaFactura.TabIndex = 16;
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(28, 45);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(136, 29);
            this.btnNuevaVenta.TabIndex = 17;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Location = new System.Drawing.Point(449, 45);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(136, 29);
            this.btnCancelarVenta.TabIndex = 18;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.btnCancelarVenta);
            this.Controls.Add(this.btnNuevaVenta);
            this.Controls.Add(this.tableLayoutNuevaFactura);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDetalleVenta)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutNuevaFactura.ResumeLayout(false);
            this.tableLayoutNuevaFactura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private ComboBox combProducto;
        private Label label2;
        private ComboBox combNombreProducto;
        private Label label3;
        private NumericUpDown txtNumericBox;
        private Label label4;
        private Button btnAgregarAVenta;
        private DataGridView dataGridDetalleVenta;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn Cantidad;
        private TableLayoutPanel tableLayoutPanel1;
        private ComboBox combCliente;
        private ComboBox combTipoComprobante;
        private ComboBox combFormaPago;
        private Label label5;
        private Label label6;
        private Label label7;
        private TableLayoutPanel tableLayoutNuevaFactura;
        private Button btnNuevaVenta;
        private Button btnCancelarVenta;
    }
}