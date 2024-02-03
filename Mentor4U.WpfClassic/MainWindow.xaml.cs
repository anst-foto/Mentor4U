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
using Blazored.Modal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Components.Routing;

namespace Mentor4U.WpfClassic;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
        var serviceCollection = new ServiceCollection(); 
        serviceCollection.AddWpfBlazorWebView();
        serviceCollection.AddBlazorWebView();
        serviceCollection.AddBlazoredModal();
        
       this.Resources.Add("services",serviceCollection.BuildServiceProvider());
        
    }
    private void Handle_UrlLoading(object sender,
    UrlLoadingEventArgs urlLoadingEventArgs)
    {
        if (urlLoadingEventArgs.Url.Host != "0.0.0.0")
        {
            urlLoadingEventArgs.UrlLoadingStrategy =
                UrlLoadingStrategy.OpenInWebView;
        }
    }
}