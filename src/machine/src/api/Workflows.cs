//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static Memories;

    public readonly struct Workflows
    {
        [MethodImpl(Inline)]
        public static MachineWorkflow machine(IMachineContext context)
            => new MachineWorkflow(context, context.TargetRoot);
    }
}