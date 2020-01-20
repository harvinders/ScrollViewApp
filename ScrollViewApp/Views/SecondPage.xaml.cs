using System;

using ScrollViewApp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace ScrollViewApp.Views
{
    public sealed partial class SecondPage : Page
    {
        public SecondViewModel ViewModel { get; } = new SecondViewModel();

        public SecondPage()
        {
            InitializeComponent();
        }
    }
}
