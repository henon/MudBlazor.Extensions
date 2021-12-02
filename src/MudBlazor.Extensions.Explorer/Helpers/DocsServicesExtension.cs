// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Extensions.Explorer.Services;
using MudBlazor.Services;

namespace MudBlazor.Extensions.Explorer
{
    public static class DocsServicesExtension
    {
        public static void AddDocsServices(this IServiceCollection services)
        {
            services.AddSingleton<ExplorerService>(ExplorerService.Init());
            services.AddSingleton<NugetService>();
            services.AddSingleton<IRenderQueueService, RenderQueueService>();
        }
    }
}
