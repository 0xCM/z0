//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using Z0.Asm;
    
    using static CaptureHostStep;

    public struct CaptureHost : ICaptureClient, IDisposable
    {                    
        public void Run()
        {   
            Wf.Running(ActorName, Ct);         
            (this as ICaptureClient).Connect();             
            var parts = Config.Parts.Length == 0 ? Wf.ContextRoot.PartIdentities : Config.Parts;                
            Wf.Raise(new CapturingParts(parts, Ct));
            Consolidate(parts);
            Wf.Ran(ActorName, Ct);
        }

        readonly WfContext Wf;

        readonly WfConfig Config;

        readonly WfState State;

        readonly IAsmContext Context;

        readonly CorrelationToken Ct;

        readonly ICaptureWorkflow CWf;

        public ICaptureBroker Broker {get;}

        readonly CaptureConfig Settings;
        
        public IMultiSink Sink {get;}
        
        readonly IAsmFormatter Formatter;

        readonly IAsmFunctionDecoder Decoder;

        readonly IImmEmissionWorkflow ImmWorkflow;

        readonly IEncodedHexReader UriBitsReader;

        readonly AsmFormatSpec FormatConfig;

        readonly TCaptureServices Services;

        readonly uint EvalBufferSize;
        
        public CaptureHost(WfState wf, ICaptureBroker broker, WfConfig config, CorrelationToken ct)
        {                            
            State = wf;
            Wf = State.Wf;
            Ct = ct;
            CWf = wf.CWf;
            Sink = Wf.TermSink;
            Broker = broker;
            Context = wf.Asm;
            EvalBufferSize = Pow2.T16;
            Config = config;
            FormatConfig = wf.FormatConfig;
            Formatter = wf.Formatter;
            Services = wf.Services;
            Decoder = wf.Decoder;
            Settings = CaptureConfig.From(wf.ContextRoot.Settings);            
            UriBitsReader = Services.EncodedHexReader;
            ImmWorkflow = Services.ImmEmissionWorkflow(Sink, Context.Api, Formatter, Decoder, config, Ct);     

            Wf.Created(ActorName, Ct);       
        }

        public void Dispose()
        {
            Wf.Finished(nameof(CaptureHost), Ct);
        }
        
        void Consolidate(params PartId[] parts)
        {
            var wf = ManagePartCapture.create(State, Ct);
            wf.Consolidate();                

            EmitImm(parts);

            ExecuteCode(parts);
        }

        void EmitImm(params PartId[] parts)
        {
            ImmWorkflow.ClearArchive(parts);
            ImmWorkflow.EmitRefined(parts);
        }

        void EmitPrimary(params PartId[] parts)
        {
            var wf = ManagePartCapture.create(State, Ct);
            wf.Run();
        }

        void ExecuteCode(params PartId[] parts)
        {
            var app = Context.ContextRoot;
            var exchange = AppMsgExchange.Create(app.MessageQueue);
            var archiveRoot = app.AppPaths.AppCaptureRoot;            
            var evwf = Evaluate.workflow(app, app.Random, archiveRoot, Pow2.T14); 
            evwf.Execute(parts);
        }

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
            {
                var step = new MatchEmissions(CWf, Ct);
                step.Run(e.Host, e.Code, e.Target);
            }
        }

        public void OnEvent(MembersLocated e)
        {
            Sink.Deposit(e);

            if(Settings.DuplicateCheck)
                CheckDuplicates(e.Host, e.Members);
        }
       
        void CollectAsmStats(ApiHostUri host, ReadOnlySpan<AsmFunction> functions)
        {
            var count = 0u;
            for(var i = 0u; i<functions.Length; i++)
                count += (uint)z.skip(functions,i).InstructionCount;
            
           Wf.Raise(new CountedInstructions(ActorName, host, count, Ct));                   
        }
             
        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = ApiMemberOps.Service.CreateIndex(src);
            foreach(var key in index.DuplicateKeys)
            {
                //Sink.DuplicateWarning(host,key);
            }
        }
    }
}