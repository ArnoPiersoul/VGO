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

namespace TemperatureConverter
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ConvertFromFarenheit(object sender, RoutedEventArgs e)
        {
            var val = double.Parse(Farenheit.Text);
            celsiusTextbox.Text = Convert.ToString((val - 32) * 5 / 9);
            Kelvin.Text = Convert.ToString((val + 459.67) * 5 / 9);
        }
        private void ConvertFromCelsius(object sender, RoutedEventArgs e)
        {
            var val = double.Parse(celsiusTextbox.Text);
            Farenheit.Text = Convert.ToString(val / 5 * 9 + 32);
            Kelvin.Text = Convert.ToString(val + 273.15);
        }
        private void ConvertFromKelvin(object sender, RoutedEventArgs e)
        {
            var val = double.Parse(Kelvin.Text);
            Farenheit.Text = Convert.ToString(val * 9 / 5 - 459.67);
            celsiusTextbox.Text = Convert.ToString(val - 273.15);
        }

        private void SliderValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Kelvin.Text = Convert.ToString(Slider.Value);
            Farenheit.Text = Convert.ToString(Slider.Value * 9 / 5 - 459.67);
            celsiusTextbox.Text = Convert.ToString(Slider.Value - 273.15);
        }
    }
}
