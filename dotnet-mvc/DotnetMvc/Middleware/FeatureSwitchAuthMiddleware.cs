using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetMvc.Middleware
{
    public class FeatureSwitchAuthMiddleware
    {
        private readonly RequestDelegate next;

        public FeatureSwitchAuthMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        public async Task Invoke(HttpContext httpContext, IConfiguration config)
        {
            var endpoint = httpContext.GetEndpoint()?.Metadata.GetMetadata<RouteAttribute>();

            if (endpoint != null)
            {
                // ?endpoint.Name
                var featureSwitch = config.GetSection("FeatureSwitches")
                    .GetChildren().FirstOrDefault(x => x.Key == endpoint.Template);

                if (featureSwitch != null && !bool.Parse(featureSwitch.Value))
                {
                    httpContext.SetEndpoint(new Endpoint((context) =>
                    {
                        context.Response.StatusCode = StatusCodes.Status404NotFound;
                        return Task.CompletedTask;
                    },
                    EndpointMetadataCollection.Empty, "Feature Not Found."));
                }
            }

            await next(httpContext);
        }
    }
}