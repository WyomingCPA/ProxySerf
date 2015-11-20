using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProxySerf.Model
{
    class ProxyServerItem
    {
        private string _ip;
        private int _port;
        private string _source;
        private DateTime _checked;
        private DateTime _shudled;
        private string _status;
        private string _anonymity;

        public ProxyServerItem(string ip, int port, string source)
        {
            _ip = ip; ;
            _port = port;
            _source = source;
            _checked = default(DateTime);
            _shudled = default(DateTime);
            _status = "Pending";
            _anonymity = "";
        }


        public string Ip
        {
            get { return _ip; }
            set
            {
                _ip = value;
                OnPropertyChanged("Ip");
            }
        }

        public int Port
        {
            get { return _port; }
            set
            {
                _port = value;
                OnPropertyChanged("Port");
            }
        }

        public DateTime Checked
        {
            get { return _checked; }
            set
            {
                _checked = value;
                OnPropertyChanged("Checked");
            }
        }


        public DateTime Shudled
        {
            get { return _shudled; }
            set
            {
                _shudled = value;
                OnPropertyChanged("Shudled");
            }
        }

        public string Status
        {
            get { return _status; }
            set
            {
                _status = value;
                OnPropertyChanged("Status");
            }
        }

        public string Anonymity
        {
            get { return _anonymity; }
            set
            {
                _anonymity = value;
                OnPropertyChanged("Anonymity");
            }
        }

        public string Source
        {
            get { return _source; }
            set
            {
                _source = value;
                OnPropertyChanged("Source");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }


        protected void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
