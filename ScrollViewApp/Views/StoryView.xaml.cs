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
using ScrollViewApp.Services;
using ScrollViewApp.ViewModels;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace ScrollViewApp.Views
{
    public sealed partial class StoryView : UserControl
    {
        public StoryViewModel ViewModel { get; set; } = new StoryViewModel();

        public StoryView()
        {
            this.InitializeComponent();
        }

        protected override void OnTapped(TappedRoutedEventArgs e)
        {
            base.OnTapped(e);
            NavigationService.Navigate<SecondPage>();
        }
    }
}
