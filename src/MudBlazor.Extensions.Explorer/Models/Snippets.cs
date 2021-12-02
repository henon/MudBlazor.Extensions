// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Linq;
using System.Reflection;

namespace MudBlazor.Extensions.Explorer.Models
{
    // this is needed for the copy-to-clipboard and open-in-tryMB features
    public static partial class Snippets
    {
        public static string GetCode(string component)
        {
            var field = typeof(Snippets).GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.GetField)
                .FirstOrDefault(f => f.Name == component);
            if (field == null)
                return $"Snippet for component '{component}' not found!";
            return (string)field.GetValue(null);
        }


    }
}
