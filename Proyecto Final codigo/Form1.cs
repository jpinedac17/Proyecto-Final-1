using System.Net.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Data.SqlClient;
using ProyectoFinal1;

// Funciones
//Guardar en la base de datos


namespace ProyectoFinal1
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnBusqueda_Click(object sender, EventArgs e)
        {
            string prompt = txtPrompt.Text;

            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Bearer (API key aquí)");

                var body = new
                {
                    model = "mistralai/mistral-7b-instruct:free",
                    messages = new[]
                    {
                        new { role = "user", content = prompt}
                    }
                };

                string json = JsonConvert.SerializeObject(body);
                var content = new StringContent(json, Encoding.UTF8, "application/json");

                var response = await client.PostAsync("https://openrouter.ai/api/v1/chat/completions", content);
                string result = await response.Content.ReadAsStringAsync();

                dynamic respuesta = JsonConvert.DeserializeObject(result);
                txtResultado.Text = respuesta.choices[0].message.content;

                // Guardar en la base de datos
                Funciones.GuardarEnBD(prompt, txtResultado.Text);

                // Crear carpeta y crear archivos
                string rutaEscritorio = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string rutaCarpeta = Path.Combine(rutaEscritorio, "InvestigacionAI");

                if (!Directory.Exists(rutaCarpeta))
                {
                    Directory.CreateDirectory(rutaCarpeta);
                }

                string rutaWord = Path.Combine(rutaCarpeta, "Resultado.docx");
                string rutaPpt = Path.Combine(rutaCarpeta, "Resultado.pptx");

                Funciones.CrearDocumentoWord(txtResultado.Text, rutaWord);
                Funciones.CrearPresentacion(txtResultado.Text, rutaPpt);

            }
        }
    }
}
