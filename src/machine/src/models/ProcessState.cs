//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machines
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
        
        List<ICmdData> Commands;

        public object State => Current;

        [MethodImpl(Inline)]
        internal ProcessState(object state, Seq<ICmdData> commands)
        {
            Current = state;
            Commands = commands.ToList();
        }

        [MethodImpl(Inline)]
        internal ProcessState(object state)
        {
            Current = state;
            Commands = new List<ICmdData>();
        }

        public void Handled(ICmdData cmd)
            => Commands.Add(cmd);        
    }
}