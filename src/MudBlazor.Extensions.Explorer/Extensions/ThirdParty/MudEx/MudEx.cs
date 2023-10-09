// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MudBlazor.Extensions.Explorer.Models;

namespace MudBlazor.Extensions.Explorer.Extensions
{
    [Extension]
    public class MudExExtension : MudExtension
    {
        public override string Name => "MudBlazor.Extensions";
        public override string FullName => "MudBlazor.Extensions";
        public override string Description => "MudBlazor.Extensions is a convenient package that extends the capabilities of the MudBlazor component library with more components, fluent form generation, dialog extensions and more";
        public override string Authors => "fgilde";
        public override string License => "MIT";
        public override bool IsThirdParty => true;
        public override string GithubRepo => "https://github.com/fgilde/MudBlazor.Extensions";
        public override string Nuget => "https://www.nuget.org/packages/MudBlazor.Extensions/";

        public override IEnumerable<Type> Docs
        {
            get
            {
                yield return typeof(MudExDocs);
            }
        }
    }
}
