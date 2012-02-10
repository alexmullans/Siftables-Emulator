﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Siftables.Sifteo;

namespace Siftables
{
    public class MyApp : BaseApp
    {
        override public void Setup()
        {
            foreach (Cube cube in Cubes)
            {
                cube.FillScreen(Colors.White);
            }
        }
    }
}