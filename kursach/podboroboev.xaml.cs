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

namespace kursach
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class podboroboev : Window
    {
        public podboroboev()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {   
            MainWindow taskWindow = new MainWindow();
            taskWindow.Show();
            Close();    
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            kuhni taskWindow = new kuhni();
            taskWindow.Show();
            Close();
        }
    }   
}
