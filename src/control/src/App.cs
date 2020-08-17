//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using Z0.Asm;
    using static FS;

    class App : AppShell<App,IAppContext>
    {               
        [Op]
        public static WfConfig configure(IAppContext context, string[] args, CorrelationToken ct)
        {            
            var parts = PartIdParser.parse(args, context.PartIdentities);
            var settings = Flow.settings(context, ct);
            var paths = context.AppPaths;
            var captureOut = FS.dir(paths.LogRoot.Name) + FS.folder("capture/artifacts");
            var captureLog = FS.dir(paths.LogRoot.Name) + FS.folder("capture/logs");
            var srcArchive = new ArchiveConfig(FilePath.Define(context.GetType().Assembly.Location).FolderPath);            
            var dstArchive = new ArchiveConfig(FolderPath.Define(captureOut.Name));
            var config  = new WfConfig(args, srcArchive, dstArchive, parts, context.AppPaths.ResourceRoot, context.AppPaths.AppDataRoot, settings);
            config.LogRoot = captureLog;
            config.StatusPath = captureLog + FS.file("status", ExtensionNames.csv);
            config.ErrorPath = captureLog + FS.file("errors", ExtensionNames.csv);
            return config;
        }

        public const PartId Part = PartId.Control;
        
        public const string PartName = nameof(PartId.Control);

        public const string ActorName = PartName + "/" + nameof(App);

        public CorrelationToken Ct {get;}         
                        
        public App()
            : base(WfBuilder.app())
        {
            Ct = CorrelationToken.from(Part);               
        }
        
        public override void RunShell(params string[] args)
        {         
            try
            {
                var context = Context;
                var config = configure(context, args, Ct);
                using var log = WfTermEventLog.create(config.StatusPath, config.ErrorPath);
                using var termSink = Flow.termsink(log, Ct);                
                using var wf = new WfContext(context, Ct, config, termSink);
                using var control = new CaptureControl(new WfCaptureState(wf, new AsmContext(context), config, Ct));
                control.Run();                
            }
            catch(Exception e)
            {
                Raise(Flow.error(ActorName, e, Ct));
            }
            
        }

        public static void Main(params string[] args)
            => Launch(args);
    }

    public static partial class XTend { }
}