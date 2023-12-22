using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WPFVotingManager.View
{
    /// <summary>
    /// Lógica de interacción para MenuControlView.xaml
    /// </summary>
    public partial class MenuControlView : Window
    {
        public MenuControlView()
        {
            InitializeComponent();
        }

        private void Screen_Basic_Click(object sender, RoutedEventArgs e)
        {
            ContenidoFrame.Content = new ConfigControlView(); // Asume que Pantalla2 es una clase UserControl
        }
        private void Screen_Question_Click(object sender, RoutedEventArgs e)
        {
            ContenidoFrame.Content = new QuestionControlView(); // Asume que Pantalla2 es una clase UserControl
        }
        private void Screen_Graphic_Click(object sender, RoutedEventArgs e)
        {
            ContenidoFrame.Content = new GraphicCreationControlView(); // Asume que Pantalla2 es una clase UserControl
        }
        private void Screen_Participant_Click(object sender, RoutedEventArgs e)
        {
            ContenidoFrame.Content = new ParticipantControlView(); // Asume que Pantalla2 es una clase UserControl
        }
        private void Pantalla_Votation_Click(object sender, RoutedEventArgs e)
        {
            ContenidoFrame.Content = new VotationControlView(); // Asume que Pantalla2 es una clase UserControl
        }

        private void Pantalla_Graphic_Click(object sender, RoutedEventArgs e)
        {
            var ventanaSecundaria = new GraphicControlView(); // Asume que tienes una clase VentanaSecundaria
            ventanaSecundaria.Show(); // Asume que Pantalla2 es una clase UserControl
        }
    }
}
