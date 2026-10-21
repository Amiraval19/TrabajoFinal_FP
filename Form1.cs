using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal_FP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            cboTramite.Items.Add("Impuesto predial");
            cboTramite.Items.Add("Arbitrios municipales");
            cboTramite.Items.Add("Rectificacion de datos");

            cboTramite.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpFecha.Value = DateTime.Today;
        }

        private void cboTramite_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboTramite.Text == "Impuesto predial")
            {
                txtArea.Text = "Area de impuesto predial";
            }
            else if (cboTramite.Text == "Arbitrios municipales")
            {
                txtArea.Text = "Area de arbitrios";
            }
            else if (cboTramite.Text == "Rectificacion de datos")
            {
                txtArea.Text = "Area de registro";
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = "";
            txtDNI.Text = "";
            txtNombre.Text = "";
            txtArea.Text = "";
            cboTramite.Text = "";
            txtCodigo.Focus();
        }
    }
}
