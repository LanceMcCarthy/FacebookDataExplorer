﻿using System;

using GalaSoft.MvvmLight;

namespace FacebookDataExplorer.Uwp.ViewModels
{
    // TODO WTS: Remove this example page when/if it's not needed.
    // This page is an example of how to launch a specific page in response to a protocol launch and pass it a value.
    // It is expected that you will delete this page once you have changed the handling of a protocol launch to meet
    // your needs and redirected to another of your pages.
    public class UriSchemeExampleViewModel : ViewModelBase
    {
        // This property is just for displaying the passed in value
        private string _secret;

        public string Secret
        {
            get { return _secret; }
            set { Set(ref _secret, value); }
        }
    }
}
