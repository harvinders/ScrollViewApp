using System;
using Windows.Foundation;
using Windows.UI.Xaml;
using ScrollViewApp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using Microsoft.UI.Xaml.Controls.Primitives;
using ScrollViewApp.Helpers;

namespace ScrollViewApp.Views
{
    public sealed partial class MainPage : Page
    {
        public MainViewModel ViewModel { get; } = new MainViewModel();
        double relativeVerticalOffset;
        int index;

        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatingFrom(NavigatingCancelEventArgs e)
        {
            base.OnNavigatingFrom(e);
            var scroller = ScrollViewer.GetFirstDescendantOfType<Scroller>();
            var anchorProvider = scroller as IScrollAnchorProvider;
            var anchor = anchorProvider.CurrentAnchor;

            if (null == anchor)
                return;

            index = this.ItemRepeater.GetElementIndex(anchor);
            var topicView = anchor as TopicView;
            var anchorBounds = anchor.TransformToVisual(this.ScrollViewer).TransformBounds(new Rect(0, 0, topicView.ActualWidth, topicView.ActualHeight));
            relativeVerticalOffset = anchorBounds.Top;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (index == 0)
                return;

            var element = ItemRepeater.GetOrCreateElement(index);

            // ensure the item is given a valid position
            element.UpdateLayout();
            element.StartBringIntoView(new BringIntoViewOptions()
            {
                VerticalOffset = relativeVerticalOffset
            });

        }
    }
}
