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
        
    public readonly partial struct MachineWorkflows : IDisposable
    {        
        readonly ActorIdentity[] Known;
        
        readonly EventBroker Broker;

        readonly CorrelationToken Correlation;
        
        readonly Wf Context;

        readonly bool CaptureArtifacts;
        
        readonly string[] Args;

        internal MachineWorkflows(Wf context, CorrelationToken ct,  params string[] args)
        {
            CaptureArtifacts = false;
            Args = args ?? sys.empty<string>();
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
            Known = sys.empty<ActorIdentity>();
            Correlation = ct;
            Context.Running(nameof(MachineWorkflow), ct);         
        }
        
        public void Run()
        {
            if(CaptureArtifacts)
            {
                using var capture = new CaptureWorkflowHost(Context.ContextRoot, Args);
                capture.Run();            
            }
            
            using var emission = new EmitDatasets(Context, Args);
            emission.Run();
        }

        public void Dispose()
        {
            Broker.Dispose();
            Context.ContextRoot.Controlled(nameof(MachineWorkflow));
        }
    }
}