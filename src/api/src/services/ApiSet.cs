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
        readonly ApiComposition Composition;

        public ApiHost[] Hosts {get;}

        public IApiCatalog[] Catalogs {get;}

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
                select host).ToArray();            
        }

        public readonly IPart[] Parts => Composition.Resolved;

        public Option<ApiHost> FindHost(ApiHostUri uri)
            => Hosts.Where(h => h.UriPath == uri).FirstOrDefault();

        public Option<IPart> FindPart(PartId id)
            => option(Parts.FirstOrDefault(p => p.Id == id));

        IApiComposition IApiContext.Composition 
            => Composition;

        IEnumerable<PartId> IApiContext.Components
            => from r in Parts select r.Id;

        IEnumerable<ApiHost> IApiContext.Hosts
            => Hosts;

    }
}