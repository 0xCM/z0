//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public class AppContext : IAppContext             
    {
        readonly IApiSet Api;

        public IAppSettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue MessageQueue {get;}

        public IAppPaths AppPaths {get;}

        public event Action<IAppMsg> Next;

        public static IAppContext create(IAppPaths paths, IResolvedApi api, IPolyrand random)
            => new AppContext(paths, api, random, AppSettings.Load(paths.AppConfigPath), AppMsgExchange.Create());

        public static IAppContext create(IResolvedApi composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
            => new AppContext(composition, random, settings, queue);

        public static IAppContext create(IApiSet api, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
            => new AppContext(api, random, settings, queue);

        internal AppContext(IResolvedApi composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
        {            
            AppPaths = Z0.AppPaths.Default;
            Next = msg => {};
            Random = random;
            Settings = settings ?? AppSettings.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = ApiSet.create(composition);
        }

        internal AppContext(IAppPaths paths, IResolvedApi composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
        {
            AppPaths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? AppSettings.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = ApiSet.create(composition);
        }

        internal AppContext(IApiSet api, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
        {
            AppPaths = Z0.AppPaths.Default;
            Next = msg => {};
            Random = random;
            Settings = settings ?? AppSettings.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = api;
        }

        public IResolvedApi Composition 
            => Api.Composition;

        public IApiHost[] Hosts  
            => Api.Hosts;

        public IPartCatalog[] Catalogs 
            => Api.Catalogs;

        public IPart[] Parts 
            => Api.Parts;

        public PartId[] PartIdentities 
            => Api.PartIdentities;
    }
}