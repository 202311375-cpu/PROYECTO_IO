namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmCostoEnvio
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
            lblCiudadCostoEnvio = new Label();
            lblTipoProducto = new Label();
            lblTipoNombre = new Label();
            txtCostoEnvio = new TextBox();
            btnEliminarCostoEnvio = new Button();
            gtvCostoEnvio = new DataGridView();
            btnActualizarCostoEnvio = new Button();
            btnInsertarCostoEnvio = new Button();
            cboEmpresas = new ComboBox();
            cboCiudades = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gtvCostoEnvio).BeginInit();
            SuspendLayout();
            // 
            // lblCiudadCostoEnvio
            // 
            lblCiudadCostoEnvio.AutoSize = true;
            lblCiudadCostoEnvio.BackColor = Color.Transparent;
            lblCiudadCostoEnvio.FlatStyle = FlatStyle.System;
            lblCiudadCostoEnvio.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblCiudadCostoEnvio.ForeColor = Color.FromArgb(0, 0, 64);
            lblCiudadCostoEnvio.Location = new Point(45, 87);
            lblCiudadCostoEnvio.Name = "lblCiudadCostoEnvio";
            lblCiudadCostoEnvio.Size = new Size(119, 32);
            lblCiudadCostoEnvio.TabIndex = 20;
            lblCiudadCostoEnvio.Text = "Empresa :";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.BackColor = Color.Transparent;
            lblTipoProducto.FlatStyle = FlatStyle.System;
            lblTipoProducto.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoProducto.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoProducto.Location = new Point(423, 17);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(110, 32);
            lblTipoProducto.TabIndex = 19;
            lblTipoProducto.Text = " Ciudad :";
            // 
            // lblTipoNombre
            // 
            lblTipoNombre.AutoSize = true;
            lblTipoNombre.BackColor = Color.Transparent;
            lblTipoNombre.FlatStyle = FlatStyle.System;
            lblTipoNombre.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoNombre.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoNombre.Location = new Point(45, 19);
            lblTipoNombre.Name = "lblTipoNombre";
            lblTipoNombre.Size = new Size(155, 32);
            lblTipoNombre.TabIndex = 18;
            lblTipoNombre.Text = "Costo envio :";
            // 
            // txtCostoEnvio
            // 
            txtCostoEnvio.BackColor = SystemColors.Control;
            txtCostoEnvio.BorderStyle = BorderStyle.None;
            txtCostoEnvio.Location = new Point(238, 33);
            txtCostoEnvio.Name = "txtCostoEnvio";
            txtCostoEnvio.Size = new Size(129, 16);
            txtCostoEnvio.TabIndex = 15;
            // 
            // btnEliminarCostoEnvio
            // 
            btnEliminarCostoEnvio.BackColor = Color.Orange;
            btnEliminarCostoEnvio.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarCostoEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarCostoEnvio.Location = new Point(671, 351);
            btnEliminarCostoEnvio.Name = "btnEliminarCostoEnvio";
            btnEliminarCostoEnvio.Size = new Size(87, 68);
            btnEliminarCostoEnvio.TabIndex = 14;
            btnEliminarCostoEnvio.UseVisualStyleBackColor = false;
            btnEliminarCostoEnvio.Click += btnEliminarCostoEnvio_Click;
            // 
            // gtvCostoEnvio
            // 
            gtvCostoEnvio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvCostoEnvio.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvCostoEnvio.BorderStyle = BorderStyle.None;
            gtvCostoEnvio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvCostoEnvio.Location = new Point(42, 158);
            gtvCostoEnvio.Name = "gtvCostoEnvio";
            gtvCostoEnvio.ReadOnly = true;
            gtvCostoEnvio.RowHeadersVisible = false;
            gtvCostoEnvio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvCostoEnvio.Size = new Size(590, 273);
            gtvCostoEnvio.TabIndex = 13;
            gtvCostoEnvio.CellClick += gtvCostoEnvio_CellClick;
            // 
            // btnActualizarCostoEnvio
            // 
            btnActualizarCostoEnvio.BackColor = Color.Orange;
            btnActualizarCostoEnvio.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarCostoEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarCostoEnvio.Location = new Point(671, 257);
            btnActualizarCostoEnvio.Name = "btnActualizarCostoEnvio";
            btnActualizarCostoEnvio.Size = new Size(87, 68);
            btnActualizarCostoEnvio.TabIndex = 12;
            btnActualizarCostoEnvio.UseVisualStyleBackColor = false;
            btnActualizarCostoEnvio.Click += btnActualizarCostoEnvio_Click;
            // 
            // btnInsertarCostoEnvio
            // 
            btnInsertarCostoEnvio.BackColor = Color.Orange;
            btnInsertarCostoEnvio.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarCostoEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarCostoEnvio.Location = new Point(671, 168);
            btnInsertarCostoEnvio.Name = "btnInsertarCostoEnvio";
            btnInsertarCostoEnvio.Size = new Size(87, 68);
            btnInsertarCostoEnvio.TabIndex = 11;
            btnInsertarCostoEnvio.UseVisualStyleBackColor = false;
            btnInsertarCostoEnvio.Click += btnInsertarCostoEnvio_Click;
            // 
            // cboEmpresas
            // 
            cboEmpresas.FormattingEnabled = true;
            cboEmpresas.Location = new Point(238, 96);
            cboEmpresas.Name = "cboEmpresas";
            cboEmpresas.Size = new Size(129, 23);
            cboEmpresas.TabIndex = 22;
            // 
            // cboCiudades
            // 
            cboCiudades.FormattingEnabled = true;
            cboCiudades.Location = new Point(562, 26);
            cboCiudades.Name = "cboCiudades";
            cboCiudades.Size = new Size(171, 23);
            cboCiudades.TabIndex = 23;
            // 
            // frmCostoEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(cboCiudades);
            Controls.Add(cboEmpresas);
            Controls.Add(lblCiudadCostoEnvio);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblTipoNombre);
            Controls.Add(txtCostoEnvio);
            Controls.Add(btnEliminarCostoEnvio);
            Controls.Add(gtvCostoEnvio);
            Controls.Add(btnActualizarCostoEnvio);
            Controls.Add(btnInsertarCostoEnvio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCostoEnvio";
            Text = "frmCostoEnvio";
            Load += frmCostoEnvio_Load;
            ((System.ComponentModel.ISupportInitialize)gtvCostoEnvio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCiudadCostoEnvio;
        private Label lblTipoProducto;
        private Label lblTipoNombre;
        private TextBox txtCostoEnvio;
        private Button btnEliminarCostoEnvio;
        private DataGridView gtvCostoEnvio;
        private Button btnActualizarCostoEnvio;
        private Button btnInsertarCostoEnvio;
        private ComboBox cboEmpresas;
        private ComboBox cboCiudades;
    }
}