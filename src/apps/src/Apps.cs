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
            => new AppContext(wf.Paths, wf.Api, Polyrand.@default(), settings(wf.Paths), WfMsgExchange.Create(wf));

        public static IAppContext context(IWfShell wf, IPolyrand random)
            => new AppContext(wf.Paths, wf.Api, random, settings(wf.Paths), WfMsgExchange.Create(wf));

        public static IAppContext context()
            => context(WfCore.modules(Assembly.GetEntryAssembly()), ShellPaths.Default);

        public static IAppContext context(ApiPartSet src, IShellPaths paths)
            => new AppContext(paths, src.Api, Polyrand.@default(), settings(paths), AppMsgExchange.Create());

        static IJsonSettings settings(IShellPaths paths)
            => JsonSettings.Load(paths.AppConfigPath);
    }
}