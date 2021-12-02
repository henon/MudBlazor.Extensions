// Copyright (c) MudBlazor 2021
// MudBlazor licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using MudBlazor.Extensions.Explorer.Models;

namespace MudBlazor.Extensions.Explorer.Services
{
    public class ExplorerService
    {
        static MudExtension[] _extensions;
        static Dictionary<string, MudExtension> _idLookup;

        public static ExplorerService Init()
        {
            _extensions = GetExtensionTypes()
                .Select(t=> Activator.CreateInstance(t))
                .OfType<MudExtension>()
                .Where(x=>!string.IsNullOrWhiteSpace(x.Id))
                .DistinctBy(x=>x.Id)
                .ToArray();
            _idLookup = _extensions.ToDictionary(x => x.Id);
            return new ExplorerService();
        }

        public static IEnumerable<Type> GetExtensionTypes() => typeof(ExplorerService).Assembly.GetTypes().Where(t => Attribute.GetCustomAttributes(t).OfType<ExtensionAttribute>().Any());

        public IEnumerable<MudExtension> GetExtensions()
        {
            return _extensions;
        }

        public MudExtension GetExtension(string id)
        {
            if (_idLookup.TryGetValue(id, out var extension))
                return extension;
            return null;
        }
    }
}
