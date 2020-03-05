using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using System;
using System.Collections.Generic;
using System.Text;

namespace WPFNavigation.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        public const string WelcomeTitlePropertyName = "Hello World WPF Navigation";
        private string _welcomeTitle = string.Empty;
        public string WelcomeTitle
        {
            get
            {
                return _welcomeTitle;
            }
            set
            {
                Set(ref _welcomeTitle, value);
            }
        }

        public const string FrameUriPropertyName = "FrameUri";
        private Uri _frameUri;
        public Uri FrameUri
        {
            get
            {
                return _frameUri;
            }
            set
            {
                Set(FrameUriPropertyName, ref _frameUri, value);
                System.Diagnostics.Debug.WriteLine(_frameUri.ToString(), "_frameUri");
                System.Diagnostics.Debug.WriteLine(FrameUri.ToString(), "FrameUri");
            }
        }

        public MainWindowViewModel()
        {
            FrameUri = ViewModelLocator.PageOneUri;
        }

        private RelayCommand _pageOneCommand;
        public RelayCommand PageOneCommand
        {
            get
            {
                return _pageOneCommand
                    ?? (_pageOneCommand = new RelayCommand(
                    () =>
                    {
                        FrameUri = ViewModelLocator.PageOneUri;
                    },
                    () => CheckUri(FrameUri, ViewModelLocator.PageOneUri)));
            }
        }

        private RelayCommand _pageTwoCommand;
        public RelayCommand PageTwoCommand
        {
            get
            {
                return _pageTwoCommand
                    ?? (_pageTwoCommand = new RelayCommand(
                    () =>
                    {
                        FrameUri = ViewModelLocator.PageTwoUri;
                    },
                    () => CheckUri(FrameUri, ViewModelLocator.PageTwoUri)));
            }
        }
        private Boolean CheckUri(Uri _frameUriToCheck, Uri _vmUri)
        {
            string StringUriToCheck = _frameUriToCheck.ToString();
            string StringUriVM = _vmUri.ToString();
            System.Diagnostics.Debug.WriteLine(StringUriToCheck, "StringUriToCheck");
            System.Diagnostics.Debug.WriteLine(StringUriVM, "StringUriVM");

            if (StringUriVM.Contains(StringUriToCheck))
            { return false; }
            else
            { return true; }
        }

    }

}
