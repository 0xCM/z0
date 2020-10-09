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
        public SystemApiCatalog Api {get;}

        public IJsonSettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue MessageQueue {get;}

        public IShellPaths Paths {get;}

        public event Action<IAppMsg> Next;

        public AppContext(SystemApiCatalog parts, IPolyrand random, IJsonSettings settings, IAppMsgQueue queue)
        {
            Paths = Z0.ShellPaths.Default;
            Next = msg => {};
            Random = random;
            Settings = settings ?? JsonSettings.Load(Paths.AppConfigPath);
            MessageQueue = queue;
            Api = parts;
        }

        public AppContext(IShellPaths paths, SystemApiCatalog parts, IPolyrand random, IJsonSettings settings, IAppMsgQueue queue)
        {
            Paths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? JsonSettings.Load(Paths.AppConfigPath);
            MessageQueue = queue;
            Api = parts;
        }

        public PartId[] PartIdentities
            => Api.PartIdentities;
    }
}