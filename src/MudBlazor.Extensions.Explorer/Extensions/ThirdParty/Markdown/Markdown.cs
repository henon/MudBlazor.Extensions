// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MudBlazor.Extensions.Explorer.Models;

namespace MudBlazor.Extensions.Explorer.Extensions
{
    [Extension]
    public class MarkdownExtension : MudExtension
    {
        public override string Name => "Markdown";
        public override string FullName => "MudBlazor.Markdown";
        public override string Description => "Markdown component for MudBlazor.";
        public override string Authors => "My Nihongo";
        public override string License => "MIT";
        public override bool IsThirdParty => true;
        public override string GithubRepo => "https://github.com/MyNihongo/MudBlazor.Markdown";
        public override string Nuget => "https://www.nuget.org/packages/MudBlazor.Markdown/";

        public override IEnumerable<Type> Docs
        {
            get
            {
                yield return typeof(MarkdownDocs);
            }
        }
    }
}
