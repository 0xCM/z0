//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    using static Konst;
    using static Memories;

    public interface IApiSet
    {
        IPart[] Parts {get;}   

        IApiCatalog[] Catalogs {get;}

        PartId[] PartIdentities {get;}

        IApiHost[] Hosts {get;}

        IResolvedApi Composition {get;}

        Option<IPart> FindPart(PartId id)
            => option(Parts.FirstOrDefault(p => p.Id == id));      

        Option<IApiHost> FindHost(ApiHostUri uri)
            => option(Hosts.Where(h => h.Uri == uri).FirstOrDefault());
        
        IEnumerable<IApiCatalog> MatchingCatalogs(params PartId[] parts)
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