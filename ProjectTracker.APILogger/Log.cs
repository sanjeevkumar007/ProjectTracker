using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.APILogger
{
    public sealed class Log : ILogService
    {
        private static readonly Lazy<Log> instance = new Lazy<Log>(()=>new Log());

        private Log()
        {

        }

        public static Log GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public async void LogExceptionAsync(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToString());
            string logPath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("-------------------------------------------------");
            builder.AppendLine(DateTime.Now.ToString());
            builder.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logPath, true))
            {
                await writer.WriteAsync(builder.ToString());
                await writer.FlushAsync();
            }
        }
    }
}
