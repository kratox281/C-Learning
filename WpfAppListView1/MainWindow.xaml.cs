using Newtonsoft.Json.Linq;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Windows;

namespace WpfAppListView1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
    public class Personaje
    {
        public string Nombre { get; set; }
        public string Puesto { get; set; }
        public string Foto { get; set; }
    }

    public class Personajes : ObservableCollection<Personaje>
    {
        public Personajes() : base()
        {
            #region otra forma
            /*
            //sería necesario eliminar el encabezado "personaje" del archivo .json
            string json = File.ReadAllText("Datos/personajes.json");
            var personajes = JsonConvert.DeserializeObject<List<Personaje>>(json);
            foreach (Personaje p in personajes)
            {
                this.Add(p);
            }
            */

            //con Linq 2 Json

            //JObject personajesJS = JObject.Parse(File.ReadAllText("Datos/personajes.json"));
            //var personajes = from p in personajesJS["personaje"]
            #endregion
            var personajes = from p in JObject.Parse(File.ReadAllText("Datos/personajes.json")).SelectToken("personaje")
                             select new Personaje
                             {
                                 Nombre = (String)p["nombre"],
                                 Puesto = (string)p["puesto"],
                                 Foto = (String)p["foto"]
                             };
            foreach (Personaje p in personajes) { this.Add(p); }
        }
    }
}
