using Proyecto_Muebleria_y_Hogar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PlayerUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            panelTablaPSubMenu.Visible = false;
            panelTablaISubMenu.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void btnCruds_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTablaPSubMenu);
        }

        #region Tablas Principales
        private void btnCiudad_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCiudad());

            hideSubMenu();
        }

        private void btnProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new frmProducto());
            hideSubMenu();
        }

        private void btnTaller_Click(object sender, EventArgs e)
        {
            openChildForm(new frmAlmacen());
            hideSubMenu();
        }

        private void btnMaterial_Click(object sender, EventArgs e)
        {
            openChildForm(new frmMaterial());
            hideSubMenu();
        }
        #endregion

        private void btnCruds2_Click(object sender, EventArgs e)
        {
            showSubMenu(panelTablaISubMenu);
        }

        #region Tablas intermedias
        private void btnDemanda_Click(object sender, EventArgs e)
        {
            openChildForm(new frmDemanda());
            hideSubMenu();
        }

        private void btnProductoMaterial_Click(object sender, EventArgs e)
        {
            openChildForm(new frmUso());
            hideSubMenu();
        }


        #endregion



        private void btnEqualizer_Click(object sender, EventArgs e)
        {
            //openChildForm(new Form3());

            openChildForm(new frmResultado());
            hideSubMenu();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {

            hideSubMenu();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private Form activeForm = null;

        private void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCostoDeEnvio_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCostoEnvio());
            hideSubMenu();
        }

        private void btnCapacidadEnvio_Click(object sender, EventArgs e)
        {
            openChildForm(new frmCapacidadEnvio());
            hideSubMenu();
        }



        private void btnEnvio_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEnvio());
            hideSubMenu();
        }


        private void btnEmpresaTransporte_Click(object sender, EventArgs e)
        {
            openChildForm(new frmEmpresaTransporte());
            hideSubMenu();
        }
    }
}
