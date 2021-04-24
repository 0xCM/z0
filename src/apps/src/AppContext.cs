//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public class AppContext : IAppContext
    {
        public IApiRuntimeCatalog RuntimeCatalog {get;}

        public IJsonSettings Settings {get;}

        public IPolyrand Random {get;}

        public IMessageQueue MessageQueue {get;}

        public IAppPaths Paths {get;}

        public IApiParts ApiParts {get;}

        public event Action<IAppMsg> Next;

        public AppContext(IAppPaths paths, IApiRuntimeCatalog catalog, IPolyrand random, IJsonSettings settings, IMessageQueue queue)
        {
            Paths = paths;
            Next = msg => {};
            Random = random;
            Settings = settings;
            MessageQueue = queue;
            RuntimeCatalog = catalog;
            ApiParts = ApiQuery.parts();
        }
    }
}