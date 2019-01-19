using ProjectTracker.APILogger;
using System;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.ExceptionHandling;
using System.Web.Http.Results;

namespace ProjectTracker.UI.Controllers
{
    public class BaseController : ApiController
    {
        private readonly ILogService _log;

        public BaseController()
        {
            _log = Log.GetInstance;
        }

        protected override ExceptionResult InternalServerError(Exception exception)
        {
            _log.LogExceptionAsync(exception.Message.ToString());
            return base.InternalServerError(exception);
        }
    }
}
