using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Net;

namespace CurriculumPowerRanger
{
    public partial class UpdateCurriculumWindow : Form
    {
        private List<Persona> curriculums;
        private mainWindow window;
        private Persona persona;

        public UpdateCurriculumWindow(List<Persona> curriculums, Persona persona)
        {
            InitializeComponent();
           
            this.curriculums = curriculums;
            this.persona = persona;

            //Mostrar info en los campos
            PresentarInfo();
        }

        public void updateCurriculumInList(List<Persona> curriculums,Persona persona) 
        {

            if (!(nombreField.Text.Equals("") || apellidoField.Text.Equals("") || cedulaField.Text.Equals("") || cedulaField.Text.Equals("") || colorFavoritoField.Text.Equals("") || twitterField.Text.Equals("") || celularField.Text.Equals("") || telefonoField.Text.Equals("") || animalField.Text.Equals("") || direccionField.Text.Equals("") || enfermedadField.Text.Equals("") || vehiculoField.Text.Equals("") || vehiculoField.Text.Equals("") || trabajoField.Text.Equals("") || centroEstudioField.Text.Equals("") || comentarioField.Text.Equals("")))
            {

                curriculums.Remove(persona);

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
                try
                {
                    new WebClient().DownloadString("http://adamix.net/practica/?m=SOF-001&t=final&e=20131488&op=Se modifico un curriculum");
                }
                catch(WebException ex)
                {
                    MessageBox.Show("Hubo un problema con la conexion a internet");
                }
                

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
            updateCurriculumInList(curriculums,persona);

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
                        //Se limpian todos los campos
                        Limpiar();
                        curriculumStream.Close();
                    }catch(NullReferenceException ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
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


        public void PresentarInfo()
        {
            nombreField.Text = persona.Nombre;
            apellidoField.Text = persona.Apellido;
            cedulaField.Text = persona.Cedula;
            colorFavoritoField.Text = persona.ColorFavorito;
            twitterField.Text = persona.CuentaTwitter;
            celularField.Text = persona.Celular;
            telefonoField.Text = persona.Telefono;
            animalField.Text = persona.AnimalFavorito;
            direccionField.Text = persona.Direccion;
            enfermedadField.Text = persona.Enfermedad;
            vehiculoField.Text = persona.VehiculoFavorito;
            trabajoField.Text = persona.Trabajo;
            centroEstudioField.Text = persona.Estudia;
            comentarioField.Text = persona.Comentario;
            fechaNacimientoField.Value = persona.FechaNacimiento;
        }

        private void modificarButton_Click(object sender, EventArgs e)
        {
            guardarCurriculums(this.curriculums);
        }
    }
}
