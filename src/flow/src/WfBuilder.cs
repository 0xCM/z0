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
    using static Flow;
    using static z;

    public readonly struct WfBuilder
    {
        public static IAppContext app()
        {
            var entry = Assembly.GetEntryAssembly();
            var srcRoot = FS.path(entry.Location).FolderPath;
            var modules = ApiQuery.modules(srcRoot);
            return ContextFactory.app(modules, ShellPaths.Default);
        }

        public static IWfShell shell(Assembly control, string[] args, out IAppContext app)
        {
            var id =  control.Id();
            var ct = correlate(id);
            var modules = ApiQuery.modules(control, args);
            var api = modules.Api;
            var shell = Flow.context(control, modules, args);
            var config = new WfConfig(shell, args, modules);
            app = ContextFactory.app(modules, config.Paths);
            return new WfShell(config, WfTermLog.create(log(config), ct));
        }

        public static WfConfig configure(IAppContext app, string[] args)
        {
            var control = Assembly.GetEntryAssembly();
            var id = control.Id();
            var ct = correlate(id);
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

        public static WfConfig configure(IAppContext app)
            => configure(app, Environment.GetCommandLineArgs());
    }
}