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

namespace starnuti_trenink
{
    /// <summary>
    /// Interakční logika pro MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Clovek StarnouciClovek;

        public MainWindow()
        {
            InitializeComponent();
            StarnouciClovek = new Clovek();
        }

        private void tlacitkoStarnuti_Click(object sender, RoutedEventArgs e)
        {
            StarnouciClovek.Starnout();
            vypisVeku.Text = StarnouciClovek.Stari.ToString();

            if (StarnouciClovek.Stari > 100)
            {
                vypisVeku.Text = "Zřejmě mrtvý";
            }
        }
    }
}
