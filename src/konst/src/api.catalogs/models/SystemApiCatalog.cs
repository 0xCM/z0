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

    using static Konst;

    /// <summary>
    /// Defines a catalog over one or more parts
    /// </summary>
    public readonly struct SystemApiCatalog : ISystemApiCatalog
    {
        /// <summary>
        /// The members of the compostion
        /// </summary>
        public IPart[] Parts {get;}

        public Assembly[] PartComponents {get;}

        public PartId[] Identifiers {get;}

        public ApiPartCatalogs Catalogs {get;}

        public IApiHost[] ApiHosts {get;}

        public IApiHost[] OperationHosts {get;}

        public PartId[] PartIdentities {get;}

        /// <summary>
        /// The host-defined operations
        /// </summary>
        public MethodInfo[] Operations {get;}

        [MethodImpl(Inline)]
        public SystemApiCatalog(params IPart[] parts)
        {
            Parts = parts;
            Identifiers = Parts.Select(p => p.Id);
            PartComponents = Parts.Select(p => p.Owner);
            Catalogs = Parts.Select(x => ApiCatalogs.part(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            ApiHosts = Catalogs.Storage.SelectMany(c => c.ApiHosts.Storage);
            OperationHosts = Catalogs.Storage.SelectMany(c => c.OperationHosts).Cast<IApiHost>().Array();
            PartIdentities = Identifiers;
            Operations = Catalogs.Storage.SelectMany(x => x.Operations);
        }

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => z.option(ApiHosts.Where(h => h.Uri == uri).FirstOrDefault());

        public IEnumerable<IApiPartCatalog> PartCatalogs(params PartId[] parts)
        {
            if(parts.Length == 0)
                return Catalogs.Storage;
            else
                return from c in Catalogs.Storage
                       where parts.Contains(c.PartId)
                       select c;
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