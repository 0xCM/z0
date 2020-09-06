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
        public ResolvedApi Composition {get;}

        public IApiHost[] Hosts {get;}

        public IPartCatalog[] Catalogs {get;}

        public ApiParts Parts {get;}

        public PartId[] PartIdentities {get;}

        public Assembly[] Components {get;}

        public IApiHost[] DataTypes {get;}

        public IApiHost[] OpHosts {get;}

        public ApiSet(ResolvedApi api)
        {
            Composition = api;
            Parts = api.Resolved;
            Components = Parts.Components;
            Catalogs = Parts.Catalogs;
            Hosts = Catalogs.SelectMany(c => c.ApiHosts);
            PartIdentities = api.Resolved.Map(p => p.Id);
            DataTypes = Catalogs.SelectMany(c => c.ApiDataTypes).Cast<IApiHost>().Array();
            OpHosts = Catalogs.SelectMany(c => c.Operations).Cast<IApiHost>().Array();
        }


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