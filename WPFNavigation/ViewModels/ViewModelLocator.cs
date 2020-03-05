using GalaSoft.MvvmLight.Ioc;
using System;
using System.Collections.Generic;
using System.Text;
using WPFNavigation.Interfaces;
using WPFNavigation.Services;
using CommonServiceLocator;

namespace WPFNavigation.ViewModels
{
    public class ViewModelLocator
    {
        public static readonly Uri PageOneUri = new Uri("/Views/PageOneView.xaml", UriKind.Relative);
        public static readonly Uri PageTwoUri = new Uri("/Views/PageTwoView.xaml", UriKind.Relative);

        static ViewModelLocator()
        {
            SimpleIoc.Default.Register<MainWindowViewModel>();
            SimpleIoc.Default.Register<PageOneViewModel>();
            SimpleIoc.Default.Register<PageTwoViewModel>();
            SimpleIoc.Default.Register<INavigationService, NavigationService>();
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Performance",
            "CA1822:MarkMembersAsStatic",
            Justification = "This non-static member is needed for data binding purposes.")]
        public MainWindowViewModel Main
        {
            get
            {
                return SimpleIoc.Default.GetInstance<MainWindowViewModel>();
            }
        }

        public PageOneViewModel One
        {
            get
            {
                return SimpleIoc.Default.GetInstance<PageOneViewModel>();
            }
        }

        public PageTwoViewModel Two
        {
            get
            {
                return SimpleIoc.Default.GetInstance<PageTwoViewModel>();
            }
        }

        public static void Cleanup()
        {
        }
    }

}
