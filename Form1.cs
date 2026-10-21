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
        List<string> codigos = new List<string>();
        List<string> dnis = new List<string>();
        List<string> nombres = new List<string>();
        List<string> tramites = new List<string>();
        List<string> areas = new List<string>();
        List<DateTime> fechas = new List<DateTime>();

        public Form1()
        {
            InitializeComponent();
            dgvExpedientes_CellContentClick(null, null);
            
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

        private void dgvExpedientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Limpiar columnas existentes
            dgvExpedientes.Columns.Clear();
            // Agregar columnas
            dgvExpedientes.Columns.Add("colCodigo", "Código");
            dgvExpedientes.Columns.Add("colDNI", "DNI");
            dgvExpedientes.Columns.Add("colNombre", "Ciudadano");
            dgvExpedientes.Columns.Add("colTramite", "Trámite");
            dgvExpedientes.Columns.Add("colArea", "Área asignada");
            dgvExpedientes.Columns.Add("colFecha", "Fecha de registro");
            // Ajustar columnas al tamaño de la tabla
            dgvExpedientes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            codigos.Add(txtCodigo.Text.Trim());
            dnis.Add(txtDNI.Text.Trim());
            nombres.Add(txtNombre.Text.Trim());
            tramites.Add(cboTramite.Text);
            areas.Add(txtArea.Text);
            fechas.Add(dtpFecha.Value.Date);

            // Mostrar en el DataGridView
            dgvExpedientes.Rows.Add(
                txtCodigo.Text.Trim(),
                txtDNI.Text.Trim(),
                txtNombre.Text.Trim(),
                cboTramite.Text,
                txtArea.Text,
                dtpFecha.Value.ToShortDateString()
            );

            MessageBox.Show("Expediente registrado correctamente");

            btnLimpiar.PerformClick();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string codigoBuscar = txtCodigo.Text.Trim();
            bool encontrado = false;

            if (codigoBuscar == "")
            {
                MessageBox.Show("Ingrese un código para buscar");
                return;
            }

            for (int i = 0; i < codigos.Count; i++)
            {
                if (codigos[i] == codigoBuscar)
                {
                    txtDNI.Text = dnis[i];
                    txtNombre.Text = nombres[i];
                    cboTramite.Text = tramites[i];
                    txtArea.Text = areas[i];
                    dtpFecha.Value = fechas[i];

                    encontrado = true;

                    MessageBox.Show("Expediente encontrado");
                    break;
                }
            }

            if (encontrado == false)
            {
                MessageBox.Show("Expediente no encontrado");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < codigos.Count; i++)
            {
                for (int j = i + 1; j < codigos.Count; j++)
                {
                    if (string.Compare(codigos[i], codigos[j]) > 0)
                    {
                        string ordenamiento = codigos[i];
                        codigos[i] = codigos[j];
                        codigos[j] = ordenamiento;

                        ordenamiento = dnis[i];
                        dnis[i] = dnis[j];
                        dnis[j] = ordenamiento;

                        ordenamiento = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = ordenamiento;

                        ordenamiento = tramites[i];
                        tramites[i] = tramites[j];
                        tramites[j] = ordenamiento;

                        ordenamiento = areas[i];
                        areas[i] = areas[j];
                        areas[j] = ordenamiento;

                        DateTime fechaAux = fechas[i];
                        fechas[i] = fechas[j];
                        fechas[j] = fechaAux;
                    }
                }
            }
            //actualizar la tabla después de ordenar las listas.
            dgvExpedientes.Rows.Clear();

            for (int i = 0; i < codigos.Count; i++)
            {
                dgvExpedientes.Rows.Add(
                    codigos[i], dnis[i], nombres[i],
                    tramites[i], areas[i],
                    fechas[i].ToShortDateString()
                );
            }

            MessageBox.Show("Expedientes ordenados");
        }
    }
}
