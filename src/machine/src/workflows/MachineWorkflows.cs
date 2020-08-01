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

        readonly MachineContext Context;

        readonly bool CaptureArtifacts;

        MachineWorkflowConfig Config
            => Context.ContextData;        
        
        readonly string[] Args;

        internal MachineWorkflows(MachineContext context, params string[] args)
        {
            Args = args ?? sys.empty<string>();
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
            Known = sys.empty<ActorIdentity>();
            CaptureArtifacts = false;
            Context.ContextRoot.Controlling(nameof(MachineWorkflow));         
        }
        
        public void Run()
        {
            if(Config.EnableCapture)
            {
                using var capture = new CaptureWorkflowHost(Context.ContextRoot, Args);
                capture.Run();            
            }
            
            using var emission = new EmissionWorkflow(Context.ContextRoot, Args);
            emission.Run();
        }

        public void Dispose()
        {
            Broker.Dispose();
            Context.ContextRoot.Controlled(nameof(MachineWorkflow));
        }
    }
}