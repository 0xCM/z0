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
        public static WfConfig configure(IAppContext context, string[] args, CorrelationToken ct)
        {
            // var parts = PartIdParser.Service.ParseValid(args); 
            // if(parts.Length == 0)
            //     parts = context.PartIdentities;

            var parts = PartIdParser.parse(args,context.PartIdentities);
            var settings = Flow.settings(context, ct);
            var src = new ArchiveConfig(FilePath.Define(context.GetType().Assembly.Location).FolderPath);            
            var dst = new ArchiveConfig(context.AppPaths.AppCaptureRoot);
            return new WfConfig(args, src, dst, parts, context.AppPaths.ResourceRoot, context.AppPaths.AppDataRoot, settings);
        }
    }
}