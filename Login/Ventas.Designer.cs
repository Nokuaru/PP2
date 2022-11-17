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
            this.idProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtPrecioUnitario = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSubtotalLinea = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.combCliente = new System.Windows.Forms.ComboBox();
            this.combTipoComprobante = new System.Windows.Forms.ComboBox();
            this.combFormaPago = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableLayoutNuevaFactura = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNumeroComprobante = new System.Windows.Forms.TextBox();
            this.btnNuevaVenta = new System.Windows.Forms.Button();
            this.btnCancelarVenta = new System.Windows.Forms.Button();
            this.btnFinalizarVenta = new System.Windows.Forms.Button();
            this.txtTotalFactura = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblIngresarNumeros = new System.Windows.Forms.Label();
            this.chkEliminarDetalleSubfactura = new System.Windows.Forms.CheckBox();
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
            this.combProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combProducto.FormattingEnabled = true;
            this.combProducto.Location = new System.Drawing.Point(3, 23);
            this.combProducto.Name = "combProducto";
            this.combProducto.Size = new System.Drawing.Size(101, 23);
            this.combProducto.TabIndex = 1;
            this.combProducto.SelectionChangeCommitted += new System.EventHandler(this.combProducto_SelectionChangeCommitted);
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
            this.combNombreProducto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combNombreProducto.Enabled = false;
            this.combNombreProducto.FormattingEnabled = true;
            this.combNombreProducto.Location = new System.Drawing.Point(110, 23);
            this.combNombreProducto.Name = "combNombreProducto";
            this.combNombreProducto.Size = new System.Drawing.Size(128, 23);
            this.combNombreProducto.TabIndex = 3;
            this.combNombreProducto.SelectionChangeCommitted += new System.EventHandler(this.combNombreProducto_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(110, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del producto";
            // 
            // txtNumericBox
            // 
            this.txtNumericBox.Enabled = false;
            this.txtNumericBox.Location = new System.Drawing.Point(244, 23);
            this.txtNumericBox.Name = "txtNumericBox";
            this.txtNumericBox.Size = new System.Drawing.Size(55, 23);
            this.txtNumericBox.TabIndex = 5;
            this.txtNumericBox.ValueChanged += new System.EventHandler(this.txtNumericBox_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(244, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // btnAgregarAVenta
            // 
            this.btnAgregarAVenta.Enabled = false;
            this.btnAgregarAVenta.Location = new System.Drawing.Point(777, 236);
            this.btnAgregarAVenta.Name = "btnAgregarAVenta";
            this.btnAgregarAVenta.Size = new System.Drawing.Size(136, 27);
            this.btnAgregarAVenta.TabIndex = 7;
            this.btnAgregarAVenta.Text = "Agregar a pedido";
            this.btnAgregarAVenta.UseVisualStyleBackColor = true;
            this.btnAgregarAVenta.Click += new System.EventHandler(this.btnAgregarAVenta_Click);
            // 
            // dataGridDetalleVenta
            // 
            this.dataGridDetalleVenta.AllowUserToAddRows = false;
            this.dataGridDetalleVenta.AllowUserToDeleteRows = false;
            this.dataGridDetalleVenta.AllowUserToOrderColumns = true;
            this.dataGridDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TipoProducto,
            this.NombreProducto,
            this.idProducto,
            this.Cantidad,
            this.Subtotal});
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridDetalleVenta, 5);
            this.dataGridDetalleVenta.Location = new System.Drawing.Point(3, 63);
            this.dataGridDetalleVenta.Name = "dataGridDetalleVenta";
            this.dataGridDetalleVenta.ReadOnly = true;
            this.dataGridDetalleVenta.RowTemplate.Height = 25;
            this.dataGridDetalleVenta.Size = new System.Drawing.Size(550, 237);
            this.dataGridDetalleVenta.TabIndex = 8;
            this.dataGridDetalleVenta.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.dataGridDetalleVenta_RowsRemoved);
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
            // idProducto
            // 
            this.idProducto.HeaderText = "idProducto";
            this.idProducto.Name = "idProducto";
            this.idProducto.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Subtotal
            // 
            this.Subtotal.HeaderText = "Subtotal";
            this.Subtotal.Name = "Subtotal";
            this.Subtotal.ReadOnly = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoScroll = true;
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.80952F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 19.04762F));
            this.tableLayoutPanel1.Controls.Add(this.txtPrecioUnitario, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label13, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtNumericBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.combNombreProducto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.combProducto, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dataGridDetalleVenta, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtSubtotalLinea, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.label9, 4, 0);
            this.tableLayoutPanel1.Enabled = false;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(25, 213);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(564, 312);
            this.tableLayoutPanel1.TabIndex = 9;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // txtPrecioUnitario
            // 
            this.txtPrecioUnitario.Enabled = false;
            this.txtPrecioUnitario.Location = new System.Drawing.Point(351, 23);
            this.txtPrecioUnitario.Name = "txtPrecioUnitario";
            this.txtPrecioUnitario.Size = new System.Drawing.Size(100, 23);
            this.txtPrecioUnitario.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(351, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 15);
            this.label13.TabIndex = 25;
            this.label13.Text = "Precio Unitario";
            // 
            // txtSubtotalLinea
            // 
            this.txtSubtotalLinea.Enabled = false;
            this.txtSubtotalLinea.Location = new System.Drawing.Point(458, 23);
            this.txtSubtotalLinea.Name = "txtSubtotalLinea";
            this.txtSubtotalLinea.Size = new System.Drawing.Size(100, 23);
            this.txtSubtotalLinea.TabIndex = 20;
            this.txtSubtotalLinea.Text = "Subtotal";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(458, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 20;
            this.label9.Text = "Subtotal";
            // 
            // combCliente
            // 
            this.combCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combCliente.FormattingEnabled = true;
            this.combCliente.Location = new System.Drawing.Point(3, 24);
            this.combCliente.Name = "combCliente";
            this.combCliente.Size = new System.Drawing.Size(126, 23);
            this.combCliente.TabIndex = 10;
            // 
            // combTipoComprobante
            // 
            this.combTipoComprobante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combTipoComprobante.FormattingEnabled = true;
            this.combTipoComprobante.Location = new System.Drawing.Point(166, 24);
            this.combTipoComprobante.Name = "combTipoComprobante";
            this.combTipoComprobante.Size = new System.Drawing.Size(126, 23);
            this.combTipoComprobante.TabIndex = 11;
            // 
            // combFormaPago
            // 
            this.combFormaPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.combFormaPago.FormattingEnabled = true;
            this.combFormaPago.Location = new System.Drawing.Point(329, 24);
            this.combFormaPago.Name = "combFormaPago";
            this.combFormaPago.Size = new System.Drawing.Size(110, 23);
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
            this.label6.Location = new System.Drawing.Point(166, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 15);
            this.label6.TabIndex = 14;
            this.label6.Text = "Tipo de comprobante";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(329, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(87, 15);
            this.label7.TabIndex = 15;
            this.label7.Text = "Forma de pago";
            // 
            // tableLayoutNuevaFactura
            // 
            this.tableLayoutNuevaFactura.ColumnCount = 4;
            this.tableLayoutNuevaFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNuevaFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNuevaFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNuevaFactura.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutNuevaFactura.Controls.Add(this.label8, 3, 0);
            this.tableLayoutNuevaFactura.Controls.Add(this.txtNumeroComprobante, 3, 1);
            this.tableLayoutNuevaFactura.Controls.Add(this.combCliente, 0, 1);
            this.tableLayoutNuevaFactura.Controls.Add(this.combTipoComprobante, 1, 1);
            this.tableLayoutNuevaFactura.Controls.Add(this.label6, 1, 0);
            this.tableLayoutNuevaFactura.Controls.Add(this.combFormaPago, 2, 1);
            this.tableLayoutNuevaFactura.Controls.Add(this.label5, 0, 0);
            this.tableLayoutNuevaFactura.Controls.Add(this.label7, 2, 0);
            this.tableLayoutNuevaFactura.Location = new System.Drawing.Point(28, 93);
            this.tableLayoutNuevaFactura.Name = "tableLayoutNuevaFactura";
            this.tableLayoutNuevaFactura.RowCount = 2;
            this.tableLayoutNuevaFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 38.59649F));
            this.tableLayoutNuevaFactura.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 61.40351F));
            this.tableLayoutNuevaFactura.Size = new System.Drawing.Size(655, 57);
            this.tableLayoutNuevaFactura.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(492, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 15);
            this.label8.TabIndex = 19;
            this.label8.Text = "Numero comprobante";
            // 
            // txtNumeroComprobante
            // 
            this.txtNumeroComprobante.Location = new System.Drawing.Point(492, 24);
            this.txtNumeroComprobante.Name = "txtNumeroComprobante";
            this.txtNumeroComprobante.Size = new System.Drawing.Size(106, 23);
            this.txtNumeroComprobante.TabIndex = 19;
            this.txtNumeroComprobante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroComprobante_KeyPress);
            // 
            // btnNuevaVenta
            // 
            this.btnNuevaVenta.Location = new System.Drawing.Point(777, 113);
            this.btnNuevaVenta.Name = "btnNuevaVenta";
            this.btnNuevaVenta.Size = new System.Drawing.Size(136, 29);
            this.btnNuevaVenta.TabIndex = 17;
            this.btnNuevaVenta.Text = "Nueva Venta";
            this.btnNuevaVenta.UseVisualStyleBackColor = true;
            this.btnNuevaVenta.Click += new System.EventHandler(this.btnNuevaVenta_Click);
            // 
            // btnCancelarVenta
            // 
            this.btnCancelarVenta.Enabled = false;
            this.btnCancelarVenta.Location = new System.Drawing.Point(938, 113);
            this.btnCancelarVenta.Name = "btnCancelarVenta";
            this.btnCancelarVenta.Size = new System.Drawing.Size(136, 29);
            this.btnCancelarVenta.TabIndex = 18;
            this.btnCancelarVenta.Text = "Cancelar Venta";
            this.btnCancelarVenta.UseVisualStyleBackColor = true;
            this.btnCancelarVenta.Click += new System.EventHandler(this.btnCancelarVenta_Click);
            // 
            // btnFinalizarVenta
            // 
            this.btnFinalizarVenta.Enabled = false;
            this.btnFinalizarVenta.Location = new System.Drawing.Point(938, 236);
            this.btnFinalizarVenta.Name = "btnFinalizarVenta";
            this.btnFinalizarVenta.Size = new System.Drawing.Size(136, 27);
            this.btnFinalizarVenta.TabIndex = 19;
            this.btnFinalizarVenta.Text = "Finalizar Venta";
            this.btnFinalizarVenta.UseVisualStyleBackColor = true;
            this.btnFinalizarVenta.Click += new System.EventHandler(this.btnFinalizarVenta_Click);
            // 
            // txtTotalFactura
            // 
            this.txtTotalFactura.Enabled = false;
            this.txtTotalFactura.Location = new System.Drawing.Point(605, 236);
            this.txtTotalFactura.Name = "txtTotalFactura";
            this.txtTotalFactura.Size = new System.Drawing.Size(89, 23);
            this.txtTotalFactura.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(604, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 15);
            this.label10.TabIndex = 21;
            this.label10.Text = "Total de factura";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(25, 60);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(144, 20);
            this.label11.TabIndex = 22;
            this.label11.Text = "Datos de la factura";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(25, 190);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(151, 20);
            this.label12.TabIndex = 23;
            this.label12.Text = "Detalle de la factura";
            // 
            // lblIngresarNumeros
            // 
            this.lblIngresarNumeros.AutoSize = true;
            this.lblIngresarNumeros.BackColor = System.Drawing.Color.Transparent;
            this.lblIngresarNumeros.ForeColor = System.Drawing.Color.Crimson;
            this.lblIngresarNumeros.Location = new System.Drawing.Point(518, 139);
            this.lblIngresarNumeros.Name = "lblIngresarNumeros";
            this.lblIngresarNumeros.Size = new System.Drawing.Size(154, 15);
            this.lblIngresarNumeros.TabIndex = 24;
            this.lblIngresarNumeros.Text = "Debe ingresar solo números";
            this.lblIngresarNumeros.Visible = false;
            // 
            // chkEliminarDetalleSubfactura
            // 
            this.chkEliminarDetalleSubfactura.AutoSize = true;
            this.chkEliminarDetalleSubfactura.Location = new System.Drawing.Point(605, 276);
            this.chkEliminarDetalleSubfactura.Name = "chkEliminarDetalleSubfactura";
            this.chkEliminarDetalleSubfactura.Size = new System.Drawing.Size(147, 19);
            this.chkEliminarDetalleSubfactura.TabIndex = 25;
            this.chkEliminarDetalleSubfactura.Text = "Eliminar detalle factura";
            this.chkEliminarDetalleSubfactura.UseVisualStyleBackColor = true;
            this.chkEliminarDetalleSubfactura.CheckedChanged += new System.EventHandler(this.chkEliminarDetalleSubfactura_CheckedChanged);
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.chkEliminarDetalleSubfactura);
            this.Controls.Add(this.lblIngresarNumeros);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtTotalFactura);
            this.Controls.Add(this.btnAgregarAVenta);
            this.Controls.Add(this.btnFinalizarVenta);
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
        private TextBox txtNumeroComprobante;
        private Label label8;
        private Button btnFinalizarVenta;
        private TextBox txtSubtotalLinea;
        private DataGridViewTextBoxColumn TipoProducto;
        private DataGridViewTextBoxColumn NombreProducto;
        private DataGridViewTextBoxColumn idProducto;
        private DataGridViewTextBoxColumn Cantidad;
        private DataGridViewTextBoxColumn Subtotal;
        private Label label9;
        private TextBox txtTotalFactura;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label lblIngresarNumeros;
        private TextBox txtPrecioUnitario;
        private Label label13;
        private CheckBox chkEliminarDetalleSubfactura;
    }
}