// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Text.RegularExpressions;

namespace MudBlazor.Extensions.Explorer.Models
{
    public class MudExtension
    {
        public virtual string Name { get; } = "MudBlazor";

        public virtual string FullName { get; } = "MudBlazor";

        public virtual string Description { get; } = "MudBlazor is an ambitious Material Design component library for Blazor";

        public virtual string License { get; } = "MIT";

        public virtual string Authors { get; } = "Jonny Larson, Meinrad Recheis and others";

        public virtual bool IsThirdParty { get; } = true;

        public virtual string GithubRepo { get; } = "https://github.com/MudBlazor/MudBlazor";

        public string RepoName => GithubRepo?.Replace("https://github.com/", "");

        public virtual string Nuget { get; } = "https://www.nuget.org/packages/MudBlazor/";

        public virtual IEnumerable<Type> Docs
        {
            get { yield break; }
        }

        public bool IsOfficial => !IsThirdParty;

        private string _id;
        public string Id => _id == null ? _id = MakeId() : _id;

        private string MakeId()
        {
            var repoName = RepoName.ToLowerInvariant();
            return Regex.Replace(repoName, "[/.]", "-");
        }
    }
}
