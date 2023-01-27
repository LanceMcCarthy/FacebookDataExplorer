using System;

using FacebookDataExplorer.Uwp.ViewModels;

using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FacebookDataExplorer.Uwp.Views
{
    public sealed partial class ImagesPage : Page
    {
        private ImagesViewModel ViewModel
        {
            get { return DataContext as ImagesViewModel; }
        }

        public ImagesPage()
        {
            InitializeComponent();
            ViewModel.Initialize(gridView);
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            if (e.NavigationMode == NavigationMode.Back)
            {
                await ViewModel.LoadAnimationAsync();
            }
        }
    }
}
