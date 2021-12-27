// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MudBlazor.Extensions.Explorer.Extensions.Official.Templates;
using MudBlazor.Extensions.Explorer.Models;

namespace MudBlazor.Extensions.Explorer.Extensions
{
    [Extension]
    public class TemplatesExtension : MudExtension
    {
        public override string Name => "Templates";
        public override string FullName => "MudBlazor.Templates";
        public override string Description => "Blazor Templates pre-configured with MudBlazor.";
        public override string Authors => "MudBlazor";
        public override string License => "MIT";
        public override bool IsThirdParty => false; // (official)
        public override string GithubRepo => "https://github.com/MudBlazor/Templates";
        public override string Nuget => "https://www.nuget.org/packages/MudBlazor.Templates/";

        public override IEnumerable<Type> Docs
        {
            get
            {
                yield return typeof(TemplatesDocs);
            }
        }
    }
}
