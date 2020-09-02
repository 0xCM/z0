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
    using static AB;
    using static z;

    public readonly struct WfBuilder
    {
        public static IAppContext app()
        {
            var entry = Assembly.GetEntryAssembly();
            var srcRoot = FS.path(entry.Location).FolderPath;
            var srcArchive = ModuleArchives.from(srcRoot);
            var context = ContextFactory.app(srcArchive, ShellPaths.Default);
            return context;
        }

        public static IAppContext app(IWfShell wf)
            => ContextFactory.app(wf.Modules, ShellPaths.Default);

        [Op]
        public static IWfShell context(WfConfig config, IWfEventSink sink)
            => new WfContext(config, sink);

        [Op]
        public static WfConfig configure(IAppContext app, params string[] args)
        {
            var control = Assembly.GetEntryAssembly();
            var id = control.Id();
            var ct = correlate(id);
            var parts = AB.parts(args, app.Api.PartIdentities);
            var src = ModuleArchives.from(FS.path(control.Location).FolderPath);
            var settings = AB.settings(app);
            var captureOut = FS.dir(app.AppPaths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(app.AppPaths.LogRoot.Name) + FS.folder("capture/logs");
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            var config  = new WfConfig(app, args, src, dstArchive, parts,
                app.AppPaths.ResourceRoot,
                app.AppPaths.AppDataRoot,
                app.AppPaths.AppLogRoot,
                settings);
            return config;
        }

        public static IWfShell context(Assembly control, string[] args, out IAppContext app)
        {
            var id =  control.Id();
            var ct = correlate(id);
            var modules = ModuleArchives.from(control);
            var api = modules.Api;
            var shell = ShellContext.create(control, args, modules);
            var config = new WfConfig(shell, args, modules);

            app = ContextFactory.app(modules, config.Paths);

            return new WfContext(config, WfTermEventSink.create(log(config), ct));
        }

        public static IWfShell context(Assembly control)
        {
            var args = Environment.GetCommandLineArgs();
            var id =  control.Id();
            var ct = correlate(id);
            var modules = ModuleArchives.from(control);
            var api = modules.Api;
            var shell = ShellContext.create(control, args, modules);
            var config = new WfConfig(shell, args, modules);
            return new WfContext(config, WfTermEventSink.create(log(config), ct));
        }
    }
}