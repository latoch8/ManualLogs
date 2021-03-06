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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for Setings.xaml
    /// </summary>
    public partial class Setings : Window
    {
        public Setings(MainWindow main)
        {
            InitializeComponent();
            Main = main;
            Draw.DrawMainPanel(Tablica, 5, 4);
        }

        MainWindow Main;

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();        
        }

        private void Okno_Closed(object sender, EventArgs e)
        {
            Main.IsEnabled = true;
        }
    }
}
