using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Rick_and_Morty_Project.GraphQL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GraphQL_API
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddGraphQLServer() // I sets up a new schema and executor with additional services the server needs
            .AddQueryType<Query>() // I inform the GraphQL server to use Query 
            .AddFiltering(); // To use filtering I need to register it on the schema

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //  GraphQL has only one endpoint in contrast to Rest. All the operations are executed against this endpoint.
            app.UseEndpoints(endpoints => endpoints.MapGraphQL("/"));
        }
    }
}
