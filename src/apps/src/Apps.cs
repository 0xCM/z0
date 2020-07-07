//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public readonly struct Apps
    {

        public static IAppContext context(TAppPaths paths, IResolvedApi api, IPolyrand random)
            => new AppContext(paths, api, random, AppSettings.Load(paths.AppConfigPath), AppMsgExchange.Create());

        public static IAppContext context(IResolvedApi composition, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
            => new AppContext(composition, random, settings, queue);

        public static IAppContext context(IApiSet api, IPolyrand random, IAppSettings settings, IAppMsgQueue queue)
            => new AppContext(api, random, settings, queue);
    }
}