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
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "VENTAS";
            // 
            // combProducto
            // 
            this.combProducto.FormattingEnabled = true;
            this.combProducto.Location = new System.Drawing.Point(18, 71);
            this.combProducto.Name = "combProducto";
            this.combProducto.Size = new System.Drawing.Size(121, 23);
            this.combProducto.TabIndex = 1;
            this.combProducto.SelectionChangeCommitted += new System.EventHandler(this.combProducto_SelectionChangeCommitted);
            this.combProducto.SelectedValueChanged += new System.EventHandler(this.combProducto_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 53);
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
            this.combNombreProducto.Location = new System.Drawing.Point(158, 71);
            this.combNombreProducto.Name = "combNombreProducto";
            this.combNombreProducto.Size = new System.Drawing.Size(214, 23);
            this.combNombreProducto.TabIndex = 3;
            this.combNombreProducto.SelectionChangeCommitted += new System.EventHandler(this.combNombreProducto_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(158, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(122, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nombre del producto";
            // 
            // txtNumericBox
            // 
            this.txtNumericBox.Enabled = false;
            this.txtNumericBox.Location = new System.Drawing.Point(392, 71);
            this.txtNumericBox.Name = "txtNumericBox";
            this.txtNumericBox.Size = new System.Drawing.Size(55, 23);
            this.txtNumericBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(392, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cantidad";
            // 
            // btnAgregarAVenta
            // 
            this.btnAgregarAVenta.Location = new System.Drawing.Point(481, 71);
            this.btnAgregarAVenta.Name = "btnAgregarAVenta";
            this.btnAgregarAVenta.Size = new System.Drawing.Size(107, 23);
            this.btnAgregarAVenta.TabIndex = 7;
            this.btnAgregarAVenta.Text = "Agregar a pedido";
            this.btnAgregarAVenta.UseVisualStyleBackColor = true;
            // 
            // Ventas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 711);
            this.Controls.Add(this.btnAgregarAVenta);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNumericBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.combNombreProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.combProducto);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ventas";
            this.Text = "Ventas";
            this.Load += new System.EventHandler(this.Ventas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtNumericBox)).EndInit();
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
    }
}