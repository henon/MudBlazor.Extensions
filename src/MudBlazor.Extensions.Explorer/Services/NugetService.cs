// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Net.Http;
using System.Text.Json;

namespace MudBlazor.Extensions.Explorer.Services
{
    public class NugetService
    {
        public string GetPackageName(string packageUrl)
        {
            var packageName = packageUrl.Replace("https://www.nuget.org/packages/", "").TrimEnd('/');
            return packageName;
        }

        public async Task<string> GetLatestVersion(string packageUrl)
        {
            var packageName= GetPackageName(packageUrl);
            using var httpClient = new HttpClient();
            try
            {
                var url = $"https://api.nuget.org/v3-flatcontainer/{packageName}/index.json";
                var response = await httpClient.GetAsync(url);
                var bytes = await response.Content.ReadAsByteArrayAsync();
                var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
                var versionsResponse = JsonSerializer.Deserialize<PackageVersions>(bytes, options);
                var lastVersion = versionsResponse.Versions[^1]; //(length-1)
                return lastVersion;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public async Task<string> GetIconUrl(string packageUrl)
        {
            var version = await GetLatestVersion(packageUrl);
            if (version == null)
                return "https://www.nuget.org/Content/gallery/img/default-package-icon-256x256.png";
            var packageName = GetPackageName(packageUrl).ToLowerInvariant();
            return $"https://api.nuget.org/v3-flatcontainer/{packageName}/{version}/icon";
        }

        class PackageVersions
        {
            public string[] Versions { get; set; }
        }
    }

}
