using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;

using FacebookDataExplorer.Uwp.Helpers;
using FacebookDataExplorer.Uwp.Models;
using FacebookDataExplorer.Uwp.Services;

using GalaSoft.MvvmLight;

using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace FacebookDataExplorer.Uwp.ViewModels
{
    public class ImagesDetailViewModel : ViewModelBase
    {
        private static UIElement _image;
        private object _selectedImage;
        private ObservableCollection<SampleImage> _source;

        public object SelectedImage
        {
            get => _selectedImage;
            set
            {
                Set(ref _selectedImage, value);
                ApplicationData.Current.LocalSettings.SaveString(ImagesViewModel.ImagesSelectedIdKey, ((SampleImage)SelectedImage).ID);
            }
        }

        public ObservableCollection<SampleImage> Source
        {
            get => _source;
            set => Set(ref _source, value);
        }

        public ImagesDetailViewModel()
        {
            // TODO WTS: Replace this with your actual data
            Source = SampleDataService.GetGallerySampleData();
        }

        public void SetImage(UIElement image) => _image = image;

        public async Task InitializeAsync(string sampleImageId, NavigationMode navigationMode)
        {
            if (!string.IsNullOrEmpty(sampleImageId) && navigationMode == NavigationMode.New)
            {
                SelectedImage = Source.FirstOrDefault(i => i.ID == sampleImageId);
            }
            else
            {
                var selectedImageId = await ApplicationData.Current.LocalSettings.ReadAsync<string>(ImagesViewModel.ImagesSelectedIdKey);
                if (!string.IsNullOrEmpty(selectedImageId))
                {
                    SelectedImage = Source.FirstOrDefault(i => i.ID == selectedImageId);
                }
            }

            var animation = ConnectedAnimationService.GetForCurrentView().GetAnimation(ImagesViewModel.ImagesAnimationOpen);
            animation?.TryStart(_image);
        }

        public void SetAnimation()
        {
            ConnectedAnimationService.GetForCurrentView()?.PrepareToAnimate(ImagesViewModel.ImagesAnimationClose, _image);
        }
    }
}
