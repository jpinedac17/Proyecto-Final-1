using System;
using Microsoft.Data.SqlClient;

using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Drawing;
using DocumentFormat.OpenXml.Wordprocessing;


using Aspose.Slides;

using Word = DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Vml;

namespace ProyectoFinal1
{
    public static class Funciones
    {
        public static void GuardarEnBD(string prompt, string respuesta)
        {
            string connectionString = "Data Source=DESKTOP-DVB2F0D\\SQLEXPRESS;Initial Catalog=InvestigacionesAI;Integrated Security=True;TrustServerCertificate=true";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "INSERT INTO Investigaciones (Prompt, Respuesta) VALUES (@Prompt, @Respuesta)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Prompt", prompt);
                    command.Parameters.AddWithValue("@Respuesta", respuesta);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void CrearDocumentoWord(string contenido, string rutaArchivo)
        {
            // Crear el documento Word
            using (WordprocessingDocument wordDocument =
                WordprocessingDocument.Create(rutaArchivo, WordprocessingDocumentType.Document))
            {
                // Añadir la parte principal del documento
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                // Crear un párrafo con el contenido
                Word.Paragraph paragraph = body.AppendChild(new Word.Paragraph());
                Word.Run run = paragraph.AppendChild(new Word.Run());
                run.AppendChild(new Word.Text(contenido));

                // Guardar cambios
                mainPart.Document.Save();
            }
        }

        public static void CrearPresentacion(string contenido, string rutaArchivo)
        {
            using (Presentation pres = new Presentation())
            {
                ISlide slide = pres.Slides[0];
                slide.Shapes.AddAutoShape(ShapeType.Rectangle, 100, 100, 500, 100)
                    .TextFrame.Text = contenido;

                pres.Save(rutaArchivo, Aspose.Slides.Export.SaveFormat.Pptx);
            }
        }
    }
}
