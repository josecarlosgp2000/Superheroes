using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Superheroes
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int heroeActual = 0;
        List<Superheroe> listaSuperHeroes = Superheroe.GetSamples();
        public MainWindow()
        {
            InitializeComponent();
            portadaDockPanel.DataContext = listaSuperHeroes[heroeActual];
        }

        private void CambiarPersoanje_Image(object sender, MouseButtonEventArgs e)
        {
            Image imagen = (Image)sender;

            switch (imagen.Tag.ToString())
            {
                case "avanzar":
                    if (heroeActual + 1 < listaSuperHeroes.Count)
                    {
                        heroeActual++;
                        portadaDockPanel.DataContext = listaSuperHeroes[heroeActual];
                        contadorHeroe.Text = heroeActual + 1 + "/3";
                    }
                    break;

                case "retroceder":
                    if (heroeActual - 1 >= 0)
                    {
                        heroeActual--;
                        portadaDockPanel.DataContext = listaSuperHeroes[heroeActual];
                        contadorHeroe.Text = heroeActual + 1 + "/3";
                    }
                    break;
            }
        }
    }
}
