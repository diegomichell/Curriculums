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
    public partial class mainWindow : Form
    {
        List<Persona> curriculums;
        BindingSource binding;
        String[] horoscopo = { "http://www.pandora-magazine.com/wp-content/uploads/2013/04/Aries0001.jpg", "http://www.pandora-magazine.com/wp-content/uploads/2013/05/Tauro.jpg", "http://www.pandora-magazine.com/wp-content/uploads/2013/05/geminis.jpg", "http://cupon.com.co/revista/wp-content/uploads/2013/06/cncer-12.jpeg", "http://www.pandora-magazine.com/wp-content/uploads/2013/07/Leo0002.jpg", "http://www.pandora-magazine.com/wp-content/uploads/2013/07/www_femenino_info_wp-content_uploads_Virgo-y-el-amor-en-Octubre.jpg", "http://www.pandora-magazine.com/wp-content/uploads/2013/08/00Libra.jpg", "http://24con.infonews.com/files/image/117/117791/51893ee9750a9.jpg", "http://www.pandora-magazine.com/wp-content/uploads/2014/02/sagitario.jpg", " http://www.pandora-magazine.com/wp-content/uploads/2014/02/capricornio.jpg", "http://img4.wikia.nocookie.net/__cb20120216062431/saintseiya/es/images/2/27/Signo_Acuario.jpg", "http://3.bp.blogspot.com/-6WUuhtEMkos/UYBOISev06I/AAAAAAAAAvg/21mOMIE9vSM/s1600/Piscis1.jpg" };

        public mainWindow()
        {
            InitializeComponent();
 
            try
            {
                curriculums = obtenerCurriculums();
            }
            catch (FileNotFoundException ex)
            {
                curriculums = new List<Persona>();
            }
            //Se llena la tabla
            popularTabla(curriculums);
        }

        public void popularTabla(List<Persona> curriculums)
        {
            binding = new BindingSource();
            binding.DataSource = curriculums;
            tableView.DataSource = binding;
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acercaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.Visible = true;
            
        }

        private void agregarCurriculumEvent(object sender, EventArgs e)
        {
            AddCurriculumWindow addDialog = new AddCurriculumWindow(curriculums);
            addDialog.vigilarTabla(this);
            addDialog.Visible = true;
        }

        public List<Persona> obtenerCurriculums()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
            FileStream curriculumStream = new FileStream("Curriculums.xml", FileMode.Open);
            return (List<Persona>)serializer.Deserialize(curriculumStream);
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                tableView.Rows.Remove(tableView.SelectedRows[0]);
                guardarCurriculums(curriculums);
                try
                {
                    new WebClient().DownloadString("http://adamix.net/practica/?m=SOF-001&t=final&e=20131488&op=Se borro un curriculum");
                }
                catch (WebException ex)
                {
                    MessageBox.Show("Hubo un problema con la conexion a internet");
                }
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show("Debe seleccionar las filas en el area de indice");
            }
            catch (InvalidOperationException ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show("Esa operacion no es valida, debe seleccionar una de las filas");
            }
        }

        public void guardarCurriculums(List<Persona> curriculums)
        {

            XmlSerializer serializer = new XmlSerializer(typeof(List<Persona>));
            StreamWriter curriculumStream = null;
            try
            {
                curriculumStream = new StreamWriter("Curriculums.xml");
                serializer.Serialize(curriculumStream, curriculums);
            }
            catch (IOException ex)
            {
                Console.Error.WriteLine(ex.Message);
            }
            finally
            {
                if (curriculums != null)
                    try
                    {
                        curriculumStream.Close();
                    }
                    catch (NullReferenceException ex)
                    {
                        Console.Error.WriteLine(ex.Message);
                    }
            }

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            { 
                UpdateCurriculumWindow update = new UpdateCurriculumWindow(curriculums, curriculums[tableView.SelectedRows[0].Index]);
                update.vigilarTabla(this);
                update.Visible = true;
            }
            catch(ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show("Debe seleccionar una fila a la cual quiera modificar modificar, en la columna de los indices");
            }
        }

        private void Exportar_Event(object sender, EventArgs e)
        {

            try
            {
                Persona curriculum = curriculums[tableView.SelectedRows[0].Index];
                Console.WriteLine(curriculum.FechaNacimiento.Month.ToString());

                string signoZodiaco = "";

                switch(curriculum.FechaNacimiento.Month)
                {
                    case 1:
                        if (curriculum.FechaNacimiento.Day >= 21)
                            signoZodiaco = horoscopo[10];
                        else
                            signoZodiaco = horoscopo[9];
                        break;
                    case 2:
                        if (curriculum.FechaNacimiento.Day >= 21)
                            signoZodiaco = horoscopo[11];
                        else
                            signoZodiaco = horoscopo[10];
                        break;
                    case 3:
                         if (curriculum.FechaNacimiento.Day >= 21)
                            signoZodiaco = horoscopo[0];
                        else
                            signoZodiaco = horoscopo[11];
                        break;
                    case 4:
                        if (curriculum.FechaNacimiento.Day >= 21)
                            signoZodiaco = horoscopo[1];
                        else
                            signoZodiaco = horoscopo[0];
                        break;
                    case 5:
                        if (curriculum.FechaNacimiento.Day >= 22)
                            signoZodiaco = horoscopo[2];
                        else
                            signoZodiaco = horoscopo[1];
                        break;
                    case 6:
                        if (curriculum.FechaNacimiento.Day >= 22)
                            signoZodiaco = horoscopo[3];
                        else
                            signoZodiaco = horoscopo[2];
                        break;
                    case 7:
                        if (curriculum.FechaNacimiento.Day >= 23)
                            signoZodiaco = horoscopo[4];
                        else
                            signoZodiaco = horoscopo[3];
                        break;
                    case 8:
                        if (curriculum.FechaNacimiento.Day >= 23)
                            signoZodiaco = horoscopo[5];
                        else
                            signoZodiaco = horoscopo[4];
                        break;
                    case 9:
                        if (curriculum.FechaNacimiento.Day >= 23)
                            signoZodiaco = horoscopo[6];
                        else
                            signoZodiaco = horoscopo[5];
                        break;
                    case 10:
                        if (curriculum.FechaNacimiento.Day >= 23)
                            signoZodiaco = horoscopo[7];
                        else
                            signoZodiaco = horoscopo[6];
                        break;
                    case 11:
                        if (curriculum.FechaNacimiento.Day >= 23)
                            signoZodiaco = horoscopo[8];
                        else
                            signoZodiaco = horoscopo[7];
                        break;
                    case 12:
                        if (curriculum.FechaNacimiento.Day >= 22)
                            signoZodiaco = horoscopo[9];
                        else
                            signoZodiaco = horoscopo[8];
                        break;
                }

                string html = "<!DOCTYPE html><html><head><title>" + curriculum.Nombre + "</title><style>*{font-family: Segoe UI;}span{font-size: 22px;color: #1B1B1B;text-align: justify;padding: 1px;}header{width:100%;background: DeepSkyBlue;border: 1px solid #fff;border-radius:10px;}section div label{font-size: 25px;width: 250px;display: inline-block;margin: 5px 0 5px 15px;}h1{text-align: center;color: white;}section{margin-top: 15px;}section div {width: 100%;background-color: white;border-radius: 15px;}body{background: red;}section div div {width: 300px;height: 100px;max-width: 300px;border-radius:5px;text-align: justify;border:1px solid green;overflow:auto;display: inline-block;}img {height: 200px;width: 300px;display: block;margin: auto;}</style></head><body><header><h1>" + curriculum.Nombre + "</h1><img src=\"" + signoZodiaco + "\"/></header><section><div><label>Cedula:</label><span>" + curriculum.Cedula + "</span><br/><label>Nombre:</label><span>" + curriculum.Nombre + "</span><br/><label>Apellido:</label><span>" + curriculum.Apellido + "</span><br/><label>Fecha Nacimiento:</label><span>" + curriculum.FechaNacimiento.ToString("MMMM dd, yyyy") + "</span><br/><label>Color Favorito:</label><span>" + curriculum.ColorFavorito + "</span><br/><label>Cuenta Twitter:</label><span>" + curriculum.CuentaTwitter + "</span><br/><label>Celular:</label><span>" + curriculum.Celular + "</span><br/><label>Telefono:</label><span>" + curriculum.Telefono + "</span><br/><label>Animal Favorito:</label><span>" + curriculum.AnimalFavorito + "</span><br/><label>Direccion:</label><span>" + curriculum.Direccion + "</span><br/><label>Enfermedad:</label><span>" + curriculum.Enfermedad + "</span><br/><label>Vehiculo Favorito:</label><span>" + curriculum.VehiculoFavorito + "</span><br/><label>Trabajo:</label><span>" + curriculum.Trabajo + "</span><br/><label>Centro Estudio:</label><span>" + curriculum.Estudia + "</span><br/><label>Comentario:</label><div>" + curriculum.Comentario + "</div></div></section></body></html>";
                
                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Documento HTML | *.html";

                if (saveDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        writer.Write(html);
                        //Peticion, Avisar que se exporto un item.
                        try
                        { 
                        new WebClient().DownloadString("http://adamix.net/practica/?m=SOF-001&t=final&e=20131488&op=Se exporto un curriculum");
                        }
                        catch (WebException ex)
                        {
                            MessageBox.Show("Hubo un problema con la conexion a internet");
                        }
                    }
                }

            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.Error.WriteLine(ex.Message);
                MessageBox.Show("Debe seleccionar una fila a la cual quiera modificar modificar, en la columna de los indices");
            }

           
        }

    }
}
