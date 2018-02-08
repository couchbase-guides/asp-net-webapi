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
        // tag::Application_Start[]
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            ClusterHelper.Initialize(new ClientConfiguration
            {
                Servers = new List<Uri> {new Uri("http://localhost:8091")}
            }, new PasswordAuthenticator("myuser", "mypassword"));
        }
        // end::Application_Start[]

        protected void Application_End()
        {
            ClusterHelper.Close();
        }
    }
}
