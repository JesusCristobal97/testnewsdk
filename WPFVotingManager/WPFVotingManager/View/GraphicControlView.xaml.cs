using LiveCharts.Wpf;
using LiveCharts;
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
    /// Lógica de interacción para GraphicControlView.xaml
    /// </summary>
    public partial class GraphicControlView : Window
    {
        public GraphicControlView()
        {
            InitializeComponent();

            generateAleatorio();
        }

        public delegate void DataUpdatedEventHandler(object sender, DataUpdatedEventArgs e);
        public event DataUpdatedEventHandler DataUpdated;

        public void UpdateData(double newData)
        {
            DataUpdated?.Invoke(this, new DataUpdatedEventArgs(newData));
        }

        private void SomeMethodToUpdateData()
        {
            double newData = 5; // Aquí obtienes los nuevos datos
            UpdateData(newData);
        }

        public PieChart MyChart
        {
            get { return MyPieChart; }
        }

        public void generateAleatorio()
        {
            var collection = new SeriesCollection();
            for (int i = 0; i < 12; i++)
            {
                var random = new Random();

                var serie = new PieSeries
                {
                    Title = "Categoría " + (i + 1),
                    Values = new ChartValues<double> { random.Next(12) },
                    DataLabels = true
                };
                collection.Add(serie);

            }
            MyPieChart.Series = collection;
        }
    }

    // Clase para los argumentos del evento
    public class DataUpdatedEventArgs : EventArgs
    {
        public double NewData { get; private set; }

        public DataUpdatedEventArgs(double newData)
        {
            NewData = newData;
        }
    }
}
