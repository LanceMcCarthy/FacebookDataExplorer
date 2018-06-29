using System;
using System.Collections.ObjectModel;

using FacebookDataExplorer.Uwp.Models;
using FacebookDataExplorer.Uwp.Services;

using GalaSoft.MvvmLight;

namespace FacebookDataExplorer.Uwp.ViewModels
{
    public class InsightsViewModel : ViewModelBase
    {
        public ObservableCollection<SampleOrder> Source
        {
            get
            {
                // TODO WTS: Replace this with your actual data
                return SampleDataService.GetGridSampleData();
            }
        }
    }
}
