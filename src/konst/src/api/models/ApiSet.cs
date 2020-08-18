//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;

    using static Konst;

    public readonly struct ApiSet : IApiSet
    {
        public static IApiSet create(IResolvedApi resolved)
            => new ApiSet(resolved);

        public IResolvedApi Composition {get;}

        public IApiHost[] Hosts {get;}

        public IPartCatalog[] Catalogs {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}

        public Assembly[] Assemblies {get;}

        public ApiSet(IResolvedApi api)
        {
            Composition = api;
            Parts = api.Resolved;
            Assemblies = Parts.Select(x => x.Owner);
            Catalogs = Parts.Select(x => ApiHosts.catalog(x)).Where(c => c.IsIdentified);
            Hosts = Catalogs.SelectMany(c => c.ApiHosts);
            PartIdentities = api.Resolved.Map(p => p.Id);
        }

        public Option<IPart> FindPart(PartId id)
            => z.option(Parts.FirstOrDefault(p => p.Id == id));

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => z.option(Hosts.Where(h => h.Uri == uri).FirstOrDefault());

        public IEnumerable<IPartCatalog> MatchingCatalogs(params PartId[] parts)
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
                return Hosts;
            else
                return  from h in Hosts
                        where parts.Contains(h.PartId)
                        select h;
        }
    }
}