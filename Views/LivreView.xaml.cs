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
using BiblioGest.ViewModels; // NE PAS OUBLIER !

namespace BiblioGest.Views
{
    /// <summary>
    /// Logique d'interaction pour UserControl1.xaml
    /// </summary>
    public partial class LivreView : UserControl
    {
        public LivreView()
        {
            InitializeComponent();
            DataContext = new LivreViewModel(); 


        }
    }
}
