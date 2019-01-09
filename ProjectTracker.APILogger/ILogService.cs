using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectTracker.APILogger
{
    public interface ILogService
    {
        void LogExceptionAsync(string message);
    }
}
