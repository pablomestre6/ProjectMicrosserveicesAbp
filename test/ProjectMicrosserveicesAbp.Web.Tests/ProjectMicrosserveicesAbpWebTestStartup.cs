using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Volo.Abp;

namespace ProjectMicrosserveicesAbp;

public class ProjectMicrosserveicesAbpWebTestStartup
{
    public void ConfigureServices(IServiceCollection services)
    {
        services.AddApplication<ProjectMicrosserveicesAbpWebTestModule>();
    }

    public void Configure(IApplicationBuilder app, ILoggerFactory loggerFactory)
    {
        app.InitializeApplication();
    }
}
