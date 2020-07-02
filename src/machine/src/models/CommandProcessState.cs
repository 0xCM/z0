//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Konst;

    public struct CommandProcessorState
    {
        internal object Current;
        
        List<IOperands> Commands;

        public object State 
            => Current;

        [MethodImpl(Inline)]
        public CommandProcessorState(object state, Seq<IOperands> commands)
        {
            Current = state;
            Commands = commands.ToList();
        }

        [MethodImpl(Inline)]
        public CommandProcessorState(object state)
        {
            Current = state;
            Commands = new List<IOperands>();
        }

        public void Handled(IOperands cmd)
            => Commands.Add(cmd);        
    }
}