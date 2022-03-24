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
using WSRDemo.models;

namespace WSRDemo
{
    /// <summary>
    /// Логика взаимодействия для ListClients.xaml
    /// </summary>
    public partial class ListClients : Window
    {
        public ListClients()
        {
            var Clinets = new List<Client>() {
                new Client() { FirstName="Иван", LastName="Ivanov", Surname="Ivanovich", Phone="000000000"} ,
                new Client() { FirstName="Иван", LastName="Ivanov", Surname="Ivanovich", Phone="000000000"} ,
                new Client() { FirstName="Иван", LastName="Ivanov", Surname="Ivanovich", Phone="000000000"} ,
                new Client() { FirstName="Иван", LastName="Ivanov", Surname="Ivanovich", Phone="000000000"} ,
                new Client() { FirstName="Иван", LastName="Ivanov", Surname="Ivanovich", Phone="000000000"} };
            InitializeComponent();
            DgridClients.ItemsSource = Clinets;
        }

   
    }
}
