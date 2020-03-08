//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public static partial class HostCaptureWorkflow
    {
        [MethodImpl(Inline)]
        public static IWorkflowService Create(IAsmContext context)
            => new WorkflowService(context);       
    }
}