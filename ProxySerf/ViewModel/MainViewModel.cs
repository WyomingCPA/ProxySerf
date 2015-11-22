using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Messaging;
using ProxySerf.Model;
using System;
using System.Collections.ObjectModel;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProxySerf.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {

        public ICommand Start { get; private set; }


        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel()
        {

            Start = new RelayCommand(() => StartExecute(), () => true);
        }

        private void StartExecute()
        {
                     
            Task.Factory.StartNew(() =>
                {
                    int i = 0;
                    while (true)
                    {
                        LogItem info = new LogItem(DateTime.UtcNow, i, "Application started.");
                        Messenger.Default.Send(info);
                        Thread.Sleep(2000);
                        i += 1;
                    }
                });
        }

    }
}