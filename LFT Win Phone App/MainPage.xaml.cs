﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace LFT_Win_Phone_App
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Leaders for Tomorrow (LFT) is a not for profit youth movement aimed at encouraging leadership in social change. \n\nWe work among the youth engaging them in social work and enhancing their leadership skills and personality.");
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(
        new Uri("//Registration.xaml", UriKind.Relative));
        }
    }
}