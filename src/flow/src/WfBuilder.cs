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

        [Op]
        public static IWfContext context(IAppContext root, WfConfig config, IWfEventLog log, CorrelationToken ct)
            => new WfContext(root, ct, config, AB.termsink(log, ct));

        [Op]
        public static WfConfig configure(params string[] args)
        {
            return configure(ShellPaths.Default, args);
        }

        [Op]
        public static WfConfig configure(IShellPaths paths, params string[] args)
        {
            var entry = Assembly.GetEntryAssembly();
            var srcRoot = FS.path(entry.Location).FolderPath;
            var srcArchive = ModuleArchives.from(srcRoot,"Private.CoreLib");
            var context = ContextFactory.app(srcArchive, paths);
            return configure(context, args);
        }

        [Op]
        public static WfConfig configure(IAppContext context, params string[] args)
        {
            var root = Assembly.GetEntryAssembly();
            var id = root.Id();
            var ct = correlate(id);
            var parts = AB.parts(args, context.Api.PartIdentities);
            var src = ModuleArchives.from(FS.path(root.Location).FolderPath,"Private.CoreLib");
            var settings = AB.settings(context, ct);
            var captureOut = FS.dir(context.AppPaths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(context.AppPaths.LogRoot.Name) + FS.folder("capture/logs");
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            var config  = new WfConfig(context, args, src, dstArchive, parts,
                context.AppPaths.ResourceRoot,
                context.AppPaths.AppDataRoot,
                context.AppPaths.AppLogRoot,
                settings);
            return config;
        }
    }
}