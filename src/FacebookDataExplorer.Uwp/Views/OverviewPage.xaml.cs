using System;

using FacebookDataExplorer.Uwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FacebookDataExplorer.Uwp.Views
{
    public sealed partial class OverviewPage : Page
    {
        private OverviewViewModel ViewModel
        {
            get { return DataContext as OverviewViewModel; }
        }

        public OverviewPage()
        {
            InitializeComponent();
        }
    }
}
