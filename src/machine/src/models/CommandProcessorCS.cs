//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using Z0.Asm;

    using static Konst;

    public readonly struct CommandProcessor<C,S> : ICommandProcessor<C,S>
        where C : unmanaged, IOperands
        where S : ICommandProcessorState<C,S>
    {
        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
        {
            state.Handled(cmd);   
        }

        [MethodImpl(Inline)]
        public void Process(IOperands cmd, ref S state)
            => Process((C)cmd, ref state);
    }
}