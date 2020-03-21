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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace FluentUwpApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        bool clicked = false;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void ClickMeBtn_Click(object sender, RoutedEventArgs e)
        {
            if (clicked) { clicked = false; } else clicked = true;
            if (clicked) { ClickMeBtn.Content = DateTime.Now.ToString("hh:mm:ss"); }
            else ClickMeBtn.Content = "Refresh";


        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            Style reveal = Resources.ThemeDictionaries["ButtonRevealStyle"] as Style;
            foreach (Button b in gridCalculator.Children.OfType<Button>())
            {
                b.FontSize = 24;
                b.Width = 54;
                b.Height = 54;
                b.Style = reveal;
            }
        }
    }
}
