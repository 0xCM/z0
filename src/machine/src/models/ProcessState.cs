//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    using Z0.Asm;

    using static Seed;
    using static Memories;

    public struct ProcessState
    {
        internal object Current;
        
        List<ICmd> Commands;

        public object State => Current;

        [MethodImpl(Inline)]
        internal ProcessState(object state, Seq<ICmd> commands)
        {
            Current = state;
            Commands = commands.ToList();
        }

        [MethodImpl(Inline)]
        internal ProcessState(object state)
        {
            Current = state;
            Commands = new List<ICmd>();
        }

        public void Handled(ICmd cmd)
            => Commands.Add(cmd);        
    }
}