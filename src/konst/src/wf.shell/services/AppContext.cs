//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AppContext : IAppContext
    {
        public IGlobalApiCatalog ApiGlobal {get;}

        public IJsonSettings Settings {get;}

        public IPolyrand Random {get;}

        public IAppMsgQueue MessageQueue {get;}

        public IWfAppPaths Paths {get;}

        public IApiParts ApiParts {get;}

        public event Action<IAppMsg> Next;

        public AppContext(IWfAppPaths paths, IGlobalApiCatalog catalog, IPolyrand random, IJsonSettings settings, IAppMsgQueue queue)
        {
            Paths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings ?? JsonSettings.Load(Paths.AppConfigPath);
            MessageQueue = queue;
            ApiGlobal = catalog;
            ApiParts = WfShell.parts();
        }
    }
}