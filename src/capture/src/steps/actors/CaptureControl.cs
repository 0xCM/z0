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
    using static Flow;
    using static CaptureController;

    using static z;
    
    public readonly ref struct CaptureControl
    {        
        readonly IAppContext ContextRoot;

        readonly IAsmContext Asm;
        
        readonly CorrelationToken Ct;
        
        
        readonly IWfContext WfContext;        

        readonly IAppPaths Paths;

        public WfState Wf {get;}

        public CaptureControl(IAppContext context, CorrelationToken ct, WfConfig config)
        {
            ContextRoot = context;
            Ct = ct;
            Paths = context.AppPaths;
            Asm = WfBuilder.asm(context);                           
            WfContext = Flow.context(context, config, Ct);                        
            Wf = new WfState(WfContext, Asm, config, Ct);
            Wf.Created(ActorName, Ct);
        }

        public void Run()
        {
            Wf.Running(ActorName, Ct);

            try
            {
                using var host = new CaptureClient(Wf, Ct);
                host.Run();
            }
            catch(Exception e)
            {
                Wf.Error(ActorName, e, Ct);
            }

            Wf.Ran(ActorName, Ct);
        }

        public void Dispose()
        {
            WfContext.Finished(ActorName, Ct);
        }
    }
}