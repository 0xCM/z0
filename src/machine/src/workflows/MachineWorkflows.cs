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
        
    public readonly partial struct MachineWorkflows : IWorkflowStep<MachineWorkflows>, IWorkflowSteps<MachineWorkflows>, IDisposable
    {        
        public static MachineWorkflows alloc(IAppContext context)
            => new MachineWorkflows(context);
        
        readonly ActorIdentity[] Known;
        
        readonly EventBroker Broker;

        readonly IAppContext Context;

        readonly bool CaptureArtifacts;
        MachineWorkflows(IAppContext context)
        {
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
            Known = sys.empty<ActorIdentity>();
            CaptureArtifacts = false;
        }
        
        public void Run(params string[] args)
        {
            var config = PartFileArchives.configure(Context,args);
            if(CaptureArtifacts)
                CaptureHost.Service(Context, config).Run(args);            
            new EmissionWorkflow(Context).Run();
        }

        public void Dispose()
            => Broker.Dispose();
    }
}