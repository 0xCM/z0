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

    public readonly struct CommandProcessor : ICommandProcessor
    {
        [MethodImpl(Inline)]
        public void Process(IOperands cmd, ICommandProcessorState state)
        {
            state.Handled(cmd);
        }
    }
}