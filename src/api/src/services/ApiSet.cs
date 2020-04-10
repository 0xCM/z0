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
        public IApiComposition Composition {get;}

        public IApiHost[] Hosts {get;}

        public IApiCatalog[] Catalogs {get;}

        public IPart[] Parts {get;}

        public PartId[] PartIdentities {get;}

        [MethodImpl(Inline)]
        public static ApiSet Create(IApiComposition composition)
            => new ApiSet(composition);
                
        [MethodImpl(Inline)]
        ApiSet(IApiComposition api)
        {
            Composition = ApiComposition.Assemble(api.Resolved);
            Catalogs = api.Catalogs.ToArray();    
            Hosts = (from owner in Catalogs.SelectMany(c => c.ApiHosts).GroupBy(x => x.Owner)
                from  host in owner
                select host as IApiHost).ToArray();     
            Parts = Composition.Resolved;       
            PartIdentities = Parts.Map(p => p.Id);            
        }

        public Option<IApiHost> FindHost(ApiHostUri uri)
            => option(Hosts.Where(h => h.UriPath == uri).FirstOrDefault());

        public Option<IPart> FindPart(PartId id)
            => option(Parts.FirstOrDefault(p => p.Id == id));
    }
}