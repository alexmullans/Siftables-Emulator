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
using System.Windows.Browser;
using System.Runtime.InteropServices;

namespace Siftables
{
    public partial class MainWindow : UserControl
    {
        //int numCubes = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loadAProgramButton_Click(object sender, RoutedEventArgs e)
        {
            // Create an instance of the open file dialog box.
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Set filter options and filter index.
            openFileDialog.Filter = "C# Files (.cs)|*.cs|All Files (*.*)|*.*";
            openFileDialog.FilterIndex = 1;

            openFileDialog.Multiselect = false;

            // Call the ShowDialog method to show the dialog box.
            bool? userClickedOK = openFileDialog.ShowDialog();

            // Process input if the user clicked OK.
            Cube cube1 = (Cube)this.workspace.Children.ToArray()[0];
            if (userClickedOK == true)
            {
                cube1.FillScreen(Color.FromArgb(255, 0, 255, 0));
            }
            else
            {
                cube1.FillScreen(Color.FromArgb(255, 255, 0, 0));
            }
        }
    }
}
