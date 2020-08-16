//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static CaptureClientStep;

    public struct CaptureClient : IWfCaptureClient
    {                    
        readonly WfCaptureState Wf;

        readonly CorrelationToken Ct;

        public IWfCaptureBroker Broker {get;}
        
        public IMultiSink Sink {get;}
        
        readonly IImmEmitter ImmWorkflow;
        
        public CaptureClient(WfCaptureState wf, CorrelationToken ct)
        {                            
            Wf = wf;
            Ct = ct;
            Sink = Wf.Wf.WfSink;
            Broker = wf.CaptureBroker;
            ImmWorkflow = Wf.Services.ImmEmissionWorkflow(Sink, Wf.Asm.Api, Wf.Formatter, Wf.FunctionDecoder, Wf.Config, Ct);     
            Wf.Created(StepName, Ct);       
        }

        public void Dispose()
        {
            Wf.Finished(nameof(CaptureClient), Ct);
        }

        public void Run()
        {
            (this as IWfCaptureClient).Connect();             

            var parts = Wf.Config.Parts.Length == 0 ? Wf.ContextRoot.PartIdentities : Wf.Config.Parts;
            Wf.Raise(new CapturingParts(StepName, parts, Ct));

            using var manage = ManagePartCapture.create(Wf, Ct);
            manage.Consolidate();                

            ImmWorkflow.ClearArchive(parts);
            ImmWorkflow.EmitRefined(parts);

            var eval = Evaluate.workflow(Wf.ContextRoot, Wf.ContextRoot.Random, Wf.ContextRoot.AppPaths.AppCaptureRoot, Pow2.T14); 
            eval.Execute();            

            Wf.Ran(StepName, Ct);
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
            
           Wf.Raise(new CountedInstructions(StepName, host, count, Ct));                   
        }
             
        void CheckDuplicates(ApiHostUri host, ReadOnlySpan<ApiMember> src)
        {
            var index = ApiMemberOps.Service.CreateIndex(src);
            foreach(var key in index.DuplicateKeys)
                Wf.Raise(new WfWarn<string>(StepName, $"Duplicate key {key}", Ct));
        }
    }
}