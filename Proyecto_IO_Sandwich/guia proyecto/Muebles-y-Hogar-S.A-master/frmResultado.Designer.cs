namespace Proyecto_Muebleria_y_Hogar
{
    partial class frmResultado
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnLoadExcel = new Button();
            btnModifyExcel = new Button();
            btnRunLingo = new Button();
            btnClose = new Button();
            label1 = new Label();
            dataGridViewExcel = new DataGridView();
            dataGridViewResultados = new DataGridView();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewExcel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).BeginInit();
            SuspendLayout();
            // 
            // btnLoadExcel
            // 
            btnLoadExcel.Location = new Point(30, 51);
            btnLoadExcel.Name = "btnLoadExcel";
            btnLoadExcel.Size = new Size(97, 34);
            btnLoadExcel.TabIndex = 0;
            btnLoadExcel.Text = "Cargar Excel";
            btnLoadExcel.UseVisualStyleBackColor = true;
            btnLoadExcel.Click += btnLoadExcel_Click;
            // 
            // btnModifyExcel
            // 
            btnModifyExcel.Location = new Point(283, 51);
            btnModifyExcel.Name = "btnModifyExcel";
            btnModifyExcel.Size = new Size(97, 35);
            btnModifyExcel.TabIndex = 1;
            btnModifyExcel.Text = "Modificar Excel";
            btnModifyExcel.UseVisualStyleBackColor = true;
            btnModifyExcel.Click += btnModifyExcel_Click;
            // 
            // btnRunLingo
            // 
            btnRunLingo.Location = new Point(603, 53);
            btnRunLingo.Name = "btnRunLingo";
            btnRunLingo.Size = new Size(97, 33);
            btnRunLingo.TabIndex = 2;
            btnRunLingo.Text = "Ejecutar LINGO";
            btnRunLingo.UseVisualStyleBackColor = true;
            btnRunLingo.Click += btnRunLingo_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(375, 352);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(97, 41);
            btnClose.TabIndex = 3;
            btnClose.Text = "Cerrar";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(30, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 25);
            label1.TabIndex = 4;
            label1.Text = "Empresa Mueblería y Hogar S.A";
            // 
            // dataGridViewExcel
            // 
            dataGridViewExcel.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewExcel.Location = new Point(30, 91);
            dataGridViewExcel.Name = "dataGridViewExcel";
            dataGridViewExcel.Size = new Size(350, 241);
            dataGridViewExcel.TabIndex = 5;
            // 
            // dataGridViewResultados
            // 
            dataGridViewResultados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResultados.Location = new Point(459, 91);
            dataGridViewResultados.Name = "dataGridViewResultados";
            dataGridViewResultados.Size = new Size(358, 241);
            dataGridViewResultados.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(329, 15);
            label2.Name = "label2";
            label2.Size = new Size(272, 17);
            label2.TabIndex = 7;
            label2.Text = "Muebles y artículos, de todo para tu hogar!";
            // 
            // frmResultado
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(888, 420);
            Controls.Add(label2);
            Controls.Add(dataGridViewResultados);
            Controls.Add(dataGridViewExcel);
            Controls.Add(label1);
            Controls.Add(btnClose);
            Controls.Add(btnRunLingo);
            Controls.Add(btnModifyExcel);
            Controls.Add(btnLoadExcel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "frmResultado";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewExcel).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResultados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLoadExcel;
        private Button btnModifyExcel;
        private Button btnRunLingo;
        private Button btnClose;
        private Label label1;
        private DataGridView dataGridViewExcel;
        private DataGridView dataGridViewResultados;
        private Label label2;
    }
}
