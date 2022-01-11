using Microsoft.Toolkit.Mvvm.ComponentModel;
using Microsoft.Toolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Superheroes
{
    class MainWindowVM : ObservableObject
    {

        public RelayCommand SiguienteHeroe { get; }

        public RelayCommand AnteriorHeroe { get; }

        private SuperHeroeService servicio;

        private List<Superheroe> lista;
        public MainWindowVM()
        {
            servicio = new SuperHeroeService();
            lista = servicio.GetSamples();
            SuperheroeActual = lista[0];
            PosicionActual = 1;
            TotalHeroes = lista.Count;

            SiguienteHeroe = new RelayCommand(Avanzar);
            AnteriorHeroe = new RelayCommand(Retroceder);
        }
        
        private Superheroe superheroeActual;

        public Superheroe SuperheroeActual
        {
            get { return superheroeActual; }
            set {
                SetProperty(ref superheroeActual, value);
            }
        }


       

        private int posicionActual;

        public int PosicionActual
        {
            get { return posicionActual; }
            set
            {
                SetProperty(ref posicionActual, value);
            }
        }




        private int totalHeroes;

        public int TotalHeroes
        {
            get { return totalHeroes; }
            set
            {
                SetProperty(ref totalHeroes, value);
            }
        }

       

        public void Avanzar()
        {
            if (PosicionActual < TotalHeroes)
            {
                PosicionActual++;
                SuperheroeActual = lista[PosicionActual - 1];
            }
        }

        public void Retroceder()
        {
            if (PosicionActual > 1)
            {
                PosicionActual--;
                SuperheroeActual = lista[PosicionActual - 1];
            }
        }
    

    }
}
