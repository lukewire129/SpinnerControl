﻿using Jamesnet.Wpf.Controls;
using System.Windows;

namespace DemoApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            return new MainWindow ();
        }
    }
}
