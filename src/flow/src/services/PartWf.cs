//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using static Konst;
    
    public readonly struct PartWf
    {
        public static PartWfConfig configure(WfContext context, params string[] args)
        {
            var parsed = AppArgs.parse(args).Data.Select(arg => PartIdParser.single(arg.Value));
            var parts = context.Parts;
            var selection = parsed.Length != 0 ? parts.Where(part => parsed.Contains(part.Id)) : parts;
            var srcpath = FilePath.Define(context.GetType().Assembly.Location).FolderPath;
            var dstpath = context.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            return new PartWfConfig(context, src, dst, selection);                    
        }
    }
}