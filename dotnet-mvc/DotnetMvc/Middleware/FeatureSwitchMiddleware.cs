using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetMvc.Middleware
{
    public class FeatureSwitchMiddleware
    {
        private readonly RequestDelegate next;

        public FeatureSwitchMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext, IConfiguration config)
        {
            if (httpContext.Request.Path.Value.Contains("/features"))
            {
                var switches = config.GetSection("FeatureSwitches");

                var report = switches.GetChildren().Select(x => $" {x.Key} {x.Value} ");

                await httpContext.Response.WriteAsync(string.Join("\n", report));
            }
            else
            {
                await next(httpContext);
            }
        }
    }
}