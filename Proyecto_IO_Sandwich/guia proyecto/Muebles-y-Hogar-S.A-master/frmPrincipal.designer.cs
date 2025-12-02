namespace PlayerUI
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            panelSideMenu = new Panel();
            btnExit = new Button();
            btnHelp = new Button();
            btnEqualizer = new Button();
            panelTablaISubMenu = new Panel();
            btnEnvio = new Button();
            btnCapacidadEnvio = new Button();
            btnCostoDeEnvio = new Button();
            btnProductoMaterial = new Button();
            btnDemanda = new Button();
            btnCruds2 = new Button();
            panelTablaPSubMenu = new Panel();
            btnMaterial = new Button();
            btnTaller = new Button();
            btnProducto = new Button();
            btnCiudad = new Button();
            btnCruds = new Button();
            panelLogo = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox9 = new PictureBox();
            panelChildForm = new Panel();
            btnEmpresaTransporte = new Button();
            panelSideMenu.SuspendLayout();
            panelTablaISubMenu.SuspendLayout();
            panelTablaPSubMenu.SuspendLayout();
            panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            panelChildForm.SuspendLayout();
            SuspendLayout();
            // 
            // panelSideMenu
            // 
            panelSideMenu.AutoScroll = true;
            panelSideMenu.BackColor = Color.FromArgb(11, 7, 17);
            panelSideMenu.Controls.Add(btnExit);
            panelSideMenu.Controls.Add(btnHelp);
            panelSideMenu.Controls.Add(btnEqualizer);
            panelSideMenu.Controls.Add(panelTablaISubMenu);
            panelSideMenu.Controls.Add(btnCruds2);
            panelSideMenu.Controls.Add(panelTablaPSubMenu);
            panelSideMenu.Controls.Add(btnCruds);
            panelSideMenu.Controls.Add(panelLogo);
            panelSideMenu.Dock = DockStyle.Left;
            panelSideMenu.Location = new Point(0, 0);
            panelSideMenu.Name = "panelSideMenu";
            panelSideMenu.Size = new Size(250, 711);
            panelSideMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Dock = DockStyle.Bottom;
            btnExit.FlatAppearance.BorderSize = 0;
            btnExit.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnExit.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.ForeColor = Color.Silver;
            btnExit.Image = (Image)resources.GetObject("btnExit.Image");
            btnExit.ImageAlign = ContentAlignment.MiddleLeft;
            btnExit.Location = new Point(0, 653);
            btnExit.Name = "btnExit";
            btnExit.Padding = new Padding(5, 0, 0, 0);
            btnExit.Size = new Size(233, 65);
            btnExit.TabIndex = 9;
            btnExit.Text = "  Exit";
            btnExit.TextAlign = ContentAlignment.MiddleLeft;
            btnExit.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnHelp
            // 
            btnHelp.Dock = DockStyle.Top;
            btnHelp.FlatAppearance.BorderSize = 0;
            btnHelp.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnHelp.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnHelp.FlatStyle = FlatStyle.Flat;
            btnHelp.ForeColor = Color.Silver;
            btnHelp.Image = (Image)resources.GetObject("btnHelp.Image");
            btnHelp.ImageAlign = ContentAlignment.MiddleLeft;
            btnHelp.Location = new Point(0, 614);
            btnHelp.Name = "btnHelp";
            btnHelp.Padding = new Padding(5, 0, 0, 0);
            btnHelp.Size = new Size(233, 39);
            btnHelp.TabIndex = 8;
            btnHelp.Text = "  Help";
            btnHelp.TextAlign = ContentAlignment.MiddleLeft;
            btnHelp.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnHelp.UseVisualStyleBackColor = true;
            btnHelp.Click += btnHelp_Click;
            // 
            // btnEqualizer
            // 
            btnEqualizer.Dock = DockStyle.Top;
            btnEqualizer.FlatAppearance.BorderSize = 0;
            btnEqualizer.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnEqualizer.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnEqualizer.FlatStyle = FlatStyle.Flat;
            btnEqualizer.ForeColor = Color.Silver;
            btnEqualizer.Image = (Image)resources.GetObject("btnEqualizer.Image");
            btnEqualizer.ImageAlign = ContentAlignment.MiddleLeft;
            btnEqualizer.Location = new Point(0, 569);
            btnEqualizer.Name = "btnEqualizer";
            btnEqualizer.Padding = new Padding(5, 0, 0, 0);
            btnEqualizer.Size = new Size(233, 45);
            btnEqualizer.TabIndex = 5;
            btnEqualizer.Text = "  Resultado";
            btnEqualizer.TextAlign = ContentAlignment.MiddleLeft;
            btnEqualizer.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEqualizer.UseVisualStyleBackColor = true;
            btnEqualizer.Click += btnEqualizer_Click;
            // 
            // panelTablaISubMenu
            // 
            panelTablaISubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelTablaISubMenu.Controls.Add(btnEnvio);
            panelTablaISubMenu.Controls.Add(btnCapacidadEnvio);
            panelTablaISubMenu.Controls.Add(btnCostoDeEnvio);
            panelTablaISubMenu.Controls.Add(btnProductoMaterial);
            panelTablaISubMenu.Controls.Add(btnDemanda);
            panelTablaISubMenu.Dock = DockStyle.Top;
            panelTablaISubMenu.Location = new Point(0, 377);
            panelTablaISubMenu.Name = "panelTablaISubMenu";
            panelTablaISubMenu.Size = new Size(233, 192);
            panelTablaISubMenu.TabIndex = 4;
            // 
            // btnEnvio
            // 
            btnEnvio.Dock = DockStyle.Top;
            btnEnvio.FlatAppearance.BorderSize = 0;
            btnEnvio.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnEnvio.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnEnvio.FlatStyle = FlatStyle.Flat;
            btnEnvio.ForeColor = Color.Silver;
            btnEnvio.Location = new Point(0, 148);
            btnEnvio.Name = "btnEnvio";
            btnEnvio.Padding = new Padding(35, 0, 0, 0);
            btnEnvio.Size = new Size(233, 34);
            btnEnvio.TabIndex = 6;
            btnEnvio.Text = "Envio";
            btnEnvio.TextAlign = ContentAlignment.MiddleLeft;
            btnEnvio.UseVisualStyleBackColor = true;
            btnEnvio.Click += btnEnvio_Click;
            // 
            // btnCapacidadEnvio
            // 
            btnCapacidadEnvio.Dock = DockStyle.Top;
            btnCapacidadEnvio.FlatAppearance.BorderSize = 0;
            btnCapacidadEnvio.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnCapacidadEnvio.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnCapacidadEnvio.FlatStyle = FlatStyle.Flat;
            btnCapacidadEnvio.ForeColor = Color.Silver;
            btnCapacidadEnvio.Location = new Point(0, 114);
            btnCapacidadEnvio.Name = "btnCapacidadEnvio";
            btnCapacidadEnvio.Padding = new Padding(35, 0, 0, 0);
            btnCapacidadEnvio.Size = new Size(233, 34);
            btnCapacidadEnvio.TabIndex = 5;
            btnCapacidadEnvio.Text = "Capacidad de envio";
            btnCapacidadEnvio.TextAlign = ContentAlignment.MiddleLeft;
            btnCapacidadEnvio.UseVisualStyleBackColor = true;
            btnCapacidadEnvio.Click += btnCapacidadEnvio_Click;
            // 
            // btnCostoDeEnvio
            // 
            btnCostoDeEnvio.Dock = DockStyle.Top;
            btnCostoDeEnvio.FlatAppearance.BorderSize = 0;
            btnCostoDeEnvio.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnCostoDeEnvio.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnCostoDeEnvio.FlatStyle = FlatStyle.Flat;
            btnCostoDeEnvio.ForeColor = Color.Silver;
            btnCostoDeEnvio.Location = new Point(0, 80);
            btnCostoDeEnvio.Name = "btnCostoDeEnvio";
            btnCostoDeEnvio.Padding = new Padding(35, 0, 0, 0);
            btnCostoDeEnvio.Size = new Size(233, 34);
            btnCostoDeEnvio.TabIndex = 4;
            btnCostoDeEnvio.Text = "Costo de envio";
            btnCostoDeEnvio.TextAlign = ContentAlignment.MiddleLeft;
            btnCostoDeEnvio.UseVisualStyleBackColor = true;
            btnCostoDeEnvio.Click += btnCostoDeEnvio_Click;
            // 
            // btnProductoMaterial
            // 
            btnProductoMaterial.Dock = DockStyle.Top;
            btnProductoMaterial.FlatAppearance.BorderSize = 0;
            btnProductoMaterial.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnProductoMaterial.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnProductoMaterial.FlatStyle = FlatStyle.Flat;
            btnProductoMaterial.ForeColor = Color.Silver;
            btnProductoMaterial.Location = new Point(0, 40);
            btnProductoMaterial.Name = "btnProductoMaterial";
            btnProductoMaterial.Padding = new Padding(35, 0, 0, 0);
            btnProductoMaterial.Size = new Size(233, 40);
            btnProductoMaterial.TabIndex = 1;
            btnProductoMaterial.Text = "Uso Material";
            btnProductoMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnProductoMaterial.UseVisualStyleBackColor = true;
            btnProductoMaterial.Click += btnProductoMaterial_Click;
            // 
            // btnDemanda
            // 
            btnDemanda.Dock = DockStyle.Top;
            btnDemanda.FlatAppearance.BorderSize = 0;
            btnDemanda.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnDemanda.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnDemanda.FlatStyle = FlatStyle.Flat;
            btnDemanda.ForeColor = Color.Silver;
            btnDemanda.Location = new Point(0, 0);
            btnDemanda.Name = "btnDemanda";
            btnDemanda.Padding = new Padding(35, 0, 0, 0);
            btnDemanda.Size = new Size(233, 40);
            btnDemanda.TabIndex = 0;
            btnDemanda.Text = "Demanda";
            btnDemanda.TextAlign = ContentAlignment.MiddleLeft;
            btnDemanda.UseVisualStyleBackColor = true;
            btnDemanda.Click += btnDemanda_Click;
            // 
            // btnCruds2
            // 
            btnCruds2.Dock = DockStyle.Top;
            btnCruds2.FlatAppearance.BorderSize = 0;
            btnCruds2.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnCruds2.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnCruds2.FlatStyle = FlatStyle.Flat;
            btnCruds2.ForeColor = Color.Silver;
            btnCruds2.Image = (Image)resources.GetObject("btnCruds2.Image");
            btnCruds2.ImageAlign = ContentAlignment.MiddleLeft;
            btnCruds2.Location = new Point(0, 332);
            btnCruds2.Name = "btnCruds2";
            btnCruds2.Padding = new Padding(5, 0, 0, 0);
            btnCruds2.Size = new Size(233, 45);
            btnCruds2.TabIndex = 3;
            btnCruds2.Text = "  Tablas intermedias";
            btnCruds2.TextAlign = ContentAlignment.MiddleLeft;
            btnCruds2.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCruds2.UseVisualStyleBackColor = true;
            btnCruds2.Click += btnCruds2_Click;
            // 
            // panelTablaPSubMenu
            // 
            panelTablaPSubMenu.BackColor = Color.FromArgb(35, 32, 39);
            panelTablaPSubMenu.Controls.Add(btnEmpresaTransporte);
            panelTablaPSubMenu.Controls.Add(btnMaterial);
            panelTablaPSubMenu.Controls.Add(btnTaller);
            panelTablaPSubMenu.Controls.Add(btnProducto);
            panelTablaPSubMenu.Controls.Add(btnCiudad);
            panelTablaPSubMenu.Dock = DockStyle.Top;
            panelTablaPSubMenu.Location = new Point(0, 137);
            panelTablaPSubMenu.Name = "panelTablaPSubMenu";
            panelTablaPSubMenu.Size = new Size(233, 195);
            panelTablaPSubMenu.TabIndex = 2;
            // 
            // btnMaterial
            // 
            btnMaterial.Dock = DockStyle.Top;
            btnMaterial.FlatAppearance.BorderSize = 0;
            btnMaterial.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnMaterial.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnMaterial.FlatStyle = FlatStyle.Flat;
            btnMaterial.ForeColor = Color.Silver;
            btnMaterial.Location = new Point(0, 127);
            btnMaterial.Name = "btnMaterial";
            btnMaterial.Padding = new Padding(35, 0, 0, 0);
            btnMaterial.Size = new Size(233, 32);
            btnMaterial.TabIndex = 3;
            btnMaterial.Text = "Material";
            btnMaterial.TextAlign = ContentAlignment.MiddleLeft;
            btnMaterial.UseVisualStyleBackColor = true;
            btnMaterial.Click += btnMaterial_Click;
            // 
            // btnTaller
            // 
            btnTaller.Dock = DockStyle.Top;
            btnTaller.FlatAppearance.BorderSize = 0;
            btnTaller.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnTaller.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnTaller.FlatStyle = FlatStyle.Flat;
            btnTaller.ForeColor = Color.Silver;
            btnTaller.Location = new Point(0, 87);
            btnTaller.Name = "btnTaller";
            btnTaller.Padding = new Padding(35, 0, 0, 0);
            btnTaller.Size = new Size(233, 40);
            btnTaller.TabIndex = 2;
            btnTaller.Text = "Almacen";
            btnTaller.TextAlign = ContentAlignment.MiddleLeft;
            btnTaller.UseVisualStyleBackColor = true;
            btnTaller.Click += btnTaller_Click;
            // 
            // btnProducto
            // 
            btnProducto.Dock = DockStyle.Top;
            btnProducto.FlatAppearance.BorderSize = 0;
            btnProducto.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnProducto.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnProducto.FlatStyle = FlatStyle.Flat;
            btnProducto.ForeColor = Color.Silver;
            btnProducto.Location = new Point(0, 47);
            btnProducto.Name = "btnProducto";
            btnProducto.Padding = new Padding(35, 0, 0, 0);
            btnProducto.Size = new Size(233, 40);
            btnProducto.TabIndex = 1;
            btnProducto.Text = "Producto";
            btnProducto.TextAlign = ContentAlignment.MiddleLeft;
            btnProducto.UseVisualStyleBackColor = true;
            btnProducto.Click += btnProducto_Click;
            // 
            // btnCiudad
            // 
            btnCiudad.Dock = DockStyle.Top;
            btnCiudad.FlatAppearance.BorderSize = 0;
            btnCiudad.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnCiudad.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnCiudad.FlatStyle = FlatStyle.Flat;
            btnCiudad.ForeColor = Color.Silver;
            btnCiudad.Location = new Point(0, 0);
            btnCiudad.Name = "btnCiudad";
            btnCiudad.Padding = new Padding(35, 0, 0, 0);
            btnCiudad.Size = new Size(233, 47);
            btnCiudad.TabIndex = 0;
            btnCiudad.Text = "Ciudad";
            btnCiudad.TextAlign = ContentAlignment.MiddleLeft;
            btnCiudad.UseVisualStyleBackColor = true;
            btnCiudad.Click += btnCiudad_Click;
            // 
            // btnCruds
            // 
            btnCruds.BackgroundImageLayout = ImageLayout.Zoom;
            btnCruds.Dock = DockStyle.Top;
            btnCruds.FlatAppearance.BorderSize = 0;
            btnCruds.FlatAppearance.MouseDownBackColor = Color.FromArgb(23, 21, 32);
            btnCruds.FlatAppearance.MouseOverBackColor = Color.FromArgb(24, 22, 34);
            btnCruds.FlatStyle = FlatStyle.Flat;
            btnCruds.ForeColor = Color.Silver;
            btnCruds.Image = (Image)resources.GetObject("btnCruds.Image");
            btnCruds.ImageAlign = ContentAlignment.MiddleLeft;
            btnCruds.Location = new Point(0, 92);
            btnCruds.Name = "btnCruds";
            btnCruds.Padding = new Padding(5, 0, 0, 0);
            btnCruds.Size = new Size(233, 45);
            btnCruds.TabIndex = 1;
            btnCruds.Text = "  Tablas Principales";
            btnCruds.TextAlign = ContentAlignment.MiddleLeft;
            btnCruds.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCruds.UseVisualStyleBackColor = true;
            btnCruds.Click += btnCruds_Click;
            // 
            // panelLogo
            // 
            panelLogo.Controls.Add(pictureBox1);
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(233, 92);
            panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(36, 15);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            pictureBox9.Anchor = AnchorStyles.None;
            pictureBox9.Image = (Image)resources.GetObject("pictureBox9.Image");
            pictureBox9.Location = new Point(296, 242);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(226, 218);
            pictureBox9.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox9.TabIndex = 2;
            pictureBox9.TabStop = false;
            // 
            // panelChildForm
            // 
            panelChildForm.BackColor = Color.FromArgb(32, 30, 45);
            panelChildForm.Controls.Add(pictureBox9);
            panelChildForm.Dock = DockStyle.Fill;
            panelChildForm.Location = new Point(250, 0);
            panelChildForm.Name = "panelChildForm";
            panelChildForm.Size = new Size(834, 711);
            panelChildForm.TabIndex = 2;
            // 
            // btnEmpresaTransporte
            // 
            btnEmpresaTransporte.Dock = DockStyle.Top;
            btnEmpresaTransporte.FlatAppearance.BorderSize = 0;
            btnEmpresaTransporte.FlatAppearance.MouseDownBackColor = Color.FromArgb(42, 38, 46);
            btnEmpresaTransporte.FlatAppearance.MouseOverBackColor = Color.FromArgb(42, 38, 46);
            btnEmpresaTransporte.FlatStyle = FlatStyle.Flat;
            btnEmpresaTransporte.ForeColor = Color.Silver;
            btnEmpresaTransporte.Location = new Point(0, 159);
            btnEmpresaTransporte.Name = "btnEmpresaTransporte";
            btnEmpresaTransporte.Padding = new Padding(35, 0, 0, 0);
            btnEmpresaTransporte.Size = new Size(233, 32);
            btnEmpresaTransporte.TabIndex = 4;
            btnEmpresaTransporte.Text = "Empresa de Transporte";
            btnEmpresaTransporte.TextAlign = ContentAlignment.MiddleLeft;
            btnEmpresaTransporte.UseVisualStyleBackColor = true;
            btnEmpresaTransporte.Click += btnEmpresaTransporte_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1084, 711);
            Controls.Add(panelChildForm);
            Controls.Add(panelSideMenu);
            Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MinimumSize = new Size(950, 600);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            panelSideMenu.ResumeLayout(false);
            panelTablaISubMenu.ResumeLayout(false);
            panelTablaPSubMenu.ResumeLayout(false);
            panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            panelChildForm.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelTablaPSubMenu;
        private System.Windows.Forms.Button btnMaterial;
        private System.Windows.Forms.Button btnTaller;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnCiudad;
        private System.Windows.Forms.Button btnCruds;
        private System.Windows.Forms.Button btnEqualizer;
        private System.Windows.Forms.Panel panelTablaISubMenu;
        private System.Windows.Forms.Button btnProductoMaterial;
        private System.Windows.Forms.Button btnDemanda;
        private System.Windows.Forms.Button btnCruds2;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Panel panelChildForm;
        private Button btnHelp;
        private Button button3;
        private Button btnCostoDeEnvio;
        private Button btnCapacidadEnvio;
        private Button btnEnvio;
        private Button btnEmpresaTransporte;
    }
}

