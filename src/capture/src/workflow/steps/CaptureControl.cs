//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static Konst;
    using static WfCaptureControl;

    using static z;
    
    public readonly ref struct CaptureControl
    {                
        readonly IAppContext ContextRoot;

        readonly IAsmContext Asm;
        
        readonly CorrelationToken Ct;        
        
        readonly IWfContext Wf;        

        readonly IAppPaths Paths;

        public WfCaptureState State {get;}

        public CaptureControl(WfCaptureState state)
        {
            State = state;
            ContextRoot = state.ContextRoot;
            Ct = state.Ct;
            Paths = ContextRoot.AppPaths;
            Asm = WfBuilder.asm(ContextRoot);                           
            Wf = Flow.context(ContextRoot, state.Config, Ct);    
            State.Created(ActorName, Ct);
        }

        public void Run()
        {
            State.Running(ActorName, Flow.delimit(Wf.Config.Parts), Ct);

            try
            {
                using var host = new CaptureClient(State, Ct);
                host.Run();
            }
            catch(Exception e)
            {
                State.Error(ActorName, e, Ct);
            }

            State.Ran(ActorName, Ct);
        }

        public void Dispose()
        {
            Wf.Finished(ActorName, Ct);
        }
    }
}