﻿using SIS.HTTP.Enums;
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
        public IHttpResponse Home(IHttpRequest httpRequest)
        {
            this.HttpRequest = httpRequest;

            return this.View();
        }

        public IHttpResponse Login(IHttpRequest httpRequest)
        {
            httpRequest.Session.AddParameter("username", "Pesho");

            return this.Redirect("/");
        }

        public IHttpResponse Logout(IHttpRequest httpRequest)
        {
            httpRequest.Session.ClearParameters();

            return this.Redirect("/");
        }
    }
}
