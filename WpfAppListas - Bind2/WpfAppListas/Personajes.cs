using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfAppListas
{
   public class Personajes : ObservableCollection<Personaje> // List<Personaje>
    {
        public event EventHandler ColeccionVacia;
        public Personajes() : base() //Crea la instancia de la colección Personajes
        {
            this.Add(new Personaje() { Nombre = "Vicente del Bosque", Foto = "Imagenes/DelBosque.png" });
            this.Add(new Personaje() { Nombre = "Fernando Torres", Foto = "Imagenes/FernandoT.png" });
            this.Add(new Personaje() { Nombre = "Sergio Ramos", Foto = "Imagenes/SergioR.png" });
            this.Add(new Personaje() { Nombre = "Xavi Hernández", Foto = "Imagenes/XaviH.png" });
        }
        protected override void RemoveItem(int index)
        {
            base.RemoveItem(index);
            if (this.Items.Count==0) ColeccionVacia?.Invoke(this, new EventArgs());
        }
    }
}
