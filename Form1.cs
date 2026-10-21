using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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
        string ruta = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Expedientes.csv");
        private void GuardarExcel()
        {
            using (StreamWriter archivo = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                archivo.WriteLine("Código;DNI;Ciudadano;Trámite;Área asignada;Fecha");

                for (int i = 0; i < codigos.Count; i++)
                {
                    archivo.WriteLine(
                        codigos[i] + ";" +
                        dnis[i] + ";" +
                        nombres[i] + ";" +
                        tramites[i] + ";" +
                        areas[i] + ";" +
                        fechas[i].ToString("dd/MM/yyyy")
                    );
                }
            }
        }

        private void CargarArchivo()
        {
            if (File.Exists(ruta))
            {
                using (StreamReader archivo = new StreamReader(ruta))
                {
                   
                    archivo.ReadLine();

                    while (!archivo.EndOfStream)
                    {
                        string linea = archivo.ReadLine();

                        if (string.IsNullOrWhiteSpace(linea))
                        {
                            continue;
                        }

                        string[] datos = linea.Split(';');

                        if (datos.Length == 6)
                        {
                            DateTime fecha;

                            if (DateTime.TryParseExact(
                                datos[5],
                                "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture,
                                System.Globalization.DateTimeStyles.None,
                                out fecha))
                            {
                                codigos.Add(datos[0]);
                                dnis.Add(datos[1]);
                                nombres.Add(datos[2]);
                                tramites.Add(datos[3]);areas.Add(datos[4]); fechas.Add(fecha);

                                dgvExpedientes.Rows.Add( datos[0], datos[1],datos[2],datos[3],
                                    datos[4],fecha.ToShortDateString()
                                );
                            }
                        }
                    }
                }
            }
        }

        private void ConfigurarTabla()
        {
            dgvExpedientes.Columns.Clear();

            dgvExpedientes.Columns.Add("colCodigo", "Código");
            dgvExpedientes.Columns.Add("colDNI", "DNI");
            dgvExpedientes.Columns.Add("colNombre", "Ciudadano");
            dgvExpedientes.Columns.Add("colTramite", "Trámite");
            dgvExpedientes.Columns.Add("colArea", "Área asignada");
            dgvExpedientes.Columns.Add("colFecha", "Fecha de registro");
        }
        public Form1()
        {
            InitializeComponent();
            ConfigurarTabla();
            
            cboTramite.Items.Add("Impuesto predial");
            cboTramite.Items.Add("Arbitrios municipales");
            cboTramite.Items.Add("Rectificacion de datos");

            cboTramite.DropDownStyle = ComboBoxStyle.DropDownList;
            dtpFecha.Value = DateTime.Today;

            CargarArchivo();
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
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (Validaciones.CamposCompletos(txtCodigo.Text,txtDNI.Text,txtNombre.Text,txtArea.Text) == false)
            {
                MessageBox.Show("Por favor, complete los campos vacios");
                return;
            }
            if (Validaciones.ValidarDNI(txtDNI.Text.Trim()) == false)
            {
                MessageBox.Show("El DNI debe contener exactamente 8 números");
                return;
            }
            if (Validaciones.CodigoRepetido(txtCodigo.Text.Trim(), codigos) == true)
            {
                MessageBox.Show("El codigo de expediente ya existe, ingrese otro codigo");
                return;
            }
            if (Validaciones.CorregirCaracter(txtCodigo.Text.Trim()) == false)
            {
                MessageBox.Show("El codigo no puede contener caracteres especiales");
                return;
            }
            codigos.Add(txtCodigo.Text.Trim());
            dnis.Add(txtDNI.Text.Trim());
            nombres.Add(txtNombre.Text.Trim());
            tramites.Add(cboTramite.Text);
            areas.Add(txtArea.Text);
            fechas.Add(dtpFecha.Value.Date);

          
            dgvExpedientes.Rows.Add(
                txtCodigo.Text.Trim(),
                txtDNI.Text.Trim(),
                txtNombre.Text.Trim(),
                cboTramite.Text,
                txtArea.Text,
                dtpFecha.Value.ToShortDateString()
            );
            GuardarExcel();
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
