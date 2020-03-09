//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;
    using Z0;
    using static Z0.Root;
    using static HostCaptureWorkflow;


    public partial class HostCaptureWorkflow : IWorkflow<HostCaptureWorkflow>, IWorkflowRunner
    {
        readonly IAsmContext Context;

        readonly IWorkflowRunner Runner;
        
        [MethodImpl(Inline)]
        public static IWorkflowRunner Create(IAsmContext context)
            => new HostCaptureWorkflow(context);      

        [MethodImpl(Inline)]
        HostCaptureWorkflow(IAsmContext context)
        {
            this.Context = context;
            this.Runner =new WorkflowRunner(context);       
        }

        IAsmContext IContextual<IAsmContext>.Context 
            => Context;

        void IWorkflowRunner.Run(FolderPath dst)
            => Runner.Run(dst);

        void IWorkflowRunner.Run(RootEmissionPaths root)
            => Runner.Run(root);

        IWorkflowEventBroker IWorkflowRunner.EventBroker 
            => Runner.EventBroker;
    }
}