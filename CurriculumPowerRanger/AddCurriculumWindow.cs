using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Net;

namespace CurriculumPowerRanger
{
    public partial class AddCurriculumWindow : Form
    {
        private List<Persona> curriculums;
        private mainWindow window;

        public AddCurriculumWindow(List<Persona> curriculums)
        {
            InitializeComponent();
            this.curriculums = curriculums;
        }

        public void addCurriculumToList(List<Persona> curriculums) 
        {

            if (!(nombreField.Text.Equals("") || apellidoField.Text.Equals("") || cedulaField.Text.Equals("") || cedulaField.Text.Equals("") || colorFavoritoField.Text.Equals("") || twitterField.Text.Equals("") || celularField.Text.Equals("") || telefonoField.Text.Equals("") || animalField.Text.Equals("") || direccionField.Text.Equals("") || enfermedadField.Text.Equals("") || vehiculoField.Text.Equals("") || vehiculoField.Text.Equals("") || trabajoField.Text.Equals("") || centroEstudioField.Text.Equals("") || comentarioField.Text.Equals("")))
            {
                Persona persona = new Persona();

                persona.Nombre = nombreField.Text;
                persona.Apellido = apellidoField.Text;
                persona.Cedula = cedulaField.Text;
                persona.ColorFavorito = colorFavoritoField.Text;
                persona.CuentaTwitter = twitterField.Text;
                persona.Celular = celularField.Text;
                persona.Telefono = telefonoField.Text;
                persona.AnimalFavorito = animalField.Text;
                persona.Direccion = direccionField.Text;
                persona.Enfermedad = enfermedadField.Text;
                persona.VehiculoFavorito = vehiculoField.Text;
                persona.Trabajo = trabajoField.Text;
                persona.Estudia = centroEstudioField.Text;
                persona.Comentario = comentarioField.Text;
                //Obtiene la fecha
                persona.FechaNacimiento = fechaNacimientoField.Value;

                curriculums.Add(persona);

                window.popularTabla(curriculums);
                this.Dispose();
            }
            else
            {
                messageLabel.Visible = true;
                Timer time = new Timer();
                time.Interval = 3000;
                time.Start();
                //Add evento
                time.Tick += new EventHandler(TimerEventProcessor);
               
            }

        }

         private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
         {
             messageLabel.Visible = false;
         }

        public void guardarCurriculums(List<Persona> curriculums)
        {
            addCurriculumToList(curriculums);

            XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
            StreamWriter curriculumStream = null;
            try
            {   
                curriculumStream = new StreamWriter("Curriculums.xml");
                serializer.Serialize(curriculumStream, curriculums);
             }
            catch(IOException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                if(curriculums != null)
                    try {
                        curriculumStream.Close();
                    }catch(NullReferenceException ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
            }
            
        }

        private void agregarButton_Click(object sender, EventArgs e)
        {
            guardarCurriculums(this.curriculums);

            try 
            { 
                new WebClient().DownloadString("http://adamix.net/practica/?m=SOF-001&t=final&e=20131488&op=Se agrego un curriculum");
            }
            catch (WebException ex)
            {
                MessageBox.Show("Hubo un problema con la conexion a internet");
            }
        }

        public void vigilarTabla(mainWindow window)
        {
            this.window = window;
        }

        public void Limpiar()
        {
            nombreField.Clear();
            apellidoField.Clear();
            cedulaField.Clear();
            colorFavoritoField.Clear();
            twitterField.Clear();
            celularField.Clear();
            telefonoField.Clear();
            animalField.Clear();
            direccionField.Clear();
            enfermedadField.Clear();
            vehiculoField.Clear();
            trabajoField.Clear();
            centroEstudioField.Clear();
            comentarioField.Clear();
        }
    }
}
