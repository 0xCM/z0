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
    using System.Collections.Generic;

    using static Part;

    /// <summary>
    /// Defines a catalog over one or more parts
    /// </summary>
    public readonly struct GlobalApiCatalog : IGlobalApiCatalog
    {
        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Parts {get;}

        public Index<Assembly> PartComponents {get;}

        public ApiPartCatalogs Catalogs {get;}

        public IApiHost[] ApiHosts {get;}

        public IApiHost[] OperationHosts {get;}

        public PartId[] PartIdentities {get;}

        /// <summary>
        /// The host-defined operations
        /// </summary>
        public MethodInfo[] Operations {get;}

        [MethodImpl(Inline)]
        public GlobalApiCatalog(params IPart[] parts)
        {
            Parts = parts;
            PartComponents = parts.Select(p => p.Owner);
            Catalogs = parts.Select(x => ApiCatalogs.part(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            ApiHosts = Catalogs.Storage.SelectMany(c => c.ApiHosts.Storage);
            OperationHosts = Catalogs.Storage.SelectMany(c => c.OperationHosts.Storage).Cast<IApiHost>().Array();
            PartIdentities = parts.Select(p => p.Id);
            Operations = Catalogs.Storage.SelectMany(x => x.Operations.Storage);
        }

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => root.option(ApiHosts.Where(h => h.Uri == uri).FirstOrDefault());

        public bool FindHost(ApiHostUri uri, out IApiHost host)
        {
            host = ApiHosts.Where(h => h.Uri == uri).FirstOrDefault();
            return host != null;
        }

        public IEnumerable<IApiPartCatalog> PartCatalogs(params PartId[] parts)
        {
            if(parts.Length == 0)
                return Catalogs.Storage;
            else
                return from c in Catalogs.Storage
                       where parts.Contains(c.PartId)
                       select c;
        }

        public bool FindMethod(OpUri uri, out MethodInfo method)
        {
            if(FindHost(uri.Host, out var host))
                return host.FindMethod(uri, out method);
            method = default;
            return false;
        }

        public IEnumerable<IApiHost> PartHosts(params PartId[] parts)
        {
            if(parts.Length == 0)
                return ApiHosts;
            else
                return  from h in ApiHosts
                        where parts.Contains(h.PartId)
                        select h;
        }

        public Option<Assembly> FindComponent(PartId id)
            => PartComponents.Where(c => c.Id() == id).FirstOrDefault();
    }
}