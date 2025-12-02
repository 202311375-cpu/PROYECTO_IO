namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmCiudad
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
            lblNombreCiudad = new Label();
            txtNombreCiudad = new TextBox();
            btnEliminarCiudad = new Button();
            gtvCiudad = new DataGridView();
            btnActualizarCiudad = new Button();
            btnInsertarCiudad = new Button();
            label1 = new Label();
            txtCodigoPostalCiudad = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gtvCiudad).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCiudad
            // 
            lblNombreCiudad.AutoSize = true;
            lblNombreCiudad.BackColor = Color.Transparent;
            lblNombreCiudad.FlatStyle = FlatStyle.System;
            lblNombreCiudad.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblNombreCiudad.ForeColor = Color.FromArgb(0, 0, 64);
            lblNombreCiudad.Location = new Point(20, 23);
            lblNombreCiudad.Name = "lblNombreCiudad";
            lblNombreCiudad.Size = new Size(116, 32);
            lblNombreCiudad.TabIndex = 28;
            lblNombreCiudad.Text = "Nombre :";
            // 
            // txtNombreCiudad
            // 
            txtNombreCiudad.BackColor = Color.WhiteSmoke;
            txtNombreCiudad.BorderStyle = BorderStyle.None;
            txtNombreCiudad.Location = new Point(142, 37);
            txtNombreCiudad.Name = "txtNombreCiudad";
            txtNombreCiudad.Size = new Size(128, 16);
            txtNombreCiudad.TabIndex = 25;
            // 
            // btnEliminarCiudad
            // 
            btnEliminarCiudad.BackColor = Color.Orange;
            btnEliminarCiudad.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarCiudad.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarCiudad.Location = new Point(653, 312);
            btnEliminarCiudad.Name = "btnEliminarCiudad";
            btnEliminarCiudad.Size = new Size(101, 81);
            btnEliminarCiudad.TabIndex = 24;
            btnEliminarCiudad.UseVisualStyleBackColor = false;
            btnEliminarCiudad.Click += btnEliminarCiudad_Click;
            // 
            // gtvCiudad
            // 
            gtvCiudad.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvCiudad.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvCiudad.BorderStyle = BorderStyle.None;
            gtvCiudad.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvCiudad.Location = new Point(20, 98);
            gtvCiudad.Name = "gtvCiudad";
            gtvCiudad.ReadOnly = true;
            gtvCiudad.RowHeadersVisible = false;
            gtvCiudad.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvCiudad.Size = new Size(590, 311);
            gtvCiudad.TabIndex = 23;
            gtvCiudad.CellClick += gtvCiudad_CellClick;
            // 
            // btnActualizarCiudad
            // 
            btnActualizarCiudad.BackColor = Color.Orange;
            btnActualizarCiudad.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarCiudad.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarCiudad.Location = new Point(653, 208);
            btnActualizarCiudad.Name = "btnActualizarCiudad";
            btnActualizarCiudad.Size = new Size(101, 81);
            btnActualizarCiudad.TabIndex = 22;
            btnActualizarCiudad.UseVisualStyleBackColor = false;
            btnActualizarCiudad.Click += btnActualizarCiudad_Click;
            // 
            // btnInsertarCiudad
            // 
            btnInsertarCiudad.BackColor = Color.Orange;
            btnInsertarCiudad.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarCiudad.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarCiudad.Location = new Point(653, 109);
            btnInsertarCiudad.Name = "btnInsertarCiudad";
            btnInsertarCiudad.Size = new Size(101, 81);
            btnInsertarCiudad.TabIndex = 21;
            btnInsertarCiudad.UseVisualStyleBackColor = false;
            btnInsertarCiudad.Click += btnInsertarCiudad_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(289, 25);
            label1.Name = "label1";
            label1.Size = new Size(177, 32);
            label1.TabIndex = 29;
            label1.Text = "Codigo Postal :";
            // 
            // txtCodigoPostalCiudad
            // 
            txtCodigoPostalCiudad.BackColor = Color.WhiteSmoke;
            txtCodigoPostalCiudad.BorderStyle = BorderStyle.None;
            txtCodigoPostalCiudad.Location = new Point(472, 39);
            txtCodigoPostalCiudad.Name = "txtCodigoPostalCiudad";
            txtCodigoPostalCiudad.Size = new Size(138, 16);
            txtCodigoPostalCiudad.TabIndex = 30;
            // 
            // frmCiudad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtCodigoPostalCiudad);
            Controls.Add(label1);
            Controls.Add(lblNombreCiudad);
            Controls.Add(txtNombreCiudad);
            Controls.Add(btnEliminarCiudad);
            Controls.Add(gtvCiudad);
            Controls.Add(btnActualizarCiudad);
            Controls.Add(btnInsertarCiudad);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmCiudad";
            Text = "frmCiudad";
            Load += frmCiudad_Load;
            ((System.ComponentModel.ISupportInitialize)gtvCiudad).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblNombreCiudad;
        private TextBox txtNombreCiudad;
        private Button btnEliminarCiudad;
        private DataGridView gtvCiudad;
        private Button btnActualizarCiudad;
        private Button btnInsertarCiudad;
        private Label label1;
        private TextBox txtCodigoPostalCiudad;
    }
}