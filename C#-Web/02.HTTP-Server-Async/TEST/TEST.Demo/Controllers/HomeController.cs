using SIS.HTTP.Enums;
using SIS.HTTP.Requests.Contracts;
using SIS.HTTP.Responses.Contracts;
using SIS.WebServer.Results;
using System;
using System.Collections.Generic;
using System.Text;

namespace TEST.Demo.Controllers
{
    public class HomeController: BaseController
    {
        public IHttpResponse Home(IHttpRequest request)
        {
            return this.View();
        }
    }
}
