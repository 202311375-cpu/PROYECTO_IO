namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmDemanda
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
            lblProductoDemanda = new Label();
            lblDemandaCiudad = new Label();
            lblNombreDemanda = new Label();
            txtCantidadDemandada = new TextBox();
            btnEliminarDemanda = new Button();
            gtvDemanda = new DataGridView();
            btnActualizarDemanda = new Button();
            btnInsertarDemanda = new Button();
            cboCiudades = new ComboBox();
            cboProductos = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)gtvDemanda).BeginInit();
            SuspendLayout();
            // 
            // lblProductoDemanda
            // 
            lblProductoDemanda.AutoSize = true;
            lblProductoDemanda.BackColor = Color.Transparent;
            lblProductoDemanda.FlatStyle = FlatStyle.System;
            lblProductoDemanda.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblProductoDemanda.ForeColor = Color.FromArgb(0, 0, 64);
            lblProductoDemanda.Location = new Point(45, 72);
            lblProductoDemanda.Name = "lblProductoDemanda";
            lblProductoDemanda.Size = new Size(126, 32);
            lblProductoDemanda.TabIndex = 20;
            lblProductoDemanda.Text = "Producto :";
            // 
            // lblDemandaCiudad
            // 
            lblDemandaCiudad.AutoSize = true;
            lblDemandaCiudad.BackColor = Color.Transparent;
            lblDemandaCiudad.FlatStyle = FlatStyle.System;
            lblDemandaCiudad.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblDemandaCiudad.ForeColor = Color.FromArgb(0, 0, 64);
            lblDemandaCiudad.Location = new Point(469, 19);
            lblDemandaCiudad.Name = "lblDemandaCiudad";
            lblDemandaCiudad.Size = new Size(103, 32);
            lblDemandaCiudad.TabIndex = 19;
            lblDemandaCiudad.Text = "Ciudad :";
            // 
            // lblNombreDemanda
            // 
            lblNombreDemanda.AutoSize = true;
            lblNombreDemanda.BackColor = Color.Transparent;
            lblNombreDemanda.FlatStyle = FlatStyle.System;
            lblNombreDemanda.Font = new Font("Yu Gothic UI", 18F, FontStyle.Bold);
            lblNombreDemanda.ForeColor = Color.FromArgb(0, 0, 64);
            lblNombreDemanda.Location = new Point(45, 19);
            lblNombreDemanda.Name = "lblNombreDemanda";
            lblNombreDemanda.Size = new Size(268, 32);
            lblNombreDemanda.TabIndex = 18;
            lblNombreDemanda.Text = "Cantidad de demanda :";
            // 
            // txtCantidadDemandada
            // 
            txtCantidadDemandada.BackColor = SystemColors.InactiveBorder;
            txtCantidadDemandada.BorderStyle = BorderStyle.None;
            txtCantidadDemandada.Location = new Point(332, 33);
            txtCantidadDemandada.Name = "txtCantidadDemandada";
            txtCantidadDemandada.Size = new Size(92, 16);
            txtCantidadDemandada.TabIndex = 15;
            // 
            // btnEliminarDemanda
            // 
            btnEliminarDemanda.BackColor = Color.Orange;
            btnEliminarDemanda.BackgroundImage = Properties.Resources.eliminar_producto;
            btnEliminarDemanda.BackgroundImageLayout = ImageLayout.Zoom;
            btnEliminarDemanda.Location = new Point(671, 351);
            btnEliminarDemanda.Name = "btnEliminarDemanda";
            btnEliminarDemanda.Size = new Size(87, 68);
            btnEliminarDemanda.TabIndex = 14;
            btnEliminarDemanda.UseVisualStyleBackColor = false;
            btnEliminarDemanda.Click += btnEliminarDemanda_Click;
            // 
            // gtvDemanda
            // 
            gtvDemanda.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gtvDemanda.BackgroundColor = SystemColors.GradientInactiveCaption;
            gtvDemanda.BorderStyle = BorderStyle.None;
            gtvDemanda.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gtvDemanda.Location = new Point(42, 158);
            gtvDemanda.Name = "gtvDemanda";
            gtvDemanda.ReadOnly = true;
            gtvDemanda.RowHeadersVisible = false;
            gtvDemanda.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gtvDemanda.Size = new Size(590, 273);
            gtvDemanda.TabIndex = 13;
            gtvDemanda.CellClick += gtvDemanda_CellClick;
            // 
            // btnActualizarDemanda
            // 
            btnActualizarDemanda.BackColor = Color.Orange;
            btnActualizarDemanda.BackgroundImage = Properties.Resources.actualizar;
            btnActualizarDemanda.BackgroundImageLayout = ImageLayout.Zoom;
            btnActualizarDemanda.Location = new Point(671, 257);
            btnActualizarDemanda.Name = "btnActualizarDemanda";
            btnActualizarDemanda.Size = new Size(87, 68);
            btnActualizarDemanda.TabIndex = 12;
            btnActualizarDemanda.UseVisualStyleBackColor = false;
            btnActualizarDemanda.Click += btnActualizarDemanda_Click;
            // 
            // btnInsertarDemanda
            // 
            btnInsertarDemanda.BackColor = Color.Orange;
            btnInsertarDemanda.BackgroundImage = Properties.Resources.carrito_de_compras;
            btnInsertarDemanda.BackgroundImageLayout = ImageLayout.Zoom;
            btnInsertarDemanda.Location = new Point(671, 168);
            btnInsertarDemanda.Name = "btnInsertarDemanda";
            btnInsertarDemanda.Size = new Size(87, 68);
            btnInsertarDemanda.TabIndex = 11;
            btnInsertarDemanda.UseVisualStyleBackColor = false;
            btnInsertarDemanda.Click += btnInsertarDemanda_Click;
            // 
            // cboCiudades
            // 
            cboCiudades.BackColor = SystemColors.InactiveBorder;
            cboCiudades.FlatStyle = FlatStyle.Popup;
            cboCiudades.FormattingEnabled = true;
            cboCiudades.Location = new Point(578, 26);
            cboCiudades.Name = "cboCiudades";
            cboCiudades.Size = new Size(92, 23);
            cboCiudades.TabIndex = 21;
            // 
            // cboProductos
            // 
            cboProductos.BackColor = SystemColors.InactiveBorder;
            cboProductos.FlatStyle = FlatStyle.Popup;
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(332, 81);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(92, 23);
            cboProductos.TabIndex = 22;
            // 
            // frmDemanda
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(cboProductos);
            Controls.Add(cboCiudades);
            Controls.Add(lblProductoDemanda);
            Controls.Add(lblDemandaCiudad);
            Controls.Add(lblNombreDemanda);
            Controls.Add(txtCantidadDemandada);
            Controls.Add(btnEliminarDemanda);
            Controls.Add(gtvDemanda);
            Controls.Add(btnActualizarDemanda);
            Controls.Add(btnInsertarDemanda);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmDemanda";
            Text = "Demanda";
            Load += frmDemanda_Load;
            ((System.ComponentModel.ISupportInitialize)gtvDemanda).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblProductoDemanda;
        private Label lblDemandaCiudad;
        private Label lblNombreDemanda;
        private TextBox txtCantidadDemandada;
        private Button btnEliminarDemanda;
        private DataGridView gtvDemanda;
        private Button btnActualizarDemanda;
        private Button btnInsertarDemanda;
        private ComboBox cboCiudades;
        private ComboBox cboProductos;
    }
}