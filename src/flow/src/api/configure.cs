//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial struct Flow
    {
        [Op]
        public static WfConfig configure2(IAppContext context, string[] args, CorrelationToken ct)
        {
            insist(context.PartIdentities.Length != 0, $"Context knows no parts");
            var parts = AB.parts(args, context.PartIdentities);
            var settings = AB.settings(context, ct);
            var captureOut = FS.dir(context.AppPaths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(context.AppPaths.LogRoot.Name) + FS.folder("capture/logs");
            var srcArchive = new ArchiveConfig(ModuleArchives.entry("Private.CoreLib").Root);
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            var config  = new WfConfig(args, srcArchive, dstArchive, parts,
                context.AppPaths.ResourceRoot,
                context.AppPaths.AppDataRoot,
                context.AppPaths.AppLogRoot,
                settings);
            return config;
        }

        [Op]
        public static WfConfig configure(IAppContext context, string[] args, CorrelationToken ct)
        {
            var parts = AB.parts(args, context.PartIdentities);
            var settings = AB.settings(context, ct);
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
            var parts = AB.parts(args, context.PartIdentities);
            var logs = context.AppPaths.AppLogRoot;
            var settings = AB.settings(context, ct);
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