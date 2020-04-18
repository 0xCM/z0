//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct ApiSet : IApiSet
    {
        [MethodImpl(Inline)]
        public static IApiSet Create(IApiComposition composition)
            => new ApiSet(composition);

        public IApiComposition Composition {get;}

        public IApiHost[] Hosts {get;}

        public IApiCatalog[] Catalogs {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}
                
        ApiSet(IApiComposition api)
        {
            //Composition = ApiComposition.Assemble(api.Resolved);
            Composition = api;
            Catalogs = api.Catalogs.ToArray();    
            Hosts = (from owner in Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner)
                from  host in owner
                select host as IApiHost).ToArray();     
            Parts = api.Resolved;       
            PartIdentities = api.Resolved.Map(p => p.Id);            
        }
    }
}