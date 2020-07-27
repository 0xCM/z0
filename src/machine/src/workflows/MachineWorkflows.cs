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

        MachineWorkflows(IAppContext context)
        {
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
            Known = sys.empty<ActorIdentity>();
        }
        
        public void Run(params string[] args)
        {
            var config = PartFileArchives.configure(Context,args);
            //CaptureHost.Service(Context, config).Run(args);
            EmissionWorkflow.Service(Context).Run(args);
        }

        public void Dispose()
            => Broker.Dispose();
    }
}