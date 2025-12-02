namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmEmpresaTransporte
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
            lblNombreEmpresaTransporte = new Label();
            txtNombreEmpresaTransporte = new TextBox();
            btnEliminarmpresaTSP = new Button();
            gtvmpresaTSP = new DataGridView();
            btnActualizarmpresaTSP = new Button();
            btnInsertarmpresaTSP = new Button();
            label1 = new Label();
            label2 = new Label();
            txtDirecciónET = new TextBox();
            txtRucET = new TextBox();
            ((System.ComponentModel.ISupportInitialize)gtvmpresaTSP).BeginInit();
            SuspendLayout();
            // 
            // lblNombreEmpresaTransporte
            // 
            lblNombreEmpresaTransporte.AutoSize = true;
            lblNombreEmpresaTransporte.BackColor = Color.Transparent;
            lblNombreEmpresaTransporte.FlatStyle = FlatStyle.System;
            lblNombreEmpresaTransporte.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblNombreEmpresaTransporte.ForeColor = Color.FromArgb(0, 0, 64);
            lblNombreEmpresaTransporte.Location = new Point(31, 16);
            lblNombreEmpresaTransporte.Name = "lblNombreEmpresaTransporte";
            lblNombreEmpresaTransporte.Size = new Size(116, 32);
            lblNombreEmpresaTransporte.TabIndex = 18;
            lblNombreEmpresaTransporte.Text = "Nombre :";
            // 
            // txtNombreEmpresaTransporte
            // 
            txtNombreEmpresaTransporte.BackColor = Color.WhiteSmoke;
            txtNombreEmpresaTransporte.BorderStyle = BorderStyle.None;
            txtNombreEmpresaTransporte.Location = new Point(202, 30);
            txtNombreEmpresaTransporte.Name = "txtNombreEmpresaTransporte";
            txtNombreEmpresaTransporte.Size = new Size(138, 16);
            txtNombreEmpresaTransporte.TabIndex = 15;
            // 
            // btnEliminarmpresaTSP
            // 
            btnEliminarmpresaTSP.BackColor = Color.Orange;
            btnEliminarmpresaTSP.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarmpresaTSP.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarmpresaTSP.Location = new Point(659, 341);
            btnEliminarmpresaTSP.Name = "btnEliminarmpresaTSP";
            btnEliminarmpresaTSP.Size = new Size(98, 81);
            btnEliminarmpresaTSP.TabIndex = 14;
            btnEliminarmpresaTSP.UseVisualStyleBackColor = false;
            btnEliminarmpresaTSP.Click += btnEliminarmpresaTSP_Click;
            // 
            // gtvmpresaTSP
            // 
            gtvmpresaTSP.AllowUserToAddRows = false;
            gtvmpresaTSP.AllowUserToDeleteRows = false;
            gtvmpresaTSP.AllowUserToResizeColumns = false;
            gtvmpresaTSP.AllowUserToResizeRows = false;
            gtvmpresaTSP.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvmpresaTSP.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvmpresaTSP.BorderStyle = BorderStyle.None;
            gtvmpresaTSP.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvmpresaTSP.Location = new Point(31, 108);
            gtvmpresaTSP.Name = "gtvmpresaTSP";
            gtvmpresaTSP.ReadOnly = true;
            gtvmpresaTSP.RowHeadersVisible = false;
            gtvmpresaTSP.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvmpresaTSP.Size = new Size(590, 314);
            gtvmpresaTSP.TabIndex = 13;
            gtvmpresaTSP.CellClick += gtvmpresaTSP_CellClick;
            // 
            // btnActualizarmpresaTSP
            // 
            btnActualizarmpresaTSP.BackColor = Color.Orange;
            btnActualizarmpresaTSP.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarmpresaTSP.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarmpresaTSP.Location = new Point(659, 226);
            btnActualizarmpresaTSP.Name = "btnActualizarmpresaTSP";
            btnActualizarmpresaTSP.Size = new Size(98, 81);
            btnActualizarmpresaTSP.TabIndex = 12;
            btnActualizarmpresaTSP.UseVisualStyleBackColor = false;
            btnActualizarmpresaTSP.Click += btnActualizarmpresaTSP_Click;
            // 
            // btnInsertarmpresaTSP
            // 
            btnInsertarmpresaTSP.BackColor = Color.Orange;
            btnInsertarmpresaTSP.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarmpresaTSP.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarmpresaTSP.Location = new Point(659, 108);
            btnInsertarmpresaTSP.Name = "btnInsertarmpresaTSP";
            btnInsertarmpresaTSP.Size = new Size(98, 81);
            btnInsertarmpresaTSP.TabIndex = 11;
            btnInsertarmpresaTSP.UseVisualStyleBackColor = false;
            btnInsertarmpresaTSP.Click += btnInsertarmpresaTSP_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.FlatStyle = FlatStyle.System;
            label1.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(0, 0, 64);
            label1.Location = new Point(388, 16);
            label1.Name = "label1";
            label1.Size = new Size(67, 32);
            label1.TabIndex = 19;
            label1.Text = "Ruc :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.System;
            label2.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(31, 62);
            label2.Name = "label2";
            label2.Size = new Size(121, 32);
            label2.TabIndex = 20;
            label2.Text = "Dirección:";
            // 
            // txtDirecciónET
            // 
            txtDirecciónET.BackColor = Color.WhiteSmoke;
            txtDirecciónET.BorderStyle = BorderStyle.None;
            txtDirecciónET.Location = new Point(202, 76);
            txtDirecciónET.Name = "txtDirecciónET";
            txtDirecciónET.Size = new Size(138, 16);
            txtDirecciónET.TabIndex = 21;
            // 
            // txtRucET
            // 
            txtRucET.BackColor = Color.WhiteSmoke;
            txtRucET.BorderStyle = BorderStyle.None;
            txtRucET.Location = new Point(471, 30);
            txtRucET.Name = "txtRucET";
            txtRucET.Size = new Size(138, 16);
            txtRucET.TabIndex = 22;
            // 
            // frmEmpresaTransporte
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(txtRucET);
            Controls.Add(txtDirecciónET);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(lblNombreEmpresaTransporte);
            Controls.Add(txtNombreEmpresaTransporte);
            Controls.Add(btnEliminarmpresaTSP);
            Controls.Add(gtvmpresaTSP);
            Controls.Add(btnActualizarmpresaTSP);
            Controls.Add(btnInsertarmpresaTSP);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmEmpresaTransporte";
            Text = "frmEmpresaTransporte";
            Load += frmEmpresaTransporte_Load;
            ((System.ComponentModel.ISupportInitialize)gtvmpresaTSP).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPrecioProducto;
        private Label lblTipoProducto;
        private Label lblNombreEmpresaTransporte;
        private TextBox txtPrecioProducto;
        private TextBox txtTipoProducto;
        private TextBox txtNombreEmpresaTransporte;
        private Button btnEliminarmpresaTSP;
        private DataGridView gtvmpresaTSP;
        private Button btnActualizarmpresaTSP;
        private Button btnInsertarmpresaTSP;
        private Label label1;
        private Label label2;
        private TextBox txtDirecciónET;
        private TextBox txtRucET;
    }
}