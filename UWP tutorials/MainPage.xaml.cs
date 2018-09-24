using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using System.Diagnostics;

// Il modello di elemento Pagina vuota è documentato all'indirizzo https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x410

namespace UWP_tutorials
{
    /// <summary>
    /// Pagina vuota che può essere usata autonomamente oppure per l'esplorazione all'interno di un frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Mario(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Mario));
        }

        private void UWP(object sender, RoutedEventArgs e)
        {
            var uri = new Uri("http://mariocuomo.azurewebsites.net/2018/08/26/about-an-universal-windows-platform-project/");
            Windows.System.Launcher.LaunchUriAsync(uri);
        }

        private void ResponsiveLayout(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ResponsiveLayout.ResponsiveLayout));
        }

        private void CountClick(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(CountClick.CountClick));
        }

        private void ChangePage(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(ChangePage.ChangePage));
        }

        private void RightButton(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RightButton.RightButton));
        }
        
    }
}
