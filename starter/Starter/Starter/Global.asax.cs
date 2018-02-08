using System;
using System.Collections.Generic;
using System.Web.Http;
using Couchbase;
using Couchbase.Authentication;
using Couchbase.Configuration.Client;

namespace Starter
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            throw new NotImplementedException("Initialize ClusterHelper with ClientConfiguration");
        }

        protected void Application_End()
        {
            throw new NotImplementedException("Clean up ClusterHelper with Close");
        }
    }
}
