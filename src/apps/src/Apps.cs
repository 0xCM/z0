//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    public readonly struct Apps
    {
        public static IAppContext context(IWfShell wf)
            => new AppContext(wf.Paths, wf.Api, Rng.@default(), WfShellInit.json(wf.Paths), WfMsgExchange.Create(wf));

        public static IAppContext context()
            => context(WfShellInit.parts(Assembly.GetEntryAssembly()), WfShellInit.paths());

        static IAppContext context(ApiPartSet src, IWfPaths paths)
            => new AppContext(paths, src.Api, Rng.@default(), WfShellInit.json(paths), AppMsgExchange.Create());
    }
}