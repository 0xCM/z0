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

    public readonly struct Processor : IProcessor
    {
        [MethodImpl(Inline)]
        public void Process(ICmd cmd, IProcessState state)
        {
            state.Handled(cmd);
        }
    }
}