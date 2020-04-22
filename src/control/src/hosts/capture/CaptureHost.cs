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
    
    using static Asm.AsmEvents;

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

        readonly IMemberLocator MemberLocator;

        readonly FolderPath CaptureRoot;

        readonly FilePath LogPath;
            
        readonly IHostCaptureWorkflow PrimaryWorkflow;

        readonly IImmEmissionWorkflow ImmWorkflow;

        readonly IUriBitsReader UriBitsReader;
        
        public static ICaptureHost Create(IAsmContext context, FolderPath root)    
            => new CaptureHost(context,root);

        CaptureHost(IAsmContext context, FolderPath root)
        {                    
            Context = context;
            Sink = context;
            CaptureRoot = root;
            ApiSet = context.ApiSet;
            WorkflowConfig = AsmWorkflowConfig.Define(root);
            Settings = CaptureConfig.From(context.Settings);            
            LogPath = (root + FolderName.Define("logs")) + FileName.Define("host","log");
            Archive = CaptureArchive.Create(root);
            Archive.LogDir.Clear();
            MemberLocator = context.MemberLocator();
            Decoder = context.AsmFunctionDecoder();            
            Formatter = context.AsmFormatter(context.AsmFormat.WithSectionDelimiter());
            UriBitsReader = context.UriBitsReader();
            PrimaryWorkflow = HostCaptureWorkflow.Create(context, Decoder, Formatter, context.AsmWriterFactory());
            ImmWorkflow = ImmEmissionWorkflow.Create(context,  context, ApiSet, Formatter, Decoder, root);
            
            ConnectReceivers(PrimaryWorkflow.EventBroker);
        }


        ICheck Claim => ICheck.Checker;

        ICheckEquatable Equatable => CheckEquatable.Checker;

        IApiHost Host(ApiHostUri uri)
            => ApiSet.FindHost(uri).Require();

        public void Dispose()
        {
            term.print($"Commpleted capture workflow");
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
            ImmWorkflow.ClearArchive();
            ImmWorkflow.EmitRefined();
        }

        void EmitPrimary()
        {
            PrimaryWorkflow.Run(WorkflowConfig);
        }

        void Exec()
        {
            var api = Z0.AppContext.Create(ApiSet.Composition, Context.Random, Context.Settings, AppMsgExchange.Create(Context));
            var workflow = EvalWorkflow.Create(api, Context.Random, CaptureRoot);
            workflow.Execute();
        }

        void OnEvent(HostMembersLocated e)
        {
            Sink.Deposit(e);
            Analyze(e.Host, e.Payload);
        }

        void OnEvent(ExtractReportCreated e)
        {
            Sink.Deposit(e);
        }

        void OnEvent(ExtractReportSaved e)
        {            
            Sink.Deposit(e);
        }

        void OnEvent(HostFunctionsDecoded e)
        {
            Sink.Deposit(e);
            Analyze(e.Host, e.Payload);
        }

        void OnEvent(HostAsmHexSaved e)
        {
            Sink.Deposit(e);
            CheckEmission(e.Host, e.Payload, e.Target);
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

            if(Settings.HandleMembersLocated)
                broker.MembersLocated.Subscribe(broker, OnEvent);

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
        
        void Analyze(ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            static int CountInstructions(in AsmFunction f)
                => f.InstructionCount;

            var analyzer = SpanAnalyzer.Create<AsmFunction,int>(CountInstructions);
            var counts = analyzer.Analyze(functions);
            var total = gspan.sum(counts.AsUInt64());
            Sink.CountedInstructions(host, total);                   
        }
            
        void CheckEmission(ApiHostUri host, ReadOnlySpan<UriBits> memSrc, FilePath dst)
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

        void Analyze(ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = src.ToOpIndex();
            foreach(var key in index.DuplicateKeys)
                Sink.DuplicateWarning(host,key);
        }
    }
}