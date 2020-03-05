using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Navigation;

namespace WPFNavigation.Interfaces
{
    public interface INavigationService
    {
        event NavigatingCancelEventHandler Navigating;
        void NavigateTo(Uri uri);
        void GoBack();
    }
}
