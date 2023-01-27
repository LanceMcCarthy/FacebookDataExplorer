using System;

using FacebookDataExplorer.Uwp.ViewModels;

using Windows.Media.Playback;
using Windows.System.Display;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace FacebookDataExplorer.Uwp.Views
{
    public sealed partial class VideoPage : Page
    {
        private VideoViewModel ViewModel
        {
            get { return DataContext as VideoViewModel; }
        }

        // For more on the MediaPlayer and adjusting controls and behavior see https://docs.microsoft.com/en-us/windows/uwp/controls-and-patterns/media-playback
        // The DisplayRequest is used to stop the screen dimming while watching for extended periods
        private DisplayRequest _displayRequest = new DisplayRequest();
        private bool _isRequestActive = false;

        public VideoPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            mpe.MediaPlayer.PlaybackSession.PlaybackStateChanged += PlaybackSession_PlaybackStateChanged;
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            mpe.MediaPlayer.Pause();
            mpe.MediaPlayer.PlaybackSession.PlaybackStateChanged -= PlaybackSession_PlaybackStateChanged;
        }

        private async void PlaybackSession_PlaybackStateChanged(MediaPlaybackSession sender, object args)
        {
            if (sender is MediaPlaybackSession playbackSession && playbackSession.NaturalVideoHeight != 0)
            {
                if (playbackSession.PlaybackState == MediaPlaybackState.Playing)
                {
                    if (!_isRequestActive)
                    {
                        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            _displayRequest.RequestActive();
                            _isRequestActive = true;
                        });
                    }
                }
                else
                {
                    if (_isRequestActive)
                    {
                        await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
                        {
                            _displayRequest.RequestRelease();
                            _isRequestActive = false;
                        });
                    }
                }
            }
        }
    }
}
