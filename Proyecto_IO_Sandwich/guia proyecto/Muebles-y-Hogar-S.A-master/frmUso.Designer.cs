namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmUso
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
            lblPrecioProducto = new Label();
            lblTipoProducto = new Label();
            lblTipoNombre = new Label();
            txtUso = new TextBox();
            btnEliminarUso = new Button();
            gtvUso = new DataGridView();
            btnInsertarUso = new Button();
            btnActualizarUso = new Button();
            cboProducto = new ComboBox();
            cboMaterial = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gtvUso).BeginInit();
            SuspendLayout();
            // 
            // lblPrecioProducto
            // 
            lblPrecioProducto.AutoSize = true;
            lblPrecioProducto.BackColor = Color.Transparent;
            lblPrecioProducto.FlatStyle = FlatStyle.System;
            lblPrecioProducto.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblPrecioProducto.ForeColor = Color.FromArgb(0, 0, 64);
            lblPrecioProducto.Location = new Point(22, 88);
            lblPrecioProducto.Name = "lblPrecioProducto";
            lblPrecioProducto.Size = new Size(118, 32);
            lblPrecioProducto.TabIndex = 20;
            lblPrecioProducto.Text = "Material :";
            // 
            // lblTipoProducto
            // 
            lblTipoProducto.AutoSize = true;
            lblTipoProducto.BackColor = Color.Transparent;
            lblTipoProducto.FlatStyle = FlatStyle.System;
            lblTipoProducto.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoProducto.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoProducto.Location = new Point(348, 20);
            lblTipoProducto.Name = "lblTipoProducto";
            lblTipoProducto.Size = new Size(126, 32);
            lblTipoProducto.TabIndex = 19;
            lblTipoProducto.Text = "Producto :";
            // 
            // lblTipoNombre
            // 
            lblTipoNombre.AutoSize = true;
            lblTipoNombre.BackColor = Color.Transparent;
            lblTipoNombre.FlatStyle = FlatStyle.System;
            lblTipoNombre.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblTipoNombre.ForeColor = Color.FromArgb(0, 0, 64);
            lblTipoNombre.Location = new Point(22, 20);
            lblTipoNombre.Name = "lblTipoNombre";
            lblTipoNombre.Size = new Size(68, 32);
            lblTipoNombre.TabIndex = 18;
            lblTipoNombre.Text = "Uso :";
            // 
            // txtUso
            // 
            txtUso.BackColor = SystemColors.InactiveBorder;
            txtUso.BorderStyle = BorderStyle.None;
            txtUso.Location = new Point(193, 34);
            txtUso.Name = "txtUso";
            txtUso.Size = new Size(118, 16);
            txtUso.TabIndex = 15;
            // 
            // btnEliminarUso
            // 
            btnEliminarUso.BackColor = Color.Orange;
            btnEliminarUso.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarUso.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarUso.Location = new Point(661, 359);
            btnEliminarUso.Name = "btnEliminarUso";
            btnEliminarUso.Size = new Size(87, 68);
            btnEliminarUso.TabIndex = 14;
            btnEliminarUso.UseVisualStyleBackColor = false;
            btnEliminarUso.Click += btnEliminarUso_Click;
            // 
            // gtvUso
            // 
            gtvUso.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvUso.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvUso.BorderStyle = BorderStyle.None;
            gtvUso.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvUso.Location = new Point(20, 156);
            gtvUso.Name = "gtvUso";
            gtvUso.ReadOnly = true;
            gtvUso.RowHeadersVisible = false;
            gtvUso.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvUso.Size = new Size(590, 273);
            gtvUso.TabIndex = 13;
            gtvUso.CellClick += gtvUso_CellClick;
            // 
            // btnInsertarUso
            // 
            btnInsertarUso.BackColor = Color.Orange;
            btnInsertarUso.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarUso.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarUso.Location = new Point(661, 166);
            btnInsertarUso.Name = "btnInsertarUso";
            btnInsertarUso.Size = new Size(87, 68);
            btnInsertarUso.TabIndex = 21;
            btnInsertarUso.UseVisualStyleBackColor = false;
            btnInsertarUso.Click += btnInsertarUso_Click;
            // 
            // btnActualizarUso
            // 
            btnActualizarUso.BackColor = Color.Orange;
            btnActualizarUso.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarUso.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarUso.Location = new Point(661, 268);
            btnActualizarUso.Name = "btnActualizarUso";
            btnActualizarUso.Size = new Size(87, 68);
            btnActualizarUso.TabIndex = 22;
            btnActualizarUso.UseVisualStyleBackColor = false;
            btnActualizarUso.Click += btnActualizarUso_Click;
            // 
            // cboProducto
            // 
            cboProducto.FormattingEnabled = true;
            cboProducto.Location = new Point(492, 29);
            cboProducto.Name = "cboProducto";
            cboProducto.Size = new Size(118, 23);
            cboProducto.TabIndex = 23;
            // 
            // cboMaterial
            // 
            cboMaterial.FormattingEnabled = true;
            cboMaterial.Location = new Point(193, 97);
            cboMaterial.Name = "cboMaterial";
            cboMaterial.Size = new Size(118, 23);
            cboMaterial.TabIndex = 24;
            // 
            // frmUso
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(cboMaterial);
            Controls.Add(cboProducto);
            Controls.Add(btnActualizarUso);
            Controls.Add(btnInsertarUso);
            Controls.Add(lblPrecioProducto);
            Controls.Add(lblTipoProducto);
            Controls.Add(lblTipoNombre);
            Controls.Add(txtUso);
            Controls.Add(btnEliminarUso);
            Controls.Add(gtvUso);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmUso";
            Text = "frmUso";
            Load += frmUso_Load;
            ((System.ComponentModel.ISupportInitialize)gtvUso).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecioProducto;
        private Label lblTipoProducto;
        private Label lblTipoNombre;
        private TextBox txtUso;
        private Button btnEliminarUso;
        private DataGridView gtvUso;
        private Button btnInsertarUso;
        private Button btnActualizarUso;
        private ComboBox cboProducto;
        private ComboBox cboMaterial;
    }
}