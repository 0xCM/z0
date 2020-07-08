//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ApiSet : IApiSet
    {
        public static IApiSet Create(IResolvedApi resolved)
            => new ApiSet(resolved);

        public IResolvedApi Composition {get;}

        public IApiHost[] Hosts {get;}

        public IPartCatalog[] Catalogs {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}
                
        internal ApiSet(IResolvedApi api)
        {
            Composition = api;
            Catalogs = api.Catalogs.ToArray();    
            Hosts = (from owner in Catalogs.SelectMany(c => c.Hosts).GroupBy(x => x.PartId)
                from  host in owner
                select host as IApiHost).ToArray();     
            Parts = api.Resolved;       
            PartIdentities = api.Resolved.Map(p => p.Id);            
        }
    }
}