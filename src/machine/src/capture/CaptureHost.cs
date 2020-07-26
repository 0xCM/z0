//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    
    public class CaptureHost : ICaptureHost
    {            
        public static CaptureHost Service(IAppContext context, Arrow<ArchiveConfig> config)   
            => new CaptureHost(ContextFactory.CreateAsmContext(context), config);

        public void Run(params string[] args)
        {
            var parts = PartIdParser.parse(args);
            if(parts.Length != 0)
                term.magenta($"Capturing {parts.Describe()}");            
            else
                term.magenta($"Capturing the known knowns"); 
            Consolidate(parts);
        }
        
        public IAppMsgSink Sink {get;}

        public ICaptureBroker Broker {get;}

        readonly IAsmContext Context;

        readonly CaptureConfig Settings;

        readonly Arrow<ArchiveConfig> Config;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly ICaptureWorkflow CaptureWorkflow;

        readonly IImmEmissionWorkflow ImmWorkflow;

        readonly IEncodedHexReader UriBitsReader;

        readonly AsmFormatSpec FormatConfig;

        readonly TCaptureServices Services;

        readonly uint EvalBufferSize;
        
        internal CaptureHost(IAsmContext context, Arrow<ArchiveConfig> config)
        {                    
            Context = context;
            Sink = context;
            EvalBufferSize = Pow2.T16;
            Config = config;
            Settings = CaptureConfig.From(context.Settings);            
            FormatConfig = AsmFormatSpec.WithSectionDelimiter;
            Formatter = context.CaptureServices.Formatter(FormatConfig);            
            Services = CaptureServices.Service(context);            
            Decoder = Capture.Services.AsmDecoder(FormatConfig);
            UriBitsReader = Capture.Services.EncodedHexReader;
            CaptureWorkflow = Services.CaptureWorkflow(Decoder, Formatter, Capture.Services.CaptureArchive(config.Dst));
            Broker = CaptureWorkflow.Broker;
            ImmWorkflow = Services.ImmEmissionWorkflow(Sink, context.Api, Formatter, Decoder, config);            
            (this as ICaptureClient).Connect();            
        }

        public void Dispose()
        {
            term.print($"Commpleted capture workflow");
            CaptureWorkflow.Dispose();
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

        public void Consolidate(params PartId[] parts)
        {
            if(Settings.EmitPrimaryArtifacts)
                EmitConsolidated(parts);

            if(Settings.EmitImmArtifacts)
                EmitImm(parts);

            if(Settings.CheckExecution)
                CheckExec(parts);
        }

        void EmitImm(params PartId[] parts)
        {
            ImmWorkflow.ClearArchive(parts);
            ImmWorkflow.EmitRefined(parts);
        }

        void EmitPrimary(params PartId[] parts)
            => CaptureWorkflow.Run(Config, parts);

        void EmitConsolidated(params PartId[] parts)
            => CaptureWorkflow.RunConsoidated(Config, parts);

        void CheckExec(params PartId[] parts)
            => Context.CreateEvalWorkflow(Config, EvalBufferSize).Execute(parts);

        public void OnEvent(FunctionsDecoded e)
        {
            Sink.Deposit(e);

            if(Settings.CollectAsmStats)
                CollectAsmStats(e.Host, e.Functions);
        }

        public void OnEvent(HexCodeSaved e)
        {
            Sink.Deposit(e);

            if(Settings.MatchEmissions)
                CaptureWorkflow.MatchEmissions.MatchEmissions(e.Host, e.Code, e.Target);
        }

        public void OnEvent(MembersLocated e)
        {
            Sink.Deposit(e);

            if(Settings.DuplicateCheck)
                CheckDuplicates(e.Host, e.Members);
        }
       
        void CollectAsmStats(ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            var count = 0ul;
            for(var i = 0u; i<functions.Length; i++)
                count += (ulong)z.skip(functions,i).InstructionCount;
            
            Sink.CountedInstructions(host, count);                   
        }
             
        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = ApiMemberOps.Service.CreateIndex(src);
            foreach(var key in index.DuplicateKeys)
                Sink.DuplicateWarning(host,key);
        }
    }
}