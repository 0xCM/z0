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

    public struct CaptureClient : ICaptureClient
    {                    
        readonly WfState Wf;

        readonly CorrelationToken Ct;

        public ICaptureBroker Broker {get;}
        
        public IMultiSink Sink {get;}
        
        readonly IImmEmissionWorkflow ImmWorkflow;
        
        public CaptureClient(WfState wf, CorrelationToken ct)
        {                            
            Wf = wf;
            Ct = ct;
            Sink = Wf.Wf.WfSink;
            Broker = wf.CaptureBroker;
            ImmWorkflow = Wf.Services.ImmEmissionWorkflow(Sink, Wf.Asm.Api, Wf.Formatter, Wf.FunctionDecoder, Wf.Config, Ct);     
            Wf.Created(ActorName, Ct);       
        }

        public void Dispose()
        {
            Wf.Finished(nameof(CaptureClient), Ct);
        }

        public void Run()
        {
            (this as ICaptureClient).Connect();             

            var parts = Wf.Config.Parts.Length == 0 ? Wf.ContextRoot.PartIdentities : Wf.Config.Parts;
            Wf.Raise(new CapturingParts(ActorName, parts, Ct));

            using var manage = ManagePartCapture.create(Wf, Ct);
            manage.Consolidate();                

            ImmWorkflow.ClearArchive(parts);
            ImmWorkflow.EmitRefined(parts);

            var eval = Evaluate.workflow(Wf.ContextRoot, Wf.ContextRoot.Random, Wf.ContextRoot.AppPaths.AppCaptureRoot, Pow2.T14); 
            eval.Execute();            

            Wf.Ran(ActorName, Ct);
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
                Wf.Raise(new WfWarn<string>(ActorName, $"Duplicate key {key}", Ct));
        }
    }
}