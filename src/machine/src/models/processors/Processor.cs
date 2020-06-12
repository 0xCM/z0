//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;
    
    using static Seed;

    public readonly struct Processor : IProcessor
    {
        [MethodImpl(Inline)]
        public void Process(ICmd cmd, IProcessState state)
        {
            state.Handled(cmd);
        }
    }
}