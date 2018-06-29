using System;

using FacebookDataExplorer.Uwp.ViewModels;

using Windows.UI.Xaml.Controls;

namespace FacebookDataExplorer.Uwp.Views
{
    public sealed partial class InsightsPage : Page
    {
        private InsightsViewModel ViewModel
        {
            get { return DataContext as InsightsViewModel; }
        }

        // TODO WTS: Change the grid as appropriate to your app.
        // For help see http://docs.telerik.com/windows-universal/controls/raddatagrid/gettingstarted
        // You may also want to extend the grid to work with the RadDataForm http://docs.telerik.com/windows-universal/controls/raddataform/dataform-gettingstarted
        public InsightsPage()
        {
            InitializeComponent();
        }
    }
}
