//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Seed;
    using static Memories;

    public class ApiContext : IApiContext             
    {
        [MethodImpl(Inline)]
        public static IApiContext Create(IApiComposition composition, IPolyrand random, IAppSettings settings, IAppMsgExchange exchange)
            => new ApiContext(composition, random, settings ?? AppSettings.Empty, exchange);
        
        [MethodImpl(Inline)]
        ApiContext(IApiComposition composition, IPolyrand random, IAppSettings settings, IAppMsgExchange exchange)
        {
            Next = msg => {};
            Random = random;
            Settings = settings;
            Messaging = exchange;
            Api = ApiSet.Create(composition);
        }

        readonly IApiSet Api;

        public IAppSettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgExchange Messaging {get;}

        public event Action<IAppMsg> Next;

        public IApiComposition Composition => Api.Composition;

        public IApiHost[] Hosts  => Api.Hosts;

        public IApiCatalog[] Catalogs => Api.Catalogs;

        public IPart[] Parts => Api.Parts;

        public PartId[] PartIdentities => Api.PartIdentities;
    }
}