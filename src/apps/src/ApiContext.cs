//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public class AppContext : IAppContext             
    {
        [MethodImpl(Inline)]
        public static IAppContext Create(IApiComposition composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
            => new AppContext(composition, random, settings ?? AppSettings.Empty, queue);
        
        [MethodImpl(Inline)]
        AppContext(IApiComposition composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
        {
            Next = msg => {};
            Random = random;
            Settings = settings;
            Messaging = queue;
            Api = ApiSet.Create(composition);
        }

        readonly IApiSet Api;

        public IAppSettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue Messaging {get;}

        public event Action<IAppMsg> Next;

        public IApiComposition Composition => Api.Composition;

        public IApiHost[] Hosts  => Api.Hosts;

        public IApiCatalog[] Catalogs => Api.Catalogs;

        public IPart[] Parts => Api.Parts;

        public PartId[] PartIdentities => Api.PartIdentities;
    }
}