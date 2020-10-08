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
        public IPart[] Storage {get;}

        public Assembly[] Components {get;}

        public PartId[] Identifiers {get;}

        public IApiPartCatalog[] Catalogs {get;}

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
            Storage = parts;
            Identifiers = Storage.Select(p => p.Id);
            Components = Storage.Select(p => p.Owner);
            Catalogs = Storage.Select(x => ApiCatalogs.part(x) as IApiPartCatalog).Where(c => c.IsIdentified);
            ApiHosts = Catalogs.SelectMany(c => c.ApiHosts);
            OperationHosts = Catalogs.SelectMany(c => c.OperationHosts).Cast<IApiHost>().Array();
            PartIdentities = Identifiers;
            Operations = Catalogs.SelectMany(x => x.Operations);
        }

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => z.option(ApiHosts.Where(h => h.Uri == uri).FirstOrDefault());

        public IEnumerable<IApiPartCatalog> MatchingCatalogs(params PartId[] parts)
        {
            if(parts.Length == 0)
                return Catalogs;
            else
                return from c in Catalogs
                       where parts.Contains(c.PartId)
                       select c;
        }

        public IEnumerable<IApiHost> DefinedHosts(params PartId[] parts)
        {
            if(parts.Length == 0)
                return ApiHosts;
            else
                return  from h in ApiHosts
                        where parts.Contains(h.PartId)
                        select h;
        }
    }
}