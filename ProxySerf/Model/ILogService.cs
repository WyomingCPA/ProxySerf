using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySerf.Model
{
  
    public interface ILogService
    {
        void GetData(Action<List<LogItem>, Exception> callback);
    }
}
