namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmEnvio
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
            lblcostoEnviar = new Label();
            txtCantidadEnviar = new TextBox();
            btnEliminarEnvio = new Button();
            gtvEnvio = new DataGridView();
            btnActualizarEnvio = new Button();
            btnInsertarEnvio = new Button();
            cboCiudades = new ComboBox();
            cboProductos = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)gtvEnvio).BeginInit();
            SuspendLayout();
            // 
            // lblcostoEnviar
            // 
            lblcostoEnviar.AutoSize = true;
            lblcostoEnviar.BackColor = Color.Transparent;
            lblcostoEnviar.FlatStyle = FlatStyle.System;
            lblcostoEnviar.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblcostoEnviar.ForeColor = Color.FromArgb(0, 0, 64);
            lblcostoEnviar.Location = new Point(32, 19);
            lblcostoEnviar.Name = "lblcostoEnviar";
            lblcostoEnviar.Size = new Size(219, 32);
            lblcostoEnviar.TabIndex = 18;
            lblcostoEnviar.Text = "Cantidad a enviar :";
            // 
            // txtCantidadEnviar
            // 
            txtCantidadEnviar.BackColor = SystemColors.MenuBar;
            txtCantidadEnviar.BorderStyle = BorderStyle.None;
            txtCantidadEnviar.Location = new Point(270, 33);
            txtCantidadEnviar.Name = "txtCantidadEnviar";
            txtCantidadEnviar.Size = new Size(138, 16);
            txtCantidadEnviar.TabIndex = 15;
            // 
            // btnEliminarEnvio
            // 
            btnEliminarEnvio.BackColor = Color.Orange;
            btnEliminarEnvio.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarEnvio.Location = new Point(671, 351);
            btnEliminarEnvio.Name = "btnEliminarEnvio";
            btnEliminarEnvio.Size = new Size(87, 68);
            btnEliminarEnvio.TabIndex = 14;
            btnEliminarEnvio.UseVisualStyleBackColor = false;
            btnEliminarEnvio.Click += btnEliminarEnvio_Click;
            // 
            // gtvEnvio
            // 
            gtvEnvio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvEnvio.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvEnvio.BorderStyle = BorderStyle.None;
            gtvEnvio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvEnvio.Location = new Point(32, 146);
            gtvEnvio.Name = "gtvEnvio";
            gtvEnvio.ReadOnly = true;
            gtvEnvio.RowHeadersVisible = false;
            gtvEnvio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvEnvio.Size = new Size(590, 273);
            gtvEnvio.TabIndex = 13;
            gtvEnvio.CellClick += gtvEnvio_CellClick;
            // 
            // btnActualizarEnvio
            // 
            btnActualizarEnvio.BackColor = Color.Orange;
            btnActualizarEnvio.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarEnvio.Location = new Point(671, 257);
            btnActualizarEnvio.Name = "btnActualizarEnvio";
            btnActualizarEnvio.Size = new Size(87, 68);
            btnActualizarEnvio.TabIndex = 12;
            btnActualizarEnvio.UseVisualStyleBackColor = false;
            btnActualizarEnvio.Click += btnActualizarEnvio_Click;
            // 
            // btnInsertarEnvio
            // 
            btnInsertarEnvio.BackColor = Color.Orange;
            btnInsertarEnvio.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarEnvio.Location = new Point(671, 168);
            btnInsertarEnvio.Name = "btnInsertarEnvio";
            btnInsertarEnvio.Size = new Size(87, 68);
            btnInsertarEnvio.TabIndex = 11;
            btnInsertarEnvio.UseVisualStyleBackColor = false;
            btnInsertarEnvio.Click += btnInsertarEnvio_Click;
            // 
            // cboCiudades
            // 
            cboCiudades.FormattingEnabled = true;
            cboCiudades.Location = new Point(573, 26);
            cboCiudades.Name = "cboCiudades";
            cboCiudades.Size = new Size(145, 23);
            cboCiudades.TabIndex = 19;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(270, 99);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(133, 23);
            cboProductos.TabIndex = 20;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(32, 90);
            label1.Name = "label1";
            label1.Size = new Size(113, 32);
            label1.TabIndex = 21;
            label1.Text = "Producto";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(450, 17);
            label2.Name = "label2";
            label2.Size = new Size(103, 32);
            label2.TabIndex = 22;
            label2.Text = "Ciudad :";
            // 
            // frmEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboProductos);
            Controls.Add(cboCiudades);
            Controls.Add(lblcostoEnviar);
            Controls.Add(txtCantidadEnviar);
            Controls.Add(btnEliminarEnvio);
            Controls.Add(gtvEnvio);
            Controls.Add(btnActualizarEnvio);
            Controls.Add(btnInsertarEnvio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEnvio";
            Text = "frmEnvio";
            Load += frmEnvio_Load;
            ((System.ComponentModel.ISupportInitialize)gtvEnvio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblcostoEnviar;
        private TextBox txtCantidadEnviar;
        private Button btnEliminarEnvio;
        private DataGridView gtvEnvio;
        private Button btnActualizarEnvio;
        private Button btnInsertarEnvio;
        private ComboBox cboCiudades;
        private ComboBox cboProductos;
        private Label label1;
        private Label label2;
    }
}