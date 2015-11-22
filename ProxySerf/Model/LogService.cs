using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxySerf.Model
{
    class LogService : ILogService
    {
        public void GetData(Action<List<LogItem>, Exception> callback)
        {
            // Use this to connect to the actual data service
            List<LogItem> item = new List<LogItem>();
            item.Add(new LogItem(DateTime.UtcNow, 0,  "Application started."));
            callback(item, null);
        }
    }
}
