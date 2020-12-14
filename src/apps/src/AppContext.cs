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
        public ISystemApiCatalog Api {get;}

        public IJsonSettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue MessageQueue {get;}

        public IWfAppPaths Paths {get;}

        public IApiParts ApiParts {get;}

        public event Action<IAppMsg> Next;

        public AppContext(IWfAppPaths paths, ISystemApiCatalog parts, IPolyrand random, IJsonSettings settings, IAppMsgQueue queue)
        {
            Paths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? JsonSettings.Load(Paths.AppConfigPath);
            MessageQueue = queue;
            Api = parts;
            ApiParts = WfShell.parts();
        }
    }
}