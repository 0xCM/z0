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

    public interface IApiSet : IApiProvider
    {
        IPartCatalog[] Catalogs {get;}

        IApiHost[] Hosts {get;}

        ResolvedApi Composition {get;}

        // IApiHost[] DataTypes
        //     => Catalogs.SelectMany(c => c.ApiDataTypes).Cast<IApiHost>().Array();

        IApiHost[] OpHosts
            => Catalogs.SelectMany(c => c.Operations).Cast<IApiHost>().Array();

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