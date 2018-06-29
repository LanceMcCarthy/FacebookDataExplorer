using System;

using FacebookDataExplorer.Uwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FacebookDataExplorer.Uwp.Views
{
    public sealed partial class DataPage : Page
    {
        private DataViewModel ViewModel
        {
            get { return DataContext as DataViewModel; }
        }

        public DataPage()
        {
            InitializeComponent();
        }
    }
}
