using GalaSoft.MvvmLight;
using ProxySerf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Timers;
using System.Windows;

namespace ProxySerf.ViewModel
{

    public class LogViewModel : ViewModelBase
    {

        private string TestData = "Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum";
        private List<string> words;
        private int maxword;
        private int index;

        public ObservableCollection<LogItem> LogEntries { get; set; }

        /// <summary>
        /// Initializes a new instance of the LogViewModel class.
        /// </summary>
        public LogViewModel()
        {

        }
    }
}