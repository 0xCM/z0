//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;
    
    using static Asm.AsmEvents;
    using static Asm.AsmServiceMessages;

    public class CaptureHost : ICaptureHost
    {               
        readonly IAsmContext Context;

        readonly IAppMsgSink Sink;

        readonly IPolyrand Random;

        readonly CaptureConfig Settings;

        readonly ICaptureArchive Archive;

        readonly AsmWorkflowConfig WorkflowConfig;

        readonly IApiSet ApiSet;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly IMemberLocator MemberLocator;

        readonly FolderPath CaptureRoot;

        readonly FilePath LogPath;
            
        readonly IHostCaptureWorkflow PrimaryWorkflow;

        readonly IImmEmissionWorkflow ImmWorkflow;
        
        public static ICaptureHost Create(IAsmContext context, FolderPath root)    
            => new CaptureHost(context,root);

        CaptureHost(IAsmContext context, FolderPath root)
        {                    
            Context = context;
            Sink = context;
            CaptureRoot = root;
            Random = context.Random;
            ApiSet = context.ApiSet;
            WorkflowConfig = AsmWorkflowConfig.Define(root);
            Settings = CaptureConfig.From(context.Settings);            
            LogPath = (root + FolderName.Define("logs")) + FileName.Define("host","log");
            Archive = CaptureArchive.Define(root);
            Archive.LogDir.Clear();
            MemberLocator = context.MemberLocator();
            Decoder = context.AsmFunctionDecoder();            
            Formatter = context.AsmFormatter(context.AsmFormat.WithSectionDelimiter());

            PrimaryWorkflow = HostCaptureWorkflow.Create(context, Decoder, Formatter, context.AsmWriterFactory());
            ImmWorkflow = ImmEmissionWorkflow.Create(context,  context, ApiSet, Formatter, Decoder, root);
            
            ConnectReceivers(PrimaryWorkflow.EventBroker);

        }

        ApiIndex MemberIndex(IApiHost host)
            => ApiIndex.Create(MemberLocator.Hosted(host));

        Option<IApiHost> Host(ApiHostUri uri)
            => ApiSet.FindHost(uri).TryMap(x => x as IApiHost);        

        void NotifyConsole(AppMsg msg)
            => Sink.NotifyConsole(msg);

        void NotifyConsole(object content, AppMsgColor color = AppMsgColor.Green)
            => Sink.NotifyConsole(content, color);

        public void Dispose()
        {
            term.print($"Writting app messages to {LogPath}");
        }
        
        public void Execute(params string[] args)
        {
            if(Settings.EmitImmArtifacts)
                EmitImm();

            if(Settings.EmitPrimaryArtifacts)
                EmitPrimary();

            if(Settings.CheckExecution)
                Exec();
        }

        void EmitImm()
        {
            var imm8 = new byte[]{3,5,12,9};                        
            //var emitter = ImmEmissionWorkflow.Create(Context,  Context, ApiSet, Formatter, Decoder, CaptureRoot);
            ImmWorkflow.Emit(imm8);            
        }

        void EmitPrimary()
        {
            PrimaryWorkflow.Run(WorkflowConfig);
        }

        void Exec()
        {
            var workflow = EvalWorkflow.Create(Context.ApiContext, Context.Random, CaptureRoot);
            workflow.Execute();
        }

        static string Format(IAppEvent e) => e?.Format() ?? string.Empty;

        void OnEvent(HostMembersLocated e)
        {
            var msg = AppMsg.Colorize(Format(e), AppMsgColor.Cyan);
            NotifyConsole(msg);

            Analyze(e.Host, e.Payload);
        }

        void OnEvent(EmittingImmTargets e)
        {
            var msg = AppMsg.Colorize(Format(e), AppMsgColor.Cyan);
            NotifyConsole(msg);
        }

        void OnEvent(ExtractReportCreated e)
        {
            var msg = AppMsg.Colorize(Format(e), AppMsgColor.Blue);
            NotifyConsole(msg);
        }

        void OnEvent(ExtractReportSaved e)
        {            
            var msg = AppMsg.Colorize(Format(e), AppMsgColor.Cyan);
            NotifyConsole(msg);
        }

        void OnEvent(HostFunctionsDecoded e)
        {
            var msg = AppMsg.Colorize(Format(e), AppMsgColor.Magenta);
            NotifyConsole(msg);
            Analyze(e.Host, e.Payload);
        }

        void OnEvent(HostAsmHexSaved e)
        {
            var msg = AppMsg.Colorize(Format(e), AppMsgColor.Cyan);
            NotifyConsole(msg);
            Analyze(e.Host, e.Payload, e.Target);
        }

        void OnEvent(ParseReportCreated e)
        {
            var msg = AppMsg.Colorize(Format(e), AppMsgColor.Blue);
            NotifyConsole(msg);
        }

        void OnEvent(AppErrorEvent e)
        {
            NotifyConsole(AppMsg.Error(e.Payload));    
        }

        void OnEvent(StepStart<IApiCatalog> e)
        {
            var msg = AppMsg.Colorize($"{Format(e)}: {e.Payload.CatalogName}", AppMsgColor.Green);
            NotifyConsole(msg);
        }

        void OnEvent(StepEnd<IApiCatalog> e)
        {
            var msg = AppMsg.Colorize($"{Format(e)}: {e.Payload.CatalogName}", AppMsgColor.Magenta);
            NotifyConsole(msg);            
        }

        IHostCaptureBroker ConnectReceivers(IHostCaptureBroker broker)
        {
            broker.Error.Subscribe(broker, OnEvent);

            if(Settings.HandleMembersLocated)
                broker.MembersLocated.Subscribe(broker, OnEvent);

            if(Settings.EmitImmArtifacts)
                broker.EmittingImmTargets.Subscribe(broker, OnEvent);

            if(Settings.HandleExtractReportCreated)
                broker.ExtractReportCreated.Subscribe(broker, OnEvent);

            if(Settings.HandleExtractReportSaved)
                broker.ExtractReportSaved.Subscribe(broker, OnEvent);

            if(Settings.HandleParseReportCreated)
                broker.ParseReportCreated.Subscribe(broker, OnEvent);

            if(Settings.HandleFunctionsDecoded)
                broker.FunctionsDecoded.Subscribe(broker, OnEvent);

            if(Settings.HandleParsedExtractSaved)            
                broker.HexSaved.Subscribe(broker, OnEvent);            
            
            broker.CaptureCatalogStart.Subscribe(broker, OnEvent);            
            broker.CaptureCatalogEnd.Subscribe(broker, OnEvent);

            return broker;
        }
        
        void Analyze(in ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            static int CountInstructions(in AsmFunction f)
                => f.InstructionCount;

            var analyzer = SpanAnalyzer.Create<AsmFunction,int>(CountInstructions);
            var counts = analyzer.Analyze(functions);
            var total = gspan.sum(counts.AsUInt64());

            NotifyConsole($"The {host} host members define a total of {total} instructions", AppMsgColor.Cyan);            
        }
            
        void Analyze(in ApiHostUri hosturi, ReadOnlySpan<UriBits> ops, FilePath dst)
        {
            var hosted = Host(hosturi).MapRequired(host => MemberIndex(host));
            var saved = Context.UriBitsReader().Read(dst).ToArray();
            Claim.eq(saved.Length, ops.Length);
            
            var emptycount = saved.Where(s => s.Op.IsEmpty).Count();
            Claim.eq(emptycount,0);

            ref readonly var src = ref head(ops);
            var count = ops.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var subject = ref skip(src, i);   
                Claim.eq(saved[i].Op, subject.Op);  
                Claim.eq(saved[i].Bits.Length, subject.Bits.Length);           
            }
        }

        void Analyze(in ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = src.ToOpIndex();
            foreach(var key in index.DuplicateKeys)
                NotifyConsole(DuplicateWarning(host,key));
        }
    }
}