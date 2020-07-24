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

    [ApiHost]
    public partial struct Workflows
    {        
        readonly IAppContext Context;

        readonly ActorIdentity[] Known;

        long Correlation;
                
        [MethodImpl(Inline)]
        public static T worker<T>()
            where T : struct, IWorkflowWorker<T>
                => default;        
        public static MachineWorkflows machine(IAppContext context)
            => MachineWorkflows.alloc(context);
    }
}