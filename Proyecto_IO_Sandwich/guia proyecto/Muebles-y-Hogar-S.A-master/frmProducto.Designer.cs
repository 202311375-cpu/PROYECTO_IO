namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmProducto
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
            btnInsertar = new Button();
            btnActualizar = new Button();
            gtvProductos = new DataGridView();
            btnEliminar = new Button();
            txtNombreProducto = new TextBox();
            txtTipoProducto = new TextBox();
            txtPrecioProducto = new TextBox();
            lblTipoNombre = new Label();
            lblTipoProducto = new Label();
            lblPrecioProducto = new Label();
            ((System.ComponentModel.ISupportInitialize)gtvProductos).BeginInit();
            SuspendLayout();
            // 
            // btnInsertar
            // 
            btnInsertar.BackColor = Color.Orange;
            btnInsertar.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertar.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertar.Location = new Point(680, 174);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(87, 68);
            btnInsertar.TabIndex = 0;
            btnInsertar.UseVisualStyleBackColor = false;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.BackColor = Color.Orange;
            btnActualizar.BackgroundImage = Properties.Resources.actualizar;
            btnActualizar.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizar.Location = new Point(680, 263);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(87, 68);
            btnActualizar.TabIndex = 1;
            btnActualizar.UseVisualStyleBackColor = false;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // gtvProductos
            // 
            gtvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvProductos.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvProductos.BorderStyle = BorderStyle.None;
            gtvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvProductos.Location = new Point(30, 161);
            gtvProductos.Name = "gtvProductos";
            gtvProductos.ReadOnly = true;
            gtvProductos.RowHeadersVisible = false;
            gtvProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvProductos.Size = new Size(590, 273);
            gtvProductos.TabIndex = 3;
            gtvProductos.CellClick += gtvProductos_CellClick;
            gtvProductos.CellContentClick += gtvProductos_CellContentClick;
            // 
            // btnEliminar
            // 
            btnEliminar.BackColor = Color.Orange;
            btnEliminar.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminar.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminar.Location = new Point(680, 357);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(87, 68);
            btnEliminar.TabIndex = 4;
            btnEliminar.UseVisualStyleBackColor = false;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // txtNombreProducto
            // 
            txtNombreProducto.BackColor = Color.WhiteSmoke;
            txtNombreProducto.BorderStyle = BorderStyle.None;
            txtNombreProducto.Location = new Point(220, 38);
            txtNombreProducto.Name = "txtNombreProducto";
            txtNombreProducto.Size = new Size(138, 16);
            txtNombreProducto.TabIndex = 5;
            // 
            // txtTipoProducto
            // 
            txtTipoProducto.BackColor = Color.WhiteSmoke;
            txtTipoProducto.BorderStyle = BorderStyle.None;
            txtTipoProducto.Location = new Point(481, 38);
            txtTipoProducto.Name = "txtTipoProducto";
            txtTipoProducto.Size = new Size(139, 16);
            txtTipoProducto.TabIndex = 6;
            // 
            // txtPrecioProducto
            // 
            txtPrecioProducto.BackColor = Color.WhiteSmoke;
            txtPrecioProducto.BorderStyle = BorderStyle.None;
            txtPrecioProducto.Location = new Point(220, 108);
            txtPrecioProducto.Name = "txtPrecioProducto";
            txtPrecioProducto.Size = new Size(138, 16);
            txtPrecioProducto.TabIndex = 7;
            // 
            // lblTipoNombre
            // 
            lblTipoNombre.AutoSize = true;
            lblTipoNombre.BackColor = Color.Transparent;
            lblTipoNombre.FlatStyle = FlatStyle.System;
            lblTipoNombre.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoNombre.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoNombre.Location = new Point(29, 24);
            lblTipoNombre.Name = "lblTipoNombre";
            lblTipoNombre.Size = new Size(116, 32);
            lblTipoNombre.TabIndex = 8;
            lblTipoNombre.Text = "Nombre :";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.BackColor = Color.Transparent;
            lblTipoProducto.FlatStyle = FlatStyle.System;
            lblTipoProducto.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoProducto.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoProducto.Location = new Point(399, 24);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(74, 32);
            lblTipoProducto.TabIndex = 9;
            lblTipoProducto.Text = "Tipo :";
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.BackColor = Color.Transparent;
            lblPrecioProducto.FlatStyle = FlatStyle.System;
            lblPrecioProducto.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblPrecioProducto.ForeColor = Color.FromArgb(0, 0, 64);
            lblPrecioProducto.Location = new Point(29, 92);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(164, 32);
            lblPrecioProducto.TabIndex = 10;
            lblPrecioProducto.Text = "Precio Venta :";
            // 
            // frmProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 478);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblTipoNombre);
            Controls.Add(txtPrecioProducto);
            Controls.Add(txtTipoProducto);
            Controls.Add(txtNombreProducto);
            Controls.Add(btnEliminar);
            Controls.Add(gtvProductos);
            Controls.Add(btnActualizar);
            Controls.Add(btnInsertar);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmProducto";
            Text = "frmProducto";
            Load += frmProducto_Load;
            ((System.ComponentModel.ISupportInitialize)gtvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInsertar;
        private Button btnActualizar;
        private DataGridView gtvProductos;
        private Button btnEliminar;
        private TextBox txtNombreProducto;
        private TextBox txtTipoProducto;
        private TextBox txtPrecioProducto;
        private Label lblTipoNombre;
        private Label lblTipoProducto;
        private Label lblPrecioProducto;
    }
}