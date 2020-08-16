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

    using static Konst;
    
    public struct WorkState
    {
        internal object Current;
        
        List<IAsmOperands> Commands;

        public object State 
            => Current;

        [MethodImpl(Inline)]
        public WorkState(object state, Seq<IAsmOperands> commands)
        {
            Current = state;
            Commands = commands.ToList();
        }

        [MethodImpl(Inline)]
        public WorkState(object state)
        {
            Current = state;
            Commands = new List<IAsmOperands>();
        }

        public void Handled(IAsmOperands cmd)
            => Commands.Add(cmd);        
    }
}