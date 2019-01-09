using ProjectTracker.APILogger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;

namespace ProjectTracker.UI.Controllers
{
    public class BaseController : ApiController
    {
        private readonly ILogService _log;

        //public async Task HandleAsync(ExceptionHandlerContext context, CancellationToken cancellationToken)
        //{
        //    _log.LogExceptionAsync(context.Exception.Message);
        //    return Task.FromResult(0);
        //}

        public Task LogAsync(ExceptionLoggerContext context, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
