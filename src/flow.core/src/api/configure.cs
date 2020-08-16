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
        public static WfConfig configure(IAppContext context, string[] args, CorrelationToken ct)
        {
            var parts = PartIdParser.parse(args, context.PartIdentities);
            var settings = Flow.settings(context, ct);
            var src = new ArchiveConfig(FilePath.Define(context.GetType().Assembly.Location).FolderPath);            
            var dst = new ArchiveConfig(context.AppPaths.AppCaptureRoot);
            return new WfConfig(args, src, dst, parts, context.AppPaths.ResourceRoot, context.AppPaths.AppDataRoot, settings);
        }

        [Op]
        public static WfConfig configure(IAppContext context, string[] args, FolderPath target, CorrelationToken ct)
        {
            var parts = PartIdParser.parse(args, context.PartIdentities);
            var settings = Flow.settings(context, ct);
            var src = new ArchiveConfig(FilePath.Define(context.GetType().Assembly.Location).FolderPath);            
            var dst = new ArchiveConfig(target);
            return new WfConfig(args, src, dst, parts, context.AppPaths.ResourceRoot, context.AppPaths.AppDataRoot, settings);
        }
    }
}