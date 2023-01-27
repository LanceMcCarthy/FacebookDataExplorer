using System;

using FacebookDataExplorer.Uwp.ViewModels;

using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FacebookDataExplorer.Uwp.Views
{
    public sealed partial class PlacesPage : Page
    {
        private PlacesViewModel ViewModel
        {
            get { return DataContext as PlacesViewModel; }
        }

        public PlacesPage()
        {
            InitializeComponent();
        }

        protected override async void OnNavigatedTo(NavigationEventArgs e)
        {
            await ViewModel.InitializeAsync(mapControl);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            ViewModel.Cleanup();
        }
    }
}
