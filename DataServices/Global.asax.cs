using Domain.Models;
using log4net.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace DataServices
{
    public class Global : System.Web.HttpApplication
    {

        public SessionHelper _sessionHelper = null;
        protected void Application_Start(object sender, EventArgs e)
        {
            XmlConfigurator.Configure();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {
            //_sessionHelper = new SessionHelper();
            //_sessionHelper.OpenSession();
            //Application.Set("NhibernateConn", _sessionHelper);
        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {
            //_sessionHelper = new SessionHelper();
            _sessionHelper.CloseSession();
        }
    }
}