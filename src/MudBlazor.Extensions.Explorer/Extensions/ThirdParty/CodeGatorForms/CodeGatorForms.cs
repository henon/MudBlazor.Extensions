// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MudBlazor.Extensions.Explorer.Models;

namespace MudBlazor.Extensions.Explorer.Extensions
{
    [Extension]
    public class CodeGatorFormsExtension : MudExtension
    {
        public override string Name => "CodeGator Forms";
        public override string FullName => "CG.Blazor.Forms._MudBlazor";
        public override string Description => "CodeGator Forms automatically generates Forms from annotated models using MudBlazor components.";
        public override string Authors => "CodeGator";
        public override string License => "MIT";
        public override bool IsThirdParty => true;
        public override string GithubRepo => "https://github.com/CodeGator/CG.Blazor.Forms._MudBlazor";
        public override string Nuget => "https://www.nuget.org/packages/CG.Blazor.Forms._MudBlazor";

        public override IEnumerable<Type> Docs
        {
            get
            {
                yield return typeof(CodeGatorFormsDocs);
            }
        }
    }
}
