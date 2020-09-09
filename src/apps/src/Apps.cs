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

        public static IAppContext context()
        {
            var entry = Assembly.GetEntryAssembly();
            var srcRoot = FS.path(entry.Location).FolderPath;
            var modules = ApiQuery.modules(srcRoot);
            return context(modules, ShellPaths.Default);
        }

        public static WfConfig configure(IAppContext app, string[] args)
        {
            var control = Assembly.GetEntryAssembly();
            var id = control.Id();
            var ct = z.correlate(id);
            var parts = Flow.parts(args, app.Api.PartIdentities);
            var src = ApiQuery.modules(FS.path(control.Location).FolderPath);
            var settings = Flow.settings(app);
            var captureOut = FS.dir(app.Paths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(app.Paths.LogRoot.Name) + FS.folder("capture/logs");
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            var config  = new WfConfig(app, args, src, dstArchive, parts,
                app.Paths.ResourceRoot,
                app.Paths.AppDataRoot,
                app.Paths.AppLogRoot,
                settings);
            return config;
        }

        // public static IAppContext context()
        //     => context(ShellPaths.Default, compose(ApiQuery.parts()), random());

        public static IAppContext context(ApiModules src, IShellPaths paths)
            => new AppContext(paths, src.Api, random(), settings(paths), exchange());

        static IAppContext context(IShellPaths paths, ApiParts api, IPolyrand random)
            => new AppContext(paths, api, random, settings(paths), exchange());

        static ISettings settings(IShellPaths paths)
            => SettingValues.Load(paths.AppConfigPath);

        static AppMsgExchange exchange()
            => AppMsgExchange.Create();

        static ApiParts compose(IPart[] parts)
            => ApiQuery.api(parts);

        static IPolyrand random()
            => Polyrand.Pcg64(PolySeed64.Seed05);
    }
}