//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    public readonly struct Processor<C,S> : IProcessor<C,S>
        where C : unmanaged, ICmdData
        where S : IProcessState<C,S>
    {
        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
        {
            state.Handled(cmd);   
        }

        [MethodImpl(Inline)]
        public void Process(ICmdData cmd, ref S state)
            => Process((C)cmd, ref state);
    }
}