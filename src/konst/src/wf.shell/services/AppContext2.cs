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

        public IAppPaths Paths {get;}

        public IApiParts ApiParts {get;}

        public event Action<IAppMsg> Next;

        public AppContext(IAppPaths paths, IGlobalApiCatalog catalog, IPolyrand random, IJsonSettings settings, IAppMsgQueue queue)
        {
            Paths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings;
            MessageQueue = queue;
            ApiGlobal = catalog;
            ApiParts = WfShell.parts();
        }
    }
}