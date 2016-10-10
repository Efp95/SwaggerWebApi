using Swashbuckle.Application;
using System.Web.Http;

namespace SalesApp.Api
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            GlobalConfiguration.Configuration
            .EnableSwagger(c =>
            {
                c.SingleApiVersion("v1", "Sales Application")
                 .Description("A sample API")
                 .TermsOfService("Dummy terms")
             .Contact(cc => cc
               .Name("Edson Flores Palma")
               .Url("https://www.linkedin.com/in/edson-flores-palma-934039b8")
               .Email("edsonflorespalma@gmail.com"))
             .License(lc => lc
               .Name("Dummy License")
               .Url("https://somelicense.com/license"));
            })
        .EnableSwaggerUi();
        }
    }
}
