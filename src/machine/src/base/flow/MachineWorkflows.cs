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
        readonly WorkflowIdentity[] Known;
        
        readonly EventBroker Broker;

        readonly IAppContext Context;

        internal MachineWorkflows(IAppContext context)
        {
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
            Known = z.array(
                WorkflowIdentity.define<MachineWorkflows>(PartId.Machine),                
                EmitResBytes.Identity
                );
        }
        
        public void Dispose()
            => Broker.Dispose();

        public void Run()
            => AppDataEmitter.Service.Emit(Context);
    }
}