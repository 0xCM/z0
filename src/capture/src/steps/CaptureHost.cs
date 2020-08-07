//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static CaptureHostStep;

    public struct CaptureClient : ICaptureClient
    {                    
        public void Run()
        {   
            Wf.Running(ActorName, Ct);         
            (this as ICaptureClient).Connect();             
            var parts = Wf.Config.Parts.Length == 0 ? Wf.ContextRoot.PartIdentities : Wf.Config.Parts;                
            Wf.Raise(new CapturingParts(parts, Ct));
            Consolidate(parts);
            Wf.Ran(ActorName, Ct);
        }

        readonly WfState Wf;

        readonly CorrelationToken Ct;

        public ICaptureBroker Broker {get;}
        
        public IMultiSink Sink {get;}
        
        readonly IImmEmissionWorkflow ImmWorkflow;
        
        public CaptureClient(WfState wf, CorrelationToken ct)
        {                            
            Wf = wf;
            Ct = ct;
            Sink = Wf.Wf.TermSink;
            Broker = wf.CaptureBroker;
            ImmWorkflow = Wf.Services.ImmEmissionWorkflow(Sink, Wf.Asm.Api, Wf.Formatter, Wf.FunctionDecoder, Wf.Config, Ct);     
            Wf.Created(ActorName, Ct);       
        }

        public void Dispose()
        {
            Wf.Finished(nameof(CaptureClient), Ct);
        }
        
        void Consolidate(params PartId[] parts)
        {
            var wf = ManagePartCapture.create(Wf, Ct);
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
            var wf = ManagePartCapture.create(Wf, Ct);
            wf.Run();
        }

        void ExecuteCode(params PartId[] parts)
        {
            var app = Wf.ContextRoot;
            var exchange = AppMsgExchange.Create(app.MessageQueue);
            var archiveRoot = app.AppPaths.AppCaptureRoot;            
            var evwf = Evaluate.workflow(app, app.Random, archiveRoot, Pow2.T14); 
            evwf.Execute(parts);
        }

        public void OnEvent(FunctionsDecoded e)
        {
            Sink.Deposit(e);

            if(Wf.Settings.CollectAsmStats)
                CollectAsmStats(e.Host, e.Functions);
        }

        public void OnEvent(HexCodeSaved e)
        {
            Sink.Deposit(e);

            if(Wf.Settings.MatchEmissions)
            {
                var step = new MatchEmissions(Wf.CWf, Ct);
                step.Run(e.Host, e.Code, e.Target);
            }
        }

        public void OnEvent(MembersLocated e)
        {
            Sink.Deposit(e);

            if(Wf.Settings.DuplicateCheck)
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