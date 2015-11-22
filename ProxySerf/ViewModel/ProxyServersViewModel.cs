using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Messaging;
using System.Windows;

namespace ProxySerf.ViewModel
{
    /// <summary>
    /// This class contains properties that a View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class ProxyServersViewModel : ViewModelBase
    {

        /// <summary>
        /// Initializes a new instance of the ProxyServersViewModel class.
        /// </summary>
        public ProxyServersViewModel()
        {

            Messenger.Default.Register<string>(this, HandleRegistrationInfo);
        }

        private void HandleRegistrationInfo(string info)
        {
            MessageBox.Show(info);
        }
    }
}