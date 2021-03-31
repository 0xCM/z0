//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;
    using System.Linq;

    using static Part;
    using static memory;

    /// <summary>
    /// Defines a catalog over one or more parts
    /// </summary>
    public class GlobalApiCatalog : IApiCatalogDataset
    {
        IApiCatalogDataset Data;

        [MethodImpl(Inline)]
        public GlobalApiCatalog(params IPart[] parts)
        {
            Data = ApiCatalogs.dataset(parts);
            // Parts = parts;
            // PartComponents = parts.Select(p => p.Owner);
            // Catalogs = parts.Select(x => ApiCatalogs.PartCatalog(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            // ApiHosts = Catalogs.Storage.SelectMany(c => c.ApiHosts.Storage);
            // PartIdentities = parts.Select(p => p.Id);
            // Operations = Catalogs.Storage.SelectMany(x => x.Operations.Storage);
        }


        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Parts
            => Data.Parts;

        public Index<Assembly> PartComponents
            => Data.PartComponents;

        public ApiPartCatalogs Catalogs
            => Data.Catalogs;

        public IApiHost[] ApiHosts
            => Data.ApiHosts;

        public PartId[] PartIdentities
            => Data.PartIdentities;

        /// <summary>
        /// The host-defined operations
        /// </summary>
        public MethodInfo[] Operations
            => Data.Operations;

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => Data.FindHost(uri);

        public Index<IApiPartCatalog> PartCatalogs(params PartId[] parts)
            => Data.PartCatalogs(parts);

        public bool FindMethod(OpUri uri, out MethodInfo method)
            => Data.FindMethod(uri, out method);

        public Index<IApiHost> PartHosts(params PartId[] parts)
            => Data.PartHosts(parts);

        public Option<Assembly> FindComponent(PartId id)
            => Data.FindComponent(id);

        public Index<IApiHost> FindHosts(ReadOnlySpan<ApiHostUri> src)
            => Data.FindHosts(src);
    }
}