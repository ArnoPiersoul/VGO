﻿using System;
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

        private void ConvertToCelsius(object sender, RoutedEventArgs e)
        {
            var val = double.Parse(Farenheit.Text);
            Celsius.Text = Convert.ToString((val - 32) * 5 / 9);
        }
        private void ConvertToFarenheit(object sender, RoutedEventArgs e)
        {
            var val = double.Parse(Celsius.Text);
            Farenheit.Text = Convert.ToString(val / 5 * 9 + 32);
        }
    }
}
