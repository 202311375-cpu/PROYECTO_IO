namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmCapacidadEnvio
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
            lblcboEmpresas = new Label();
            lblcboProductos = new Label();
            lblTipoNombre = new Label();
            txtCapacidadEnvio = new TextBox();
            btnEliminarCapacidadEnvio = new Button();
            gtvCapacidadEnvio = new DataGridView();
            btnActualizarCapacidadEnvio = new Button();
            btnInsertarCapacidadEnvio = new Button();
            cboProductos = new ComboBox();
            cboEmpresas = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gtvCapacidadEnvio).BeginInit();
            SuspendLayout();
            // 
            // lblcboEmpresas
            // 
            lblcboEmpresas.AutoSize = true;
            lblcboEmpresas.BackColor = Color.Transparent;
            lblcboEmpresas.FlatStyle = FlatStyle.System;
            lblcboEmpresas.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblcboEmpresas.ForeColor = Color.FromArgb(0, 0, 64);
            lblcboEmpresas.Location = new Point(24, 87);
            lblcboEmpresas.Name = "lblcboEmpresas";
            lblcboEmpresas.Size = new Size(119, 32);
            lblcboEmpresas.TabIndex = 20;
            lblcboEmpresas.Text = "Empresa :";
            // 
            // lblcboProductos
            // 
            lblcboProductos.AutoSize = true;
            lblcboProductos.BackColor = Color.Transparent;
            lblcboProductos.FlatStyle = FlatStyle.System;
            lblcboProductos.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblcboProductos.ForeColor = Color.FromArgb(0, 0, 64);
            lblcboProductos.Location = new Point(462, 19);
            lblcboProductos.Name = "lblcboProductos";
            lblcboProductos.Size = new Size(126, 32);
            lblcboProductos.TabIndex = 19;
            lblcboProductos.Text = "Producto :";
            // 
            // lblTipoNombre
            // 
            lblTipoNombre.AutoSize = true;
            lblTipoNombre.BackColor = Color.Transparent;
            lblTipoNombre.FlatStyle = FlatStyle.System;
            lblTipoNombre.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoNombre.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoNombre.Location = new Point(24, 19);
            lblTipoNombre.Name = "lblTipoNombre";
            lblTipoNombre.Size = new Size(240, 32);
            lblTipoNombre.TabIndex = 18;
            lblTipoNombre.Text = "Capacidad de envio :";
            // 
            // txtCapacidadEnvio
            // 
            txtCapacidadEnvio.BackColor = Color.WhiteSmoke;
            txtCapacidadEnvio.BorderStyle = BorderStyle.None;
            txtCapacidadEnvio.Location = new Point(291, 33);
            txtCapacidadEnvio.Name = "txtCapacidadEnvio";
            txtCapacidadEnvio.Size = new Size(133, 16);
            txtCapacidadEnvio.TabIndex = 15;
            // 
            // btnEliminarCapacidadEnvio
            // 
            btnEliminarCapacidadEnvio.BackColor = Color.Orange;
            btnEliminarCapacidadEnvio.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarCapacidadEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarCapacidadEnvio.Location = new Point(671, 351);
            btnEliminarCapacidadEnvio.Name = "btnEliminarCapacidadEnvio";
            btnEliminarCapacidadEnvio.Size = new Size(87, 68);
            btnEliminarCapacidadEnvio.TabIndex = 14;
            btnEliminarCapacidadEnvio.UseVisualStyleBackColor = false;
            btnEliminarCapacidadEnvio.Click += btnEliminarCapacidadEnvio_Click;
            // 
            // gtvCapacidadEnvio
            // 
            gtvCapacidadEnvio.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvCapacidadEnvio.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvCapacidadEnvio.BorderStyle = BorderStyle.None;
            gtvCapacidadEnvio.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvCapacidadEnvio.Location = new Point(24, 156);
            gtvCapacidadEnvio.Name = "gtvCapacidadEnvio";
            gtvCapacidadEnvio.ReadOnly = true;
            gtvCapacidadEnvio.RowHeadersVisible = false;
            gtvCapacidadEnvio.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvCapacidadEnvio.Size = new Size(590, 273);
            gtvCapacidadEnvio.TabIndex = 13;
            gtvCapacidadEnvio.CellClick += gtvCapacidadEnvio_CellClick;
            // 
            // btnActualizarCapacidadEnvio
            // 
            btnActualizarCapacidadEnvio.BackColor = Color.Orange;
            btnActualizarCapacidadEnvio.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarCapacidadEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarCapacidadEnvio.Location = new Point(671, 257);
            btnActualizarCapacidadEnvio.Name = "btnActualizarCapacidadEnvio";
            btnActualizarCapacidadEnvio.Size = new Size(87, 68);
            btnActualizarCapacidadEnvio.TabIndex = 12;
            btnActualizarCapacidadEnvio.UseVisualStyleBackColor = false;
            btnActualizarCapacidadEnvio.Click += btnActualizarCapacidadEnvio_Click;
            // 
            // btnInsertarCapacidadEnvio
            // 
            btnInsertarCapacidadEnvio.BackColor = Color.Orange;
            btnInsertarCapacidadEnvio.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarCapacidadEnvio.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarCapacidadEnvio.Location = new Point(671, 168);
            btnInsertarCapacidadEnvio.Name = "btnInsertarCapacidadEnvio";
            btnInsertarCapacidadEnvio.Size = new Size(87, 68);
            btnInsertarCapacidadEnvio.TabIndex = 11;
            btnInsertarCapacidadEnvio.UseVisualStyleBackColor = false;
            btnInsertarCapacidadEnvio.Click += btnInsertarCapacidadEnvio_Click;
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(609, 28);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(112, 23);
            cboProductos.TabIndex = 21;
            // 
            // cboEmpresas
            // 
            cboEmpresas.FormattingEnabled = true;
            cboEmpresas.Location = new Point(291, 98);
            cboEmpresas.Name = "cboEmpresas";
            cboEmpresas.Size = new Size(133, 23);
            cboEmpresas.TabIndex = 22;
            // 
            // frmCapacidadEnvio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(cboEmpresas);
            Controls.Add(cboProductos);
            Controls.Add(lblcboEmpresas);
            Controls.Add(lblcboProductos);
            Controls.Add(lblTipoNombre);
            Controls.Add(txtCapacidadEnvio);
            Controls.Add(btnEliminarCapacidadEnvio);
            Controls.Add(gtvCapacidadEnvio);
            Controls.Add(btnActualizarCapacidadEnvio);
            Controls.Add(btnInsertarCapacidadEnvio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCapacidadEnvio";
            Text = "frmCapacidadEnvio";
            Load += frmCapacidadEnvio_Load;
            ((System.ComponentModel.ISupportInitialize)gtvCapacidadEnvio).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcboEmpresas;
        private Label lblcboProductos;
        private Label lblTipoNombre;
        private TextBox txtCapacidadEnvio;
        private Button btnEliminarCapacidadEnvio;
        private DataGridView gtvCapacidadEnvio;
        private Button btnActualizarCapacidadEnvio;
        private Button btnInsertarCapacidadEnvio;
        private ComboBox cboProductos;
        private ComboBox cboEmpresas;
    }
}