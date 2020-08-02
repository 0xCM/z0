//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    
    public class CaptureHost : ICaptureHost, IDisposable
    {            
        public void Run()
        {   
            Wf.Running(nameof(CaptureHost), Ct);         
            (this as ICaptureClient).Connect();             
            var parts = Config.Parts.Length == 0? Wf.ContextRoot.PartIdentities : Config.Parts;                
            Wf.Raise(new CapturingParts(parts, Ct));
            Consolidate(parts);
        }
        
        readonly CorrelationToken Ct;

        readonly WfContext Wf;

        readonly ICaptureWorkflow CWf;

        readonly string[] Args;
        
        public IWfEventSink Sink {get;}

        public ICaptureBroker Broker {get;}

        readonly IAsmContext Context;

        readonly CaptureConfig Settings;

        readonly PartWfConfig Config;

        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly ICaptureWorkflow CaptureWorkflow;

        readonly IImmEmissionWorkflow ImmWorkflow;

        readonly IEncodedHexReader UriBitsReader;

        readonly AsmFormatSpec FormatConfig;

        readonly TCaptureServices Services;

        readonly uint EvalBufferSize;
        
        internal CaptureHost(WfContext wf, IAsmContext asm, ICaptureWorkflow cwf, ICaptureBroker broker, PartWfConfig config, CorrelationToken ct)
        {                            
            Wf = wf;                
            Ct = ct;
            CWf = cwf;
            Sink = wf.Sink;
            Broker = broker;
            Context = asm;

            Wf.Status("Initializing capture host", ct);
            Args = config.Args;
            EvalBufferSize = Pow2.T16;
            Config = config;
            Settings = CaptureConfig.From(wf.ContextRoot.Settings);            
            FormatConfig = AsmFormatSpec.WithSectionDelimiter;
            Formatter = Context.CaptureServices.Formatter(FormatConfig);            
            Services = CaptureServices.create(Context);            
            Decoder = Capture.Services.AsmDecoder(FormatConfig);
            UriBitsReader = Capture.Services.EncodedHexReader;
            CaptureWorkflow = Services.CaptureWorkflow(Decoder, Formatter, Capture.Services.CaptureArchive(config.Target));
            ImmWorkflow = Services.ImmEmissionWorkflow(Sink, Context.Api, Formatter, Decoder, config);            
            Wf.Status("Completed host initialization sequence", ct);                       
        }

        public void Dispose()
        {
            Wf.Ran(nameof(CaptureHost), Ct);
            CaptureWorkflow.Dispose();
        }
        
        void Execute(params PartId[] parts)
        {
            if(Settings.EmitImmArtifacts)
                EmitImm(parts);

            if(Settings.EmitPrimaryArtifacts)
                EmitPrimary(parts);

            if(Settings.CheckExecution)
                CheckExec(parts);
        }

        void Consolidate(params PartId[] parts)
        {
            if(Settings.EmitPrimaryArtifacts)
            {
                var wf = ManageCaptureStep.create(CWf, Config, Ct);
                wf.Consolidate();                
            }

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
        {
            var wf = ManageCaptureStep.create(CWf, Config);            
            wf.Run();
        }

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