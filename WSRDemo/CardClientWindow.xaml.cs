using System.Windows;
using WSRDemo.Models;
using System;
using System.Collections.Generic;

namespace WSRDemo
{
    /// <summary>
    /// Логика взаимодействия для CardClient.xaml
    /// </summary>
    public partial class CardClientWindow : Window
    {
        public CardClientWindow()
        {
            var cardClientList = new List<CardClient>
            {
                new CardClient { DateCreated = DateTime.Now, Price = 1000, WorkoutsAmount = 10, PassedWorkouts = 5, LastWorkoutDateTime = DateTime.Now},
                new CardClient { DateCreated = DateTime.Now, Price = 1000, WorkoutsAmount = 10, PassedWorkouts = 5, LastWorkoutDateTime = DateTime.Now},
                new CardClient { DateCreated = DateTime.Now, Price = 1000, WorkoutsAmount = 10, PassedWorkouts = 5, LastWorkoutDateTime = DateTime.Now},
                new CardClient { DateCreated = DateTime.Now, Price = 1000, WorkoutsAmount = 10, PassedWorkouts = 5, LastWorkoutDateTime = DateTime.Now},
                new CardClient { DateCreated = DateTime.Now, Price = 1000, WorkoutsAmount = 10, PassedWorkouts = 5, LastWorkoutDateTime = DateTime.Now}
            };
            InitializeComponent();
            DgridClients.ItemsSource = cardClientList;
        }

    }
}
