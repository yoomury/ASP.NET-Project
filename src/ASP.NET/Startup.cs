using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Builder;
using Microsoft.AspNet.Hosting;
using Microsoft.AspNet.Http;
using Microsoft.Extensions.DependencyInjection;

namespace ASP.NET
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit http://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
//            app.UseIISPlatformHandler();

           /* app.Run(async (context) =>
            {
                var html = @"<!DOCTYPE html>
                        <html>
                        <head>
                        </head>
                        <body>
                            <h2>HelloWorld</h2>
                        </body>
                        </html>";
                           
                await context.Response.WriteAsync(html);
            });*/
            app.UseDefaultFiles();
            app.UseStaticFiles();
        }

        // Entry point for the application.
        public static void Main(string[] args) => WebApplication.Run<Startup>(args);
    }
}
