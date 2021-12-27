// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MudBlazor.Extensions.Explorer.Extensions.Official.ThemeManager;
using MudBlazor.Extensions.Explorer.Models;

namespace MudBlazor.Extensions.Explorer.Extensions
{
    [Extension]
    public class ThemeManagerExtension : MudExtension
    {
        public override string Name => "ThemeManager";
        public override string FullName => "MudBlazor.ThemeManager";
        public override string Description => "ThemeManager component for MudBlazor to design, test or make live changes to Mudblazor themes.";
        public override string Authors => "MudBlazor";
        public override string License => "MIT";
        public override bool IsThirdParty => false; // (official)
        public override string GithubRepo => "https://github.com/MudBlazor/ThemeManager";
        public override string Nuget => "https://www.nuget.org/packages/MudBlazor.ThemeManager/";

        public override IEnumerable<Type> Docs
        {
            get
            {
                yield return typeof(ThemeManagerDocs);
            }
        }
    }
}
