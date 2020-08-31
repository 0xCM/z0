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

    public interface IApiSet
    {
        IPart[] Parts {get;}

        IPartCatalog[] Catalogs {get;}

        PartId[] PartIdentities {get;}

        IApiHost[] Hosts {get;}

        IResolvedApi Composition {get;}

        Assembly[]  Components
            => Parts.Select(p => p.Owner);

        IApiHost[] ApiDataTypes
            => Catalogs.SelectMany(c => c.ApiDataTypes).Cast<IApiHost>().Array();

        IApiHost[] ApiOpHosts
            => Catalogs.SelectMany(c => c.Operations).Cast<IApiHost>().Array();

        Option<IPart> FindPart(PartId id)
            => z.option(Parts.FirstOrDefault(p => p.Id == id));

        Option<IApiHost> FindHost(ApiHostUri uri)
            => z.option(Hosts.Where(h => h.Uri == uri).FirstOrDefault());

        IEnumerable<IPartCatalog> MatchingCatalogs(params PartId[] parts)
        {
            if(parts.Length == 0)
                return Catalogs;
            else
                return  from c in Catalogs
                        where parts.Contains(c.PartId)
                        select c;
        }

        IEnumerable<IApiHost> DefinedHosts(params PartId[] parts)
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