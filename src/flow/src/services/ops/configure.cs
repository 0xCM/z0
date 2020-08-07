//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    partial struct Flow    
    {
        public static WfConfig configure(WfContext context, params string[] args)
        {
            var parsed = AppArgs.parse(args).Data.Select(arg => PartIdParser.single(arg.Value));
            var srcpath = FilePath.Define(context.GetType().Assembly.Location).FolderPath;
            var dstpath = context.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            return new WfConfig(args, src, dst, parsed);                    
        }

        public static WfConfig configure(IAppContext context, PartId[] parts, params string[] args)
        {
            var srcpath = FilePath.Define(context.GetType().Assembly.Location).FolderPath;            
            var src = new ArchiveConfig(srcpath);            
            var dstpath = context.AppPaths.AppCaptureRoot;        
            var dst = new ArchiveConfig(dstpath);
            return new WfConfig(args, src, dst, parts);                    
        }
    }
}