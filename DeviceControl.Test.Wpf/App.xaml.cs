﻿using Prism.Ioc;
using DeviceControl.Test.Wpf.Views;
using System.Windows;
using GenICam;
using GigeVision.Core;

namespace DeviceControl.Test.Wpf
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterInstance<IGenPort>(new GenPort(3956));
        }
    }
}