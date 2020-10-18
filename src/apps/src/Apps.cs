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
            => new AppContext(wf.Paths, wf.Api, Polyrand.@default(), WfShell.json(wf.Paths), WfMsgExchange.Create(wf));

        public static IAppContext context()
            => context(WfShell.parts(Assembly.GetEntryAssembly()), WfShell.paths());

        static IAppContext context(ApiPartSet src, IWfPaths paths)
            => new AppContext(paths, src.Api, Polyrand.@default(), WfShell.json(paths), AppMsgExchange.Create());
    }
}