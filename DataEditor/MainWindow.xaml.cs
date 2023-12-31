﻿using DataEditor.Controllers;
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

namespace DataEditor
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

           list1.ItemsSource = GenerationController.SendDocNames();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            list1.ItemsSource = GenerationController.SendDocuments();
        }

        private void list1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            GenerationController.GetSingleDocument(lbl1,lblType, lblValue, list1.SelectedItem.ToString());
        }
    }
}
