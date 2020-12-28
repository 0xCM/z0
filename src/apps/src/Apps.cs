//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Part;

    public readonly struct Apps
    {
        public static IAppContext context(IWfShell wf)
            => new AppContext(wf.Paths, wf.Api, Rng.@default(), WfShell.json(wf.Paths), WfMsgExchange.Create(wf));

        public static IAppContext context(IWfShell wf, IPolyrand random)
            => new AppContext(wf.Paths, wf.Api, random, WfShell.json(wf.Paths), WfMsgExchange.Create(wf));

        public static IAppContext context()
            => context(WfShell.parts(Assembly.GetEntryAssembly()), WfShell.paths());

        static IAppContext context(ApiPartSet src, IWfAppPaths paths)
            => new AppContext(paths, src.Api, Rng.@default(), WfShell.json(paths), AppMsgExchange.Create());
    }
}