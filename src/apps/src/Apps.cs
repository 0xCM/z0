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
        public static IAppContext context(ApiParts composition, IPolyrand random, ISettings settings, IAppMsgQueue queue)
            => new AppContext(composition, random, settings, queue);

        public static IWfShell shell(Assembly control, string[] args, out IAppContext app)
        {
            var shell = Flow.shell(control, args);
            app = context(shell.Modules, shell.Paths);
            return shell;
        }

        public static IAppContext context(IWfShell wf)
            => context(wf.Modules, wf.Paths);

        public static IAppContext context()
        {
            var entry = Assembly.GetEntryAssembly();
            var srcRoot = FS.path(entry.Location).FolderPath;
            var modules = ApiQuery.modules(srcRoot);
            return context(modules, ShellPaths.Default);
        }

        public static WfInit init(Assembly control, string[] args)
        {
            var modules = ApiQuery.modules(control, args);
            return new WfInit(Flow.context(control, modules, args), args, modules);
        }

        public static IAppContext context(ApiModules src, IShellPaths paths)
            => new AppContext(paths, src.Api, random(), settings(paths), exchange());

        static ISettings settings(IShellPaths paths)
            => SettingValues.Load(paths.AppConfigPath);

        static AppMsgExchange exchange()
            => AppMsgExchange.Create();

        static IPolyrand random()
            => Polyrand.Pcg64(PolySeed64.Seed05);
    }
}