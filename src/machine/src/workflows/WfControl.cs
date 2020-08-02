//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public ref struct WfControl
    {        
        readonly WfContext Context;
        
        readonly ActorIdentity[] Known;

        readonly string[] Args;
        
        readonly CorrelationToken Correlation;

        [MethodImpl(Inline), Op]
        public static WfControl create(WfContext context, params string[] args)
            => new WfControl(context, args);

        public static void run(IAppContext context, params string[] args)
        {
            var receiver = Flow.TermReceiver;
            using var wf = WfContext.create(context, Flow.config(context, receiver), receiver);
            using var control = WfControl.create(wf, args);
            control.Run();
        }


        [MethodImpl(Inline)]
        WfControl(WfContext context, string[] args, params ActorIdentity[] known)     
        {
            Context = context;
            Args = args;
            Known = known;
            Correlation =  CorrelationToken.define(1ul);
            Context.Running(nameof(WfControl), Correlation);
        }

        public void Run()
        {
            if(CaptureArtifacts)
            {
                using var capture = new CaptureWorkflowHost(Context, Args);
                capture.Run();            
            }

            if(EmitDatasets)
            {
                using var emission = new EmitDatasets(Context, Args);
                emission.Run();
            }                    

        }

        public void Dispose()
        {
            Context.Ran(nameof(WfControl), Correlation);
        }

        bool CaptureArtifacts => true;
        
        bool EmitDatasets => true;
    }
}