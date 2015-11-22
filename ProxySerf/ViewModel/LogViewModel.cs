using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Threading;
using ProxySerf.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading;
using System.Timers;
using System.Windows;
using System.Windows.Threading;

namespace ProxySerf.ViewModel
{
    public class LogViewModel : ViewModelBase
    {
        private readonly ILogService _dataService;
        public ObservableCollection<LogItem> LogList { get; set; }

       
        /// <summary>
        /// Initializes a new instance of the LogViewModel class.
        /// </summary>
        public LogViewModel(ILogService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
                (item, error) =>
                {
                    if (error != null)
                    {
                        // Report error here
                        return;
                    }
                    Messenger.Default.Register<LogItem>(this, HandleRegistrationInfo);

                    LogList = new ObservableCollection<LogItem>(item.Select(b => new LogItem(b.DateTime, b.Index, b.Message)));
                });
        }

        private void HandleRegistrationInfo(LogItem info)
        {
            DispatcherHelper.CheckBeginInvokeOnUI(() => LogList.Add(info));
        }
   }  
}