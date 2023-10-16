// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor;
using MudBlazor.Extensions;
using MudBlazor.Extensions.Explorer;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddMudServices();
builder.Services.AddDocsServices();

//markdown
builder.Services.AddMudMarkdownServices();
//code gator forms
builder.Services.AddFormGeneration();
//mudblazor.extensions
builder.Services.AddMudExtensions(c => c.WithoutAutomaticCssLoading());

await builder.Build().RunAsync();
