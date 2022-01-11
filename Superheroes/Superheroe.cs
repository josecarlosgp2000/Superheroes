using System.Collections.Generic;
using System.ComponentModel;

namespace Superheroes
{
    class Superheroe : INotifyPropertyChanged
    {
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public bool Vengador { get; set; }
        public bool Xmen { get; set; }
        public bool Heroe { get; set; }

        public Superheroe()
        {
        }

        public Superheroe(string nombre, string imagen, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            Imagen = imagen;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanger(string propertyName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }
}