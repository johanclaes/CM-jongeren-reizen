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

namespace wpf.UserControls
{
    /// <summary>
    /// Interaction logic for BindiblePasswordBox.xaml
    /// </summary>
    public partial class BindiblePasswordBox : UserControl
    {
        public static readonly DependencyProperty PasswordProperty = DependencyProperty.Register("Password", typeof(string), typeof(BindiblePasswordBox));

        public string Password
        {
            get
            {
                return (string)GetValue(PasswordProperty);
            }
            set { SetValue(PasswordProperty, value); }
        }
        private void OnPasswordChanged(object sender, RoutedEventArgs e)
        {
            Password = txtPassword.Password;
        }
        public BindiblePasswordBox()
        {
            InitializeComponent();
            txtPassword.PasswordChanged += OnPasswordChanged;
        }
    }
}
