using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;  
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataSerializers;

namespace GestorDatos
{
    public partial class Form1 : Form
    {
        private string rutaAdjunto = null;
        private string[,] estudiantesArray = new string[0, 0];

        private string[,] DataTableTo2DArray(System.Data.DataTable dt)
        {
            if (dt == null || dt.Columns.Count == 0) return new string[0, 0];
            int rows = dt.Rows.Count;
            int cols = dt.Columns.Count;
            var arr = new string[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    arr[i, j] = dt.Rows[i][j]?.ToString() ?? "";
            return arr;
        }

        private List<string[]> TwoDArrayToList(string[,] arr)
        {
            var list = new List<string[]>();
            if (arr == null || arr.Length == 0) return list;
            int rows = arr.GetLength(0), cols = arr.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                var row = new string[cols];
                for (int j = 0; j < cols; j++) row[j] = arr[i, j];
                list.Add(row);
            }
            return list;
        }

        public Form1()
        {
            InitializeComponent();
            btnCargar.Click += btnCargar_Click;
            btnGuardar.Click += btnGuardar_Click;
            btnBuscar.Click += btnBuscar_Click;
            btnAdjuntar.Click += btnAdjuntar_Click;
            btnEnviar.Click += btnEnviar_Click;
            dgvDatos.SelectionChanged += dgvDatos_SelectionChanged;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
                var ruta = openFileDialog1.FileName;
                var filas = CsvSerializer.LeerCsv(ruta);
                var dt = CsvSerializer.ToDataTable(filas);
                dgvDatos.DataSource = dt;
                Log($"Cargado {Path.GetFileName(ruta)} con {dt.Rows.Count} filas.");

                estudiantesArray = DataTableTo2DArray(dt);
            }
            catch (Exception ex)
            {
                Log("Error cargando CSV: " + ex.Message);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                var dt = dgvDatos.DataSource as DataTable;
                if (dt == null || dt.Rows.Count == 0) { Log("No hay datos para guardar."); return; }

                using (var sfd = new SaveFileDialog() { Filter = "CSV files|*.csv", FileName = "estudiantes_guardado.csv" })
                {
                    if (sfd.ShowDialog() != DialogResult.OK) return;
                    var filas = CsvSerializer.FromDataTable(dt);
                    CsvSerializer.GuardarCsv(sfd.FileName, filas);
                    Log("CSV guardado: " + sfd.FileName);
                }
            }
            catch (Exception ex)
            {
                Log("Error guardando CSV: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string nombre = txtBuscar.Text.Trim();
            if (string.IsNullOrEmpty(nombre)) { Log("Ingresa un nombre para buscar."); return; }

            foreach (DataGridViewRow row in dgvDatos.Rows)
            {
                if (row.IsNewRow) continue;
                if (string.Equals(GetCellValue(row, "Nombre"), nombre, StringComparison.OrdinalIgnoreCase))
                {
                    row.Selected = true;
                    dgvDatos.CurrentCell = row.Cells[0];
                    Log("Encontrado: " + nombre);
                    return;
                }
            }
            Log("No se encontró: " + nombre);
        }

        private void btnAdjuntar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;
            rutaAdjunto = openFileDialog1.FileName;
            Log("Adjunto seleccionado: " + rutaAdjunto);
        }

        private async void btnEnviar_Click(object sender, EventArgs e)
        {
            string destino = txtCorreo.Text.Trim();

            if (!EsEmailValido(destino) || !DominioPermitido(destino))
            {
                Log("Correo inválido o dominio no permitido.");
                MessageBox.Show("Correo inválido o dominio no permitido.");
                return;
            }

            string asunto = $"Ficha de {txtNombre.Text}";
            string cuerpo = $"Hola {txtNombre.Text},\n\nAdjunto encontrarás tu ficha.\n\nSaludos.";

            try
            {
                await Task.Run(() => EnviarCorreo(destino, asunto, cuerpo, rutaAdjunto));
                Log("Envío realizado.");
            }
            catch (Exception ex)
            {
                Log("Error envío: " + ex.Message);
            }
        }

        private void dgvDatos_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDatos.CurrentRow == null) return;

            var r = dgvDatos.CurrentRow;  
            txtNombre.Text = GetCellValue(r, "Nombre");
            txtEdad.Text = GetCellValue(r, "Edad");
            txtCorreo.Text = GetCellValue(r, "Correo");

            double suma = 0; int cuenta = 0;
            foreach (DataGridViewColumn col in dgvDatos.Columns)
            {
                if (col.Name.ToLower().Contains("nota"))
                {
                    var s = GetCellValue(r, col.Name);
                    if (double.TryParse(s, NumberStyles.Any, CultureInfo.InvariantCulture, out double val))
                    {
                        suma += val;
                        cuenta++;
                    }
                }
            }
            double promedio = cuenta > 0 ? suma / cuenta : 0;


            lblPromedio.Text = promedio.ToString("0.00");
            if (promedio >= 3.0)
            {
                lblEstado.Text = "Aprobado";
                pbEstado.Image = Properties.Resources.Aprobado;
            }
            else
            {
                lblEstado.Text = "Reprobado";
                pbEstado.Image = Properties.Resources.Reprobado;
            }

            Log($"Notas detectadas -> suma={suma}, cuenta={cuenta}, promedio={promedio}");
        }



        private void EnviarCorreo(string para, string asunto, string cuerpo, string rutaAdj)
        {
            string host = Environment.GetEnvironmentVariable("SMTP_HOST");
            int port = int.Parse(Environment.GetEnvironmentVariable("SMTP_PORT"));
            string user = Environment.GetEnvironmentVariable("SMTP_USER");
            string pass = Environment.GetEnvironmentVariable("SMTP_PASS");

            using (var msg = new MailMessage())
            {
                msg.From = new MailAddress(user);
                msg.To.Add(para);
                msg.Subject = asunto;
                msg.Body = cuerpo;

                if (!string.IsNullOrEmpty(rutaAdj) && File.Exists(rutaAdj))
                    msg.Attachments.Add(new Attachment(rutaAdj));

                using (var client = new SmtpClient(host, port))
                {
                    client.EnableSsl = true;
                    client.Credentials = new NetworkCredential(user, pass);
                    client.Send(msg);
                }
            }
        }

        private bool EsEmailValido(string email)
        {
            if (string.IsNullOrWhiteSpace(email)) return false;
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern, RegexOptions.IgnoreCase);
        }

        private bool DominioPermitido(string email)
        {
            if (string.IsNullOrWhiteSpace(email) || !email.Contains("@")) return false;
            var permitidos = new List<string> { "gmail.com", "outlook.com", "hotmail.com", "ejemplo.com" };
            var dominio = email.Split('@')[1].ToLower();
            return permitidos.Contains(dominio);
        }

        private string GetCellValue(DataGridViewRow r, string colName)
        {
            if (!dgvDatos.Columns.Contains(colName)) return "";
            var cell = r.Cells[colName];
            return cell?.Value?.ToString() ?? "";
        }

        private void Log(string msg)
        {
            if (lstLog.InvokeRequired) lstLog.Invoke(new Action(() => lstLog.Items.Add($"{DateTime.Now:HH:mm:ss} - {msg}")));
            else lstLog.Items.Add($"{DateTime.Now:HH:mm:ss} - {msg}");
        }

        private void dgvDatos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var confirm = MessageBox.Show(
                    "¿Seguro que deseas eliminar esta fila?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirm == DialogResult.Yes)
                {
                    dgvDatos.Rows.RemoveAt(e.RowIndex);
                    Log("Fila eliminada con doble clic.");
                }
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtRegNombre.Text.Trim();
            if (string.IsNullOrEmpty(nombre)) { MessageBox.Show("Ingrese el nombre."); return; }

            if (!int.TryParse(txtRegEdad.Text.Trim(), out int edad))
            {
                MessageBox.Show("Edad inválida."); return;
            }

            if (!double.TryParse(txtRegNota1.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double n1) ||
    !double.TryParse(txtRegNota2.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double n2) ||
    !double.TryParse(txtRegNota3.Text.Trim(), NumberStyles.Any, CultureInfo.InvariantCulture, out double n3))
            {
                MessageBox.Show("Notas inválidas."); return;
            }

            if (n1 < 0 || n1 > 5 || n2 < 0 || n2 > 5 || n3 < 0 || n3 > 5)
            {
                MessageBox.Show("Notas deben estar entre 0 y 5."); return;
            }

            string genero = rbRegMasculino.Checked ? "Masculino" : rbRegFemenino.Checked ? "Femenino" : "";
            string actividades = "";
            if (chkRegDeportes.Checked) actividades += "Deportes;";
            if (chkRegMusica.Checked) actividades += "Música;";
            if (chkRegArte.Checked) actividades += "Arte;";

            double promedio = Math.Round((n1 + n2 + n3) / 3.0, 2);
            string estado = promedio >= 3.0 ? "Aprobado" : "Reprobado";

            string correo = nombre.ToLower().Replace(" ", "") + "@ejemplo.com";

            var fila = new string[] {
                nombre, edad.ToString(), correo,
                n1.ToString("0.##"), n2.ToString("0.##"), n3.ToString("0.##"),
                promedio.ToString("0.##"), estado, genero, actividades
            };

            if (dgvDatos.DataSource is System.Data.DataTable dt)
            {
                var newRow = dt.NewRow();
                for (int c = 0; c < dt.Columns.Count && c < fila.Length; c++)
                    newRow[c] = fila[c];
                dt.Rows.Add(newRow);

                estudiantesArray = DataTableTo2DArray(dt);

                Log($"Estudiante registrado: {nombre} (Prom: {promedio})");

                pbEstado.Image = promedio >= 3.0 ? Properties.Resources.Aprobado : Properties.Resources.Reprobado;
            }
            else
            {
                MessageBox.Show("Primero carga un CSV con encabezados válidos.");
            }
        }
    }
}

