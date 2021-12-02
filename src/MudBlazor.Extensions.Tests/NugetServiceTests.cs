// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using MudBlazor.Extensions.Explorer.Services;
using Shouldly;
using System.Threading.Tasks;
using System.Diagnostics;
using NUnit.Framework;

namespace MudBlazor.Extensions.Tests
{
    [TestFixture]
    public class NugetServiceTests
    {
        [Test]
        public async Task TestGetLatestVersion()
        {
            var service = new NugetService();
            var version=await service.GetLatestVersion("https://www.nuget.org/packages/MudBlazor/");
            Console.WriteLine("Version: " + version);
            version.ShouldMatch(@"(\d+\.)+", version);
        }
    }
}
