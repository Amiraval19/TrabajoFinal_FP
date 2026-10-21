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
        ListaExpedientes datos = new ListaExpedientes();
        string ruta = Path.Combine(
        Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "Expedientes.csv");
        private void GuardarExcel()
        {
            using (StreamWriter archivo = new StreamWriter(ruta, false, Encoding.UTF8))
            {
                archivo.WriteLine("Código;DNI;Ciudadano;Trámite;Área asignada;Fecha");

                for (int i = 0; i < datos.codigos.Count; i++)
                {
                    archivo.WriteLine(
                        datos.codigos[i] + ";" +
                        datos.dnis[i] + ";" +
                        datos.nombres[i] + ";" +
                        datos.tramites[i] + ";" +
                        datos.areas[i] + ";" +
                        datos.fechas[i].ToString("dd/MM/yyyy")
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

                        string[] campos = linea.Split(';');

                        if (campos.Length == 6)
                        {
                            DateTime fecha;

                            if (DateTime.TryParseExact(
                                campos[5],
                                "dd/MM/yyyy",
                                System.Globalization.CultureInfo.InvariantCulture,
                                System.Globalization.DateTimeStyles.None,
                                out fecha))
                            {
                                datos.codigos.Add(campos[0]);
                                datos.dnis.Add(campos[1]);
                                datos.nombres.Add(campos[2]);
                                datos.tramites.Add(campos[3]);
                                datos.areas.Add(campos[4]);
                                datos.fechas.Add(fecha);

                                dgvExpedientes.Rows.Add( campos[0], campos[1],campos[2],campos[3],
                                    campos[4],fecha.ToShortDateString()
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
            if (Validaciones.CodigoRepetido(txtCodigo.Text.Trim(), datos.codigos) == true)
            {
                MessageBox.Show("El codigo de expediente ya existe, ingrese otro codigo");
                return;
            }
            if (Validaciones.CorregirCaracter(txtCodigo.Text.Trim()) == false)
            {
                MessageBox.Show("El codigo no puede contener caracteres especiales");
                return;
            }
            datos.codigos.Add(txtCodigo.Text.Trim());
            datos.dnis.Add(txtDNI.Text.Trim());
            datos.nombres.Add(txtNombre.Text.Trim());
            datos.tramites.Add(cboTramite.Text);
            datos.areas.Add(txtArea.Text);
            datos.fechas.Add(dtpFecha.Value.Date);

          
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

            for (int i = 0; i < datos.codigos.Count; i++)
            {
                if (datos.codigos[i] == codigoBuscar)
                {
                    txtDNI.Text = datos.dnis[i];
                    txtNombre.Text = datos.nombres[i];
                    cboTramite.Text = datos.tramites[i];
                    txtArea.Text = datos.areas[i];
                    dtpFecha.Value = datos.fechas[i];

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
            for (int i = 0; i < datos.codigos.Count; i++)
            {
                for (int j = i + 1; j < datos.codigos.Count; j++)
                {
                    if (string.Compare(datos.codigos[i], datos.codigos[j]) > 0)
                    {
                        string ordenamiento = datos.codigos[i];
                        datos.codigos[i] = datos.codigos[j];
                        datos.codigos[j] = ordenamiento;

                        ordenamiento = datos.dnis[i];
                        datos.dnis[i] = datos.dnis[j];
                        datos.dnis[j] = ordenamiento;

                        ordenamiento = datos.nombres[i];
                        datos.nombres[i] = datos.nombres[j];
                        datos.nombres[j] = ordenamiento;

                        ordenamiento = datos.tramites[i];
                        datos.tramites[i] = datos.tramites[j];
                        datos.tramites[j] = ordenamiento;

                        ordenamiento = datos.areas[i];
                        datos.areas[i] = datos.areas[j];
                        datos.areas[j] = ordenamiento;

                        DateTime fechaAux = datos.fechas[i];
                        datos.fechas[i] = datos.fechas[j];
                        datos.fechas[j] = fechaAux;
                    }
                }
            }
       
            dgvExpedientes.Rows.Clear();

            for (int i = 0; i < datos.codigos.Count; i++)
            {
                dgvExpedientes.Rows.Add(
                    datos.codigos[i], datos.dnis[i], datos.nombres[i],
                    datos.tramites[i], datos.areas[i],
                    datos.fechas[i].ToShortDateString()
                );
            }

            MessageBox.Show("Expedientes ordenados");
        }
    }
}
