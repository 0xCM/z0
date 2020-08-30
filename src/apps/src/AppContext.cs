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
        public IApiSet Api {get;}

        public ISettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue MessageQueue {get;}

        public IShellPaths AppPaths {get;}

        public event Action<IAppMsg> Next;

        public AppContext(IResolvedApi composition, IPolyrand random, ISettings settings, IAppMsgQueue queue)
        {
            AppPaths = Z0.ShellPaths.Default;
            Next = msg => {};
            Random = random;
            Settings = settings ?? SettingValues.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = ApiQuery.apiset(composition);
        }

        public AppContext(IShellPaths paths, IResolvedApi composition, IPolyrand random, ISettings settings, IAppMsgQueue queue)
        {
            AppPaths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? SettingValues.Load(AppPaths.AppConfigPath);
            MessageQueue = queue;
            Api = ApiQuery.apiset(composition);
        }

        public AppContext(IShellPaths paths, IApiSet api, IPolyrand random, ISettings settings, IAppMsgQueue queue)
        {
            AppPaths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? SettingValues.Load(AppPaths.AppConfigPath);
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