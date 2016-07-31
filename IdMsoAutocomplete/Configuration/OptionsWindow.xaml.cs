﻿using System;
using System.Linq;
using System.Windows;
using IdMsoAutocomplete.Configuration;

namespace IdMsoAutocomplete
{
    /// <summary>
    /// Interaction logic for OptionsWindow.xaml
    /// </summary>
    public partial class OptionsWindow : Window
    {
        public OptionsWindow(Options options)
        {
            InitializeComponent();

            DataContext = options;
            OfficeVersion.ItemsSource = Enum.GetValues(typeof(OfficeVersion)).Cast<OfficeVersion>();
            OfficeApplication.ItemsSource = Enum.GetValues(typeof(OfficeApplication)).Cast<OfficeApplication>();
        }

        private void BtnOk_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = true;
        }
    }
}
