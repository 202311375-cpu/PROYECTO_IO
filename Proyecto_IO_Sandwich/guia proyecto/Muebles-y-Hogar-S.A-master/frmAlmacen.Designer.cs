namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmAlmacen
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
            txtNombreAlmacen = new TextBox();
            btnEliminarAlmacen = new Button();
            gtvAlmacen = new DataGridView();
            btnActualizarAlmacen = new Button();
            btnInsertarAlmacen = new Button();
            txtCapacidad = new TextBox();
            txtCostoAlquiler = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gtvAlmacen).BeginInit();
            SuspendLayout();
            // 
            // lblcboEmpresas
            // 
            lblcboEmpresas.AutoSize = true;
            lblcboEmpresas.BackColor = Color.Transparent;
            lblcboEmpresas.FlatStyle = FlatStyle.System;
            lblcboEmpresas.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblcboEmpresas.ForeColor = Color.FromArgb(0, 0, 64);
            lblcboEmpresas.Location = new Point(12, 83);
            lblcboEmpresas.Name = "lblcboEmpresas";
            lblcboEmpresas.Size = new Size(140, 32);
            lblcboEmpresas.TabIndex = 30;
            lblcboEmpresas.Text = "Capacidad :";
            // 
            // lblcboProductos
            // 
            lblcboProductos.AutoSize = true;
            lblcboProductos.BackColor = Color.Transparent;
            lblcboProductos.FlatStyle = FlatStyle.System;
            lblcboProductos.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblcboProductos.ForeColor = Color.FromArgb(0, 0, 64);
            lblcboProductos.Location = new Point(12, 17);
            lblcboProductos.Name = "lblcboProductos";
            lblcboProductos.Size = new Size(214, 32);
            lblcboProductos.TabIndex = 29;
            lblcboProductos.Text = "Costo de Alquiler :";
            // 
            // lblTipoNombre
            // 
            lblTipoNombre.AutoSize = true;
            lblTipoNombre.BackColor = Color.Transparent;
            lblTipoNombre.FlatStyle = FlatStyle.System;
            lblTipoNombre.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoNombre.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoNombre.Location = new Point(351, 21);
            lblTipoNombre.Name = "lblTipoNombre";
            lblTipoNombre.Size = new Size(116, 32);
            lblTipoNombre.TabIndex = 28;
            lblTipoNombre.Text = "Nombre :";
            // 
            // txtNombreAlmacen
            // 
            txtNombreAlmacen.BackColor = Color.WhiteSmoke;
            txtNombreAlmacen.BorderStyle = BorderStyle.None;
            txtNombreAlmacen.Location = new Point(488, 35);
            txtNombreAlmacen.Name = "txtNombreAlmacen";
            txtNombreAlmacen.Size = new Size(133, 16);
            txtNombreAlmacen.TabIndex = 27;
            // 
            // btnEliminarAlmacen
            // 
            btnEliminarAlmacen.BackColor = Color.Orange;
            btnEliminarAlmacen.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarAlmacen.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarAlmacen.Location = new Point(664, 319);
            btnEliminarAlmacen.Name = "btnEliminarAlmacen";
            btnEliminarAlmacen.Size = new Size(87, 68);
            btnEliminarAlmacen.TabIndex = 26;
            btnEliminarAlmacen.UseVisualStyleBackColor = false;
            btnEliminarAlmacen.Click += btnEliminarAlmacen_Click;
            // 
            // gtvAlmacen
            // 
            gtvAlmacen.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvAlmacen.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvAlmacen.BorderStyle = BorderStyle.None;
            gtvAlmacen.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvAlmacen.Location = new Point(12, 136);
            gtvAlmacen.Name = "gtvAlmacen";
            gtvAlmacen.ReadOnly = true;
            gtvAlmacen.RowHeadersVisible = false;
            gtvAlmacen.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvAlmacen.Size = new Size(609, 273);
            gtvAlmacen.TabIndex = 25;
            gtvAlmacen.CellClick += gtvAlmacen_CellClick;
            // 
            // btnActualizarAlmacen
            // 
            btnActualizarAlmacen.BackColor = Color.Orange;
            btnActualizarAlmacen.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarAlmacen.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarAlmacen.Location = new Point(664, 225);
            btnActualizarAlmacen.Name = "btnActualizarAlmacen";
            btnActualizarAlmacen.Size = new Size(87, 68);
            btnActualizarAlmacen.TabIndex = 24;
            btnActualizarAlmacen.UseVisualStyleBackColor = false;
            btnActualizarAlmacen.Click += btnActualizarAlmacen_Click;
            // 
            // btnInsertarAlmacen
            // 
            btnInsertarAlmacen.BackColor = Color.Orange;
            btnInsertarAlmacen.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarAlmacen.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarAlmacen.Location = new Point(664, 136);
            btnInsertarAlmacen.Name = "btnInsertarAlmacen";
            btnInsertarAlmacen.Size = new Size(87, 68);
            btnInsertarAlmacen.TabIndex = 23;
            btnInsertarAlmacen.UseVisualStyleBackColor = false;
            btnInsertarAlmacen.Click += btnInsertarAlmacen_Click;
            // 
            // txtCapacidad
            // 
            txtCapacidad.BackColor = Color.WhiteSmoke;
            txtCapacidad.BorderStyle = BorderStyle.None;
            txtCapacidad.Location = new Point(232, 97);
            txtCapacidad.Name = "txtCapacidad";
            txtCapacidad.Size = new Size(89, 16);
            txtCapacidad.TabIndex = 31;
            // 
            // txtCostoAlquiler
            // 
            txtCostoAlquiler.BackColor = Color.WhiteSmoke;
            txtCostoAlquiler.BorderStyle = BorderStyle.None;
            txtCostoAlquiler.Location = new Point(232, 31);
            txtCostoAlquiler.Name = "txtCostoAlquiler";
            txtCostoAlquiler.Size = new Size(89, 16);
            txtCostoAlquiler.TabIndex = 32;
            // 
            // frmAlmacen
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCostoAlquiler);
            Controls.Add(txtCapacidad);
            Controls.Add(lblcboEmpresas);
            Controls.Add(lblcboProductos);
            Controls.Add(lblTipoNombre);
            Controls.Add(txtNombreAlmacen);
            Controls.Add(btnEliminarAlmacen);
            Controls.Add(gtvAlmacen);
            Controls.Add(btnActualizarAlmacen);
            Controls.Add(btnInsertarAlmacen);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmAlmacen";
            Text = "frmAlmacen";
            Load += frmAlmacen_Load;
            ((System.ComponentModel.ISupportInitialize)gtvAlmacen).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblcboEmpresas;
        private Label lblcboProductos;
        private Label lblTipoNombre;
        private TextBox txtNombreAlmacen;
        private Button btnEliminarAlmacen;
        private DataGridView gtvAlmacen;
        private Button btnActualizarAlmacen;
        private Button btnInsertarAlmacen;
        private TextBox txtCapacidad;
        private TextBox txtCostoAlquiler;
    }
}