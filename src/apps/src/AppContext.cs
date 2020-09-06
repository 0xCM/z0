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
        public ApiParts Api {get;}

        public ISettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue MessageQueue {get;}

        public IShellPaths Paths {get;}

        public event Action<IAppMsg> Next;

        public AppContext(ApiParts parts, IPolyrand random, ISettings settings, IAppMsgQueue queue)
        {
            Paths = Z0.ShellPaths.Default;
            Next = msg => {};
            Random = random;
            Settings = settings ?? SettingValues.Load(Paths.AppConfigPath);
            MessageQueue = queue;
            Api = parts;
        }

        public AppContext(IShellPaths paths, ApiParts parts, IPolyrand random, ISettings settings, IAppMsgQueue queue)
        {
            Paths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? SettingValues.Load(Paths.AppConfigPath);
            MessageQueue = queue;
            Api = parts;
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