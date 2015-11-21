using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ProxySerf.Model
{
    class ProxySourceItem
    {
        string _Url;
        string _Prepattern;
        string _Prereplacement;
        int _Interval;
        int _Proxies;
        int _Working;
        int _Bad;
        DateTime _Shudled;
        bool _Use;


        public ProxySourceItem(string i_url, string i_prepattern, string i_prereplacement, int i_interval, int i_proxies)
        {
            _Url = i_url;
            _Prepattern = i_prepattern;
            _Prereplacement = i_prereplacement;
            _Interval = i_interval;
            _Shudled = default(DateTime);
            _Proxies = i_proxies;
            _Working = 0;
            _Bad = 0;
            _Use = true;

        }

        public string Url
        {
            get { return _Url; }
            set
            {
                _Url = value;
                RaisePropertyChanged("Url");
            }
        }

        public string Prepattern
        {
            get { return _Prepattern; }
            set
            {
                _Prepattern = value;
                RaisePropertyChanged("Prepattern");
            }
        }

        public string Prereplacement
        {
            get { return _Prereplacement; }
            set
            {
                _Prereplacement = value;
                RaisePropertyChanged("Prereplacement");
            }
        }

        public int Interval
        {
            get { return _Interval; }
            set
            {
                _Interval = value;
                RaisePropertyChanged("Interval");
            }
        }

        public DateTime Shudled
        {
            get { return _Shudled; }
            set
            {
                _Shudled = value;
                RaisePropertyChanged("Shudled");
            }
        }

        public int Proxies
        {
            get { return _Proxies; }
            set
            {
                _Proxies = value;
                RaisePropertyChanged("Proxies");
            }
        }

        public int Working
        {
            get { return _Working; }
            set
            {
                _Working = value;
                RaisePropertyChanged("Working");
            }
        }

        public int Bad
        {
            get { return _Bad; }
            set
            {
                _Bad = value;
                RaisePropertyChanged("Bad");
            }
        }

        public bool Use
        {
            get { return _Use; }
            set
            {
                _Use = value;
                RaisePropertyChanged("Use");
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
