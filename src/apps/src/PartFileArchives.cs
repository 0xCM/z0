//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct PartFileArchives
    {
        public static Arrow<ArchiveConfig> configure(IAppContext context, params string[] args)
        {
            var parsed = AppArgs.parse(args);            
            var inarg = parsed.Data.TryGetFirst(x => x.Name == "indir").ValueOrDefault(AppArg.Empty);
            var indir = FilePath.Define(context.GetType().Assembly.Location).FolderPath;
            if(inarg.IsNonEmpty)
                indir = FolderPath.Define(inarg.Value);
            var outarg = parsed.Data.TryGetFirst(x => x.Name == "outdir").ValueOrDefault(AppArg.Empty);
            var outdir = context.AppPaths.AppCaptureRoot;
            if(outarg.IsNonEmpty)
                outdir = FolderPath.Define(outarg.Value);
            return Arrows.link(new ArchiveConfig(indir), new ArchiveConfig(outdir));
        }
    }
}