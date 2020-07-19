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
        
    [ApiHost("workflows")]
    public readonly partial struct MachineWorkflows : IWorkflowStep<MachineWorkflows>, IWorkflowSteps<MachineWorkflows>, IDisposable
    {        
        public static MachineWorkflows create(IAppContext context)
            => new MachineWorkflows(context);

        readonly WorkflowIdentity[] Known;
        
        readonly EventBroker Broker;

        readonly IAppContext Context;

        public WorkflowIdentity[] Identified
        {
            [MethodImpl(Inline), Op]
            get => Known;
        }

        [MethodImpl(Inline), Op]
        public ref readonly WorkflowIdentity Identify(MachineWorkflowId id)
            => ref Known[(byte)id];

        [MethodImpl(Inline)]
        MachineWorkflows(IAppContext context)
        {
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
            Known = z.array(
                Workflows.identify(PartId.Machine, nameof(MachineWorkflows)),                
                EmitResBytes.Identity
                );
        }
        
        public void Dispose()
            => Broker.Dispose();

        public void Run()
            => AppDataEmitter.Service.Emit(Context);
    }
}