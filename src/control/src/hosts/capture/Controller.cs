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
    using static ControllerStep;

    using static z;

    public readonly struct ControllerStep
    {
        public const string ActorName = nameof(Controller);        
    }
    
    readonly ref struct Controller
    {
        readonly IAppContext ContextRoot;

        readonly IAsmContext Asm;
        
        readonly string[] Args;

        readonly CorrelationToken Ct;
        
        readonly WfTermEventSink TermSink;

        readonly WfSettings Config;
        
        readonly WfContext WfContext;        

        readonly TAppPaths Paths;

        public WfState Wf {get;}

        public Controller(IAppContext context, CorrelationToken ct, string[] args)
        {
            ContextRoot = context;
            Args = args;
            Ct = ct;
            TermSink = termsink(Ct);
            Paths = context.AppPaths;
            Asm = ContextFactory.asm(context);                           
            Config = settings(context, Ct);
            WfContext = Flow.context(context, Ct, Config, TermSink);                        
            Wf = new WfState(WfContext, Asm, args, Ct);
            Wf.Created(ActorName, Ct);
        }

        public void Run()
        {
            Wf.Running(ActorName, Ct);

            try
            {
                using var host = new CaptureHost(Wf, Wf.Broker, Wf.Config, Ct);
                host.Run();
            }
            catch(Exception e)
            {
                term.error(e);
                //Wf.Error(ActorName, e,Ct);
            }

            Wf.Ran(ActorName, Ct);
        }

        public void Dispose()
        {
            WfContext.Finished(ActorName, Ct);
        }
    }
}