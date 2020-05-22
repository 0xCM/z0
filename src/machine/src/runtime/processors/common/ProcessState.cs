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

    using static Seed;
    using static Memories;

    public struct ProcessState
    {
        internal object Current;
        
        List<ICommand> Commands;

        public object State => Current;

        [MethodImpl(Inline)]
        internal ProcessState(object state, Seq<ICommand> commands)
        {
            Current = state;
            Commands = commands.ToList();
        }

        [MethodImpl(Inline)]
        internal ProcessState(object state)
        {
            Current = state;
            Commands = new List<ICommand>();
        }

        public void Handled(ICommand cmd)
            => Commands.Add(cmd);        
    }
}