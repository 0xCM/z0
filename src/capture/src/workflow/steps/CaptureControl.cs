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
        readonly IAppContext Root;

        readonly IAsmContext Asm;
        
        readonly CorrelationToken Ct;        
        
        readonly IWfContext Wf;        

        readonly IAppPaths Paths;

        public WfCaptureState State {get;}

        public CaptureControl(WfCaptureState state)
        {
            State = state;
            Root = state.Root;
            Ct = state.Ct;
            Paths = Root.AppPaths;
            Asm = WfBuilder.asm(Root);                           
            Wf = state.Wf;
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