//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public class AppContext : IAppContext             
    {
        readonly IApiSet Api;

        public IAppSettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue MessageQueue {get;}

        public TAppPaths AppPaths {get;}

        public event Action<IAppMsg> Next;

        public static IAppContext Create(TAppPaths paths, IApiComposition api, IPolyrand random)
            => new AppContext(paths, api, random, AppSettings.Load(paths.AppConfigPath), AppMsgExchange.Create());

        public static IAppContext Create(IApiComposition composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
            => new AppContext(composition, random, settings, queue);

        public static IAppContext Create(IApiSet api, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
            => new AppContext(api, random, settings, queue);

        AppContext(IApiComposition composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
        {
            AppPaths = Z0.AppPaths.Default;
            Next = msg => {};
            Random = random;
            Settings = settings ?? AppSettings.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = ApiSet.Create(composition);
        }

        AppContext(TAppPaths paths, IApiComposition composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
        {
            AppPaths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? AppSettings.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = ApiSet.Create(composition);
        }

        AppContext(IApiSet api, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
        {
            AppPaths = Z0.AppPaths.Default;
            Next = msg => {};
            Random = random;
            Settings = settings ?? AppSettings.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = api;
        }

        public IApiComposition Composition 
            => Api.Composition;

        public IApiHost[] Hosts  
            => Api.Hosts;

        public IApiCatalog[] Catalogs 
            => Api.Catalogs;

        public IPart[] Parts 
            => Api.Parts;

        public PartId[] PartIdentities 
            => Api.PartIdentities;
    }
}