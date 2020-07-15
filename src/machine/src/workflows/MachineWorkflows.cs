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
    
    public readonly struct MachineWorkflows : IWorkflowStep<MachineWorkflows>, IWorkflowSteps<MachineWorkflows>, IDisposable
    {
        readonly EventBroker Broker;

        readonly IAppContext Context;

        [MethodImpl(Inline)]
        public static MachineWorkflows create(IAppContext context)
            => new MachineWorkflows(context);

        [MethodImpl(Inline)]
        MachineWorkflows(IAppContext context)
        {
            Broker = new EventBroker(context.AppPaths.AppStandardOutPath);
            Context = context;
        }
        
        public void Dispose()
        {
            Broker.Dispose();
        }

        public void Run()
        {
            AppDataEmitter.Service.Emit(Context);            
        }
    }
}