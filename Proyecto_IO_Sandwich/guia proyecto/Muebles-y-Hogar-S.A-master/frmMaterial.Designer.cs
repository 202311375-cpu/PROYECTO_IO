namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmMaterial
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
            lblCostoMaterial = new Label();
            lblCantiDispoMaterial = new Label();
            lblNombreMaterial = new Label();
            txtCantidadDisponibleMaterial = new TextBox();
            txtCostoUnitarioMaterial = new TextBox();
            txtNombreMaterial = new TextBox();
            btnEliminarMaterial = new Button();
            gtvMaterial = new DataGridView();
            btnActualizarMaterial = new Button();
            btnInsertarMaterial = new Button();
            ((System.ComponentModel.ISupportInitialize)gtvMaterial).BeginInit();
            SuspendLayout();
            // 
            // lblCostoMaterial
            // 
            lblCostoMaterial.AutoSize = true;
            lblCostoMaterial.BackColor = Color.Transparent;
            lblCostoMaterial.FlatStyle = FlatStyle.System;
            lblCostoMaterial.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblCostoMaterial.ForeColor = Color.FromArgb(0, 0, 64);
            lblCostoMaterial.Location = new Point(45, 87);
            lblCostoMaterial.Name = "lblCostoMaterial";
            lblCostoMaterial.Size = new Size(89, 32);
            lblCostoMaterial.TabIndex = 20;
            lblCostoMaterial.Text = "Costo :";
            // 
            // lblCantiDispoMaterial
            // 
            lblCantiDispoMaterial.AutoSize = true;
            lblCantiDispoMaterial.BackColor = Color.Transparent;
            lblCantiDispoMaterial.FlatStyle = FlatStyle.System;
            lblCantiDispoMaterial.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblCantiDispoMaterial.ForeColor = Color.FromArgb(0, 0, 64);
            lblCantiDispoMaterial.Location = new Point(322, 19);
            lblCantiDispoMaterial.Name = "lblCantiDispoMaterial";
            lblCantiDispoMaterial.Size = new Size(246, 32);
            lblCantiDispoMaterial.TabIndex = 19;
            lblCantiDispoMaterial.Text = "Cantidad Disponible :";
            // 
            // lblNombreMaterial
            // 
            lblNombreMaterial.AutoSize = true;
            lblNombreMaterial.BackColor = Color.Transparent;
            lblNombreMaterial.FlatStyle = FlatStyle.System;
            lblNombreMaterial.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblNombreMaterial.ForeColor = Color.FromArgb(0, 0, 64);
            lblNombreMaterial.Location = new Point(45, 19);
            lblNombreMaterial.Name = "lblNombreMaterial";
            lblNombreMaterial.Size = new Size(116, 32);
            lblNombreMaterial.TabIndex = 18;
            lblNombreMaterial.Text = "Nombre :";
            // 
            // txtCantidadDisponibleMaterial
            // 
            txtCantidadDisponibleMaterial.BackColor = Color.WhiteSmoke;
            txtCantidadDisponibleMaterial.BorderStyle = BorderStyle.None;
            txtCantidadDisponibleMaterial.Location = new Point(574, 33);
            txtCantidadDisponibleMaterial.Name = "txtCantidadDisponibleMaterial";
            txtCantidadDisponibleMaterial.Size = new Size(138, 16);
            txtCantidadDisponibleMaterial.TabIndex = 17;
            // 
            // txtCostoUnitarioMaterial
            // 
            txtCostoUnitarioMaterial.BackColor = Color.WhiteSmoke;
            txtCostoUnitarioMaterial.BorderStyle = BorderStyle.None;
            txtCostoUnitarioMaterial.Location = new Point(162, 101);
            txtCostoUnitarioMaterial.Name = "txtCostoUnitarioMaterial";
            txtCostoUnitarioMaterial.Size = new Size(139, 16);
            txtCostoUnitarioMaterial.TabIndex = 16;
            // 
            // txtNombreMaterial
            // 
            txtNombreMaterial.BackColor = Color.WhiteSmoke;
            txtNombreMaterial.BorderStyle = BorderStyle.None;
            txtNombreMaterial.Location = new Point(162, 33);
            txtNombreMaterial.Name = "txtNombreMaterial";
            txtNombreMaterial.Size = new Size(138, 16);
            txtNombreMaterial.TabIndex = 15;
            // 
            // btnEliminarMaterial
            // 
            btnEliminarMaterial.BackColor = Color.Orange;
            btnEliminarMaterial.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarMaterial.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarMaterial.Location = new Point(671, 351);
            btnEliminarMaterial.Name = "btnEliminarMaterial";
            btnEliminarMaterial.Size = new Size(87, 68);
            btnEliminarMaterial.TabIndex = 14;
            btnEliminarMaterial.UseVisualStyleBackColor = false;
            btnEliminarMaterial.Click += btnEliminarMaterial_Click;
            // 
            // gtvMaterial
            // 
            gtvMaterial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvMaterial.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvMaterial.BorderStyle = BorderStyle.None;
            gtvMaterial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvMaterial.Location = new Point(42, 158);
            gtvMaterial.Name = "gtvMaterial";
            gtvMaterial.ReadOnly = true;
            gtvMaterial.RowHeadersVisible = false;
            gtvMaterial.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvMaterial.Size = new Size(590, 273);
            gtvMaterial.TabIndex = 13;
            gtvMaterial.CellClick += gtvMaterial_CellClick;
            // 
            // btnActualizarMaterial
            // 
            btnActualizarMaterial.BackColor = Color.Orange;
            btnActualizarMaterial.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarMaterial.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarMaterial.Location = new Point(671, 257);
            btnActualizarMaterial.Name = "btnActualizarMaterial";
            btnActualizarMaterial.Size = new Size(87, 68);
            btnActualizarMaterial.TabIndex = 12;
            btnActualizarMaterial.UseVisualStyleBackColor = false;
            btnActualizarMaterial.Click += btnActualizarMaterial_Click;
            // 
            // btnInsertarMaterial
            // 
            btnInsertarMaterial.BackColor = Color.Orange;
            btnInsertarMaterial.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarMaterial.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarMaterial.Location = new Point(671, 168);
            btnInsertarMaterial.Name = "btnInsertarMaterial";
            btnInsertarMaterial.Size = new Size(87, 68);
            btnInsertarMaterial.TabIndex = 11;
            btnInsertarMaterial.UseVisualStyleBackColor = false;
            btnInsertarMaterial.Click += btnInsertarMaterial_Click;
            // 
            // frmMaterial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(lblCostoMaterial);
            Controls.Add(lblCantiDispoMaterial);
            Controls.Add(lblNombreMaterial);
            Controls.Add(txtCantidadDisponibleMaterial);
            Controls.Add(txtCostoUnitarioMaterial);
            Controls.Add(txtNombreMaterial);
            Controls.Add(btnEliminarMaterial);
            Controls.Add(gtvMaterial);
            Controls.Add(btnActualizarMaterial);
            Controls.Add(btnInsertarMaterial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmMaterial";
            Text = "frmMaterial";
            Load += frmMaterial_Load;
            ((System.ComponentModel.ISupportInitialize)gtvMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblCostoMaterial;
        private Label lblCantiDispoMaterial;
        private Label lblNombreMaterial;
        private TextBox txtCantidadDisponibleMaterial;
        private TextBox txtCostoUnitarioMaterial;
        private TextBox txtNombreMaterial;
        private Button btnEliminarMaterial;
        private DataGridView gtvMaterial;
        private Button btnActualizarMaterial;
        private Button btnInsertarMaterial;
    }
}