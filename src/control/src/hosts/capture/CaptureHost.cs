//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;
    
    using static Asm.CaptureWorkflowEvents;
    using static ExtractEvents;

    public class CaptureHost : ICaptureHost
    {               
        readonly IAsmContext Context;

        readonly IAppMsgSink Sink;

        readonly CaptureConfig Settings;

        readonly ICaptureArchive Archive;

        readonly AsmWorkflowConfig WorkflowConfig;

        readonly IApiSet ApiSet;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly FolderPath CaptureRoot;
            
        readonly IHostCaptureWorkflow PrimaryWorkflow;

        readonly IImmEmissionWorkflow ImmWorkflow;

        readonly IUriBitsReader UriBitsReader;

        readonly AsmFormatSpec FormatConfig;
        
        public static ICaptureHost Create(IAsmContext context, FolderPath root)    
            => new CaptureHost(context,root);

        static IAsmWorkflows Services(IAsmContext context)
            => AsmWorkflows.Contextual(context);

        static IAsmContextual Core(IAsmContext context)
            => context.Contextual;

        static ICaptureServices Stateless
            => AsmWorkflows.Stateless;

        CaptureHost(IAsmContext context, FolderPath root)
        {                    
            Context = context;
            Sink = context;
            CaptureRoot = root;
            ApiSet = context.ApiSet;
            WorkflowConfig = new AsmWorkflowConfig(root);
            Settings = CaptureConfig.From(context.Settings);            
            Archive = Stateless.CaptureArchive(root);
            FormatConfig = AsmFormatSpec.WithSectionDelimiter;
            Decoder = Stateless.AsmDecoder(FormatConfig);
            Formatter = Core(context).AsmFormatter(FormatConfig);            
            UriBitsReader = Stateless.UriBitsReader;
            PrimaryWorkflow = Services(context).HostCaptureWorkflow(Decoder, Formatter, Stateless.AsmWriterFactory);
            ImmWorkflow = Services(context).ImmEmissionWorkflow(Sink, ApiSet, Formatter, Decoder, root);
            ConnectReceivers(PrimaryWorkflow.EventBroker);
        }

        IChecks Claim => Checks.Checker;

        ICheckEquatable Equatable => CheckEquatable.Checker;

        IAppContext AppContext => Z0.AppContext.Create(ApiSet, 
                Context.Random, Context.Settings, AppMsgExchange.Create(Context));

        public void Dispose()
        {
            term.print($"Commpleted capture workflow");
        }
        
        public void Execute(params PartId[] parts)
        {
            if(Settings.EmitImmArtifacts)
                EmitImm(parts);

            if(Settings.EmitPrimaryArtifacts)
                EmitPrimary(parts);

            if(Settings.CheckExecution)
                CheckExec(parts);
        }

        void EmitImm(params PartId[] parts)
        {
            ImmWorkflow.ClearArchive();
            ImmWorkflow.EmitRefined();
        }

        void EmitPrimary(params PartId[] parts)
        {
            PrimaryWorkflow.Run(WorkflowConfig, parts);
        }

        void CheckExec(params PartId[] parts)
        {            
            var workflow = EvalWorkflow.Create(AppContext, Context.Random, CaptureRoot);
            workflow.Execute(parts);
        }

        void OnEvent(HostFunctionsDecoded e)
        {
            Sink.Deposit(e);

            if(Settings.CollectAsmStats)
                CollectAsmStats(e.Host, e.Payload);
        }

        void OnEvent(HostAsmHexSaved e)
        {
            Sink.Deposit(e);

            if(Settings.MatchEmissions)
                MatchEmissions(e.Host, e.Payload, e.Target);
        }

        void OnEvent(HostMembersLocated e)
        {
            Sink.Deposit(e);

            if(Settings.DuplicateCheck)
                CheckDuplicates(e.Host, e.Members);
        }

        void OnEvent(ExtractReportCreated e)
        {
            Sink.Deposit(e);
        }

        void OnEvent(ExtractReportSaved e)
        {            
            Sink.Deposit(e);
        }

        void OnEvent(ExtractParseFailed e)
        {
            Sink.Deposit(e);
        }
    
        void OnEvent(HostExtractsParsed e)
        {
            Sink.Deposit(e);
        }
    
        void OnEvent(ParseReportCreated e)
        {
            Sink.Deposit(e);
        }

        void OnEvent(AppErrorEvent e)
        {
            Sink.Deposit(e);
        }

        void OnEvent(StepStart<IApiCatalog> e)
        {
            Sink.Deposit(e);
        }

        void OnEvent(StepEnd<IApiCatalog> e)
        {
            Sink.Deposit(e);
        }

        IHostCaptureBroker ConnectReceivers(IHostCaptureBroker broker)
        {
            broker.Error.Subscribe(broker, OnEvent);
            broker.MembersLocated.Subscribe(broker, OnEvent);
            broker.ExtractReportCreated.Subscribe(broker, OnEvent);
            broker.ExtractReportSaved.Subscribe(broker, OnEvent);
            broker.ParseReportCreated.Subscribe(broker, OnEvent);
            broker.FunctionsDecoded.Subscribe(broker, OnEvent);
            broker.HexSaved.Subscribe(broker, OnEvent);            
            broker.ExtractsParsed.Subscribe(broker, OnEvent);
            broker.ExtractParseFailed.Subscribe(broker, OnEvent);            
            broker.CaptureCatalogStart.Subscribe(broker, OnEvent);            
            broker.CaptureCatalogEnd.Subscribe(broker, OnEvent);
            return broker;
        }
        
        void CollectAsmStats(ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            var count = 0ul;
            for(var i = 0; i<functions.Length; i++)
                count += (ulong)skip(functions,i).InstructionCount;
            
            Sink.CountedInstructions(host, count);                   
        }
            
        void MatchEmissions(ApiHostUri host, ReadOnlySpan<UriBits> memSrc, FilePath dst)
        {
            var fileSrc = UriBitsReader.Read(dst).ToArray().ToSpan();                        

            Claim.eq(fileSrc.Length, memSrc.Length);            
            Claim.eq(fileSrc.Count(s => s.Op.IsEmpty), 0);
            
            for(var i=0; i<memSrc.Length; i++)
            {
                Equatable.eq(skip(fileSrc,i).Op, skip(memSrc,i).Op);  
                Equatable.eq(skip(fileSrc,i).Bits.Length, skip(memSrc, i).Bits.Length);
            }

            Sink.MatchedEmissions(host, memSrc.Length, dst);
        }

        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<Member> src)
        {
            var index = Operational.Service.CreateIndex(src);
            foreach(var key in index.DuplicateKeys)
                Sink.DuplicateWarning(host,key);
        }
    }
}