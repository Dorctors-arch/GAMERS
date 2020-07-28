﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace GAMERS_TECH
{
    /// <summary>
    /// Interaction logic for Personnelinfo.xaml
    /// </summary>
    public partial class Personnelinfo : Page
    {
        public Personnelinfo()

        {
            InitializeComponent();
            PersonnelInfoViewModel persons = new PersonnelInfoViewModel();
            Users.ItemsSource = persons.GetData();
        }
    }
}
