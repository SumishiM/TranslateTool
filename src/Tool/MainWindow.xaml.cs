﻿using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using TranslateToolAPI;

namespace Tool
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public IList<TranslateItem> items;

        public MainWindow()
        {
            InitializeComponent();

            items = new List<TranslateItem>();

            foreach (var item in TranslateToolAPI.Application.translateItems)
            {
                items.Add(item);
            }
        }
    }
}
