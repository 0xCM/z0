//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Text;
    using System.Reflection;

    using static Konst;

    public readonly struct Flow
    {
        public static IMultiSink TermReceiver 
            => WfTermEventSink.create();

        public static FilePath ConfigPath(IAppContext context)
        {
            var assname = Assembly.GetEntryAssembly().GetSimpleName();
            var filename = FileName.Define(assname, FileExtensions.Json);
            var src = context.AppPaths.ConfigRoot + filename;
            return src;
        }

        public static IMultiSink log(IAppContext context)
            => new WfEventLog(
                    context.AppPaths.AppStandardOutPath.ChangeExtension(FileExtensions.Csv), 
                    context.AppPaths.AppErrorOutPath.ChangeExtension(FileExtensions.Csv), 
                    multisink(WfTermEventSink.create())
                    );
        
        [MethodImpl(Inline)]
        public static IMultiSink multisink(IAppEventSink sink)
            => new MultiSink(sink);        

        public static WfConfig config(IAppContext context, IMultiSink sink)
        {
            var path = Flow.ConfigPath(context);
            var ct = CorrelationToken.create();
            sink.Deposit(new LoadingWfConfig(WfEventId.define(nameof(LoadingWfConfig), ct),path));

            var dst = z.dict<string,string>();
            AppSettings.absorb(path,dst);
            var config = new WfConfig(dst);
                        
            sink.Deposit(new LoadedWfConfig(WfEventId.define(nameof(LoadedWfConfig), ct), path, config));            
            return config;
        }
    }
}