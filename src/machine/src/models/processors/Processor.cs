//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm.Data;
    
    using static Seed;

    public readonly struct Processor : IProcessor
    {
        [MethodImpl(Inline)]
        public void Process(ICmdData cmd, IProcessState state)
        {
            state.Handled(cmd);
        }
    }
}