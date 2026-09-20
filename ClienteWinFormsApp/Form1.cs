using System.Net.Http;
using System.Net.Http.Json;

namespace ClienteWinFormsApp
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient = new HttpClient();

        public Form1()
        {
            InitializeComponent();
        }

        private async Task CargarEstudiantes()
        {
            try
            {
                string url = "https://localhost:7107/api/Estudiantes";

                var estudiantes = await httpClient.GetFromJsonAsync<List<Estudiante>>(url);

                dgvEstudiantes.DataSource = estudiantes;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los estudiantes: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvEstudiantes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private async void btnCargar_Click(object sender, EventArgs e)
        {
            await CargarEstudiantes();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            var estudiante = new Estudiante
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Matricula = txtMatricula.Text,
                FechaNacimiento = dtpFechaNacimiento.Value,
                FechaIngreso = dtpFechaIngreso.Value,
                Carrera = txtCarrera.Text,
                Correo = txtCorreo.Text,
                Telefono = txtTelefono.Text
            };
            try
            {
                string url = "https://localhost:7107/api/Estudiantes";

                var respuesta = await httpClient.PostAsJsonAsync(url, estudiante);

                if (respuesta.IsSuccessStatusCode)
                {
                    MessageBox.Show("Estudiante guardado correctamente.");

                    await CargarEstudiantes();

                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtMatricula.Clear();
                    txtCarrera.Clear();
                    txtCorreo.Clear();
                    txtTelefono.Clear();
                }
                else
                {
                    MessageBox.Show("Error al guardar el estudiante.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
