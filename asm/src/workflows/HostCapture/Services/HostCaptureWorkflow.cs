//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static HostCaptureWorkflow;

    public partial class HostCaptureWorkflow : IHostCaptureWorkflow
    {
        public IAsmContext Context {get;}

        readonly IHostCaptureRunner Runner;
        
        [MethodImpl(Inline)]
        public static IHostCaptureRunner Create(IAsmContext context)
            => new HostCaptureWorkflow(context);      

        [MethodImpl(Inline)]
        HostCaptureWorkflow(IAsmContext context)
        {
            this.Context = context;
            this.Runner =new HostCaptureRunner(context);       
        }

        public IHostCaptureEventBroker EventBroker
            => Runner.EventBroker;
 
        void IHostCaptureRunner.Run(FolderPath dst)
            => Runner.Run(dst);

        public void Run(RootEmissionPaths root)
            => Runner.Run(root);
    }
}