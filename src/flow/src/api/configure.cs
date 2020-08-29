//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Flow
    {
        [Op]
        public static WfConfig configure2(IAppContext context, string[] args, CorrelationToken ct)
        {
            z.insist(context.PartIdentities.Length != 0, $"Context knows no parts");
            var parts = PartIdParser.parse(args, context.PartIdentities);
            var settings = Flow.settings(context, ct);
            var paths = context.AppPaths;
            var captureOut = FS.dir(paths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(paths.LogRoot.Name) + FS.folder("capture/logs");
            var srcArchive = new ArchiveConfig(ModuleArchives.executing().Root);
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            var config  = new WfConfig(args, srcArchive, dstArchive, parts,
                context.AppPaths.ResourceRoot,
                context.AppPaths.AppDataRoot,
                context.AppPaths.AppLogRoot,
                settings);
            return config;
        }

        [MethodImpl(Inline)]
        public static ConfiguredStep<T> configured<T>(T step, params WfStepArg[] args)
            where T : struct, IWfStep<T>
                => new ConfiguredStep<T>(step, args);
        [Op]
        public static WfConfig configure(IAppContext context, string[] args, CorrelationToken ct)
        {
            var parts = PartIdParser.parse(args, context.PartIdentities);
            var settings = Flow.settings(context, ct);
            var src = new ArchiveConfig(FilePath.Define(context.GetType().Assembly.Location).FolderPath);
            var dst = new ArchiveConfig(context.AppPaths.AppCaptureRoot);
            return new WfConfig(args, src, dst, parts,
                context.AppPaths.ResourceRoot,
                context.AppPaths.AppDataRoot,
                context.AppPaths.AppLogRoot,
                settings);
        }

        [Op]
        public static WfConfig configure(IAppContext context, string[] args, FolderPath target, CorrelationToken ct)
        {
            var parts = PartIdParser.parse(args, context.PartIdentities);
            var logs = context.AppPaths.AppLogRoot;
            var settings = Flow.settings(context, ct);
            var src = new ArchiveConfig(FilePath.Define(context.GetType().Assembly.Location).FolderPath);
            var dst = new ArchiveConfig(target);
            return new WfConfig(args, src, dst, parts,
                context.AppPaths.ResourceRoot,
                context.AppPaths.AppDataRoot,
                context.AppPaths.AppLogRoot,
                settings);
        }
    }
}