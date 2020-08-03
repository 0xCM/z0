//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Text;
    using System.Runtime.CompilerServices;
    using System.Reflection;

    using static Konst;

    partial struct Flow    
    {
        public static PartWfConfig wfconfig(WfContext context, params string[] args)
        {
            var parsed = AppArgs.parse(args).Data.Select(arg => PartIdParser.single(arg.Value));
            var srcpath = FilePath.Define(context.GetType().Assembly.Location).FolderPath;
            var dstpath = context.AppPaths.AppCaptureRoot;
            var src = new ArchiveConfig(srcpath);
            var dst = new ArchiveConfig(dstpath);
            return new PartWfConfig(context, args, src, dst, parsed);                    
        }

        public static WfConfig wfconfig(IAppContext context, IMultiSink sink, CorrelationToken ct)
        {
            var path = Flow.ConfigPath(context);
            sink.Deposit(new LoadingWfConfig(WfEventId.define(nameof(LoadingWfConfig), ct),path));

            var dst = z.dict<string,string>();
            AppSettings.absorb(path,dst);
            var config = new WfConfig(dst);
                        
            sink.Deposit(new LoadedWfConfig(WfEventId.define(nameof(LoadedWfConfig), ct), path, config));            
            return config;
        }        
    }
}