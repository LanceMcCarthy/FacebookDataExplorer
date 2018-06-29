using System;

using CommonServiceLocator;

using FacebookDataExplorer.Uwp.Services;
using FacebookDataExplorer.Uwp.Views;

using GalaSoft.MvvmLight.Ioc;

namespace FacebookDataExplorer.Uwp.ViewModels
{
    [Windows.UI.Xaml.Data.Bindable]
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            if (SimpleIoc.Default.IsRegistered<NavigationServiceEx>())
            {
                return;
            }

            SimpleIoc.Default.Register(() => new NavigationServiceEx());
            SimpleIoc.Default.Register<ShellViewModel>();
            Register<OverviewViewModel, OverviewPage>();
            Register<DataViewModel, DataPage>();
            Register<ImagesViewModel, ImagesPage>();
            Register<ImagesDetailViewModel, ImagesDetailPage>();
            Register<VideoViewModel, VideoPage>();
            Register<InsightsViewModel, InsightsPage>();
            Register<PlacesViewModel, PlacesPage>();
            Register<SettingsViewModel, SettingsPage>();
            Register<UriSchemeExampleViewModel, UriSchemeExamplePage>();
            Register<ShareTargetViewModel, ShareTargetPage>();
        }

        public ShareTargetViewModel ShareTargetViewModel => ServiceLocator.Current.GetInstance<ShareTargetViewModel>();

        public UriSchemeExampleViewModel UriSchemeExampleViewModel => ServiceLocator.Current.GetInstance<UriSchemeExampleViewModel>();

        public SettingsViewModel SettingsViewModel => ServiceLocator.Current.GetInstance<SettingsViewModel>();

        public PlacesViewModel PlacesViewModel => ServiceLocator.Current.GetInstance<PlacesViewModel>();

        public InsightsViewModel InsightsViewModel => ServiceLocator.Current.GetInstance<InsightsViewModel>();

        // A Guid is generated as a unique key for each instance as reusing the same VM instance in multiple MediaPlayerElement instances can cause playback errors
        public VideoViewModel VideoViewModel => ServiceLocator.Current.GetInstance<VideoViewModel>(Guid.NewGuid().ToString());

        public ImagesDetailViewModel ImagesDetailViewModel => ServiceLocator.Current.GetInstance<ImagesDetailViewModel>();

        public ImagesViewModel ImagesViewModel => ServiceLocator.Current.GetInstance<ImagesViewModel>();

        public DataViewModel DataViewModel => ServiceLocator.Current.GetInstance<DataViewModel>();

        public OverviewViewModel OverviewViewModel => ServiceLocator.Current.GetInstance<OverviewViewModel>();

        public ShellViewModel ShellViewModel => ServiceLocator.Current.GetInstance<ShellViewModel>();

        public NavigationServiceEx NavigationService => ServiceLocator.Current.GetInstance<NavigationServiceEx>();

        public void Register<VM, V>()
            where VM : class
        {
            SimpleIoc.Default.Register<VM>();

            NavigationService.Configure(typeof(VM).FullName, typeof(V));
        }
    }
}
