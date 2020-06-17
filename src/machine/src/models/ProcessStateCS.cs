//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Machine
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using Z0.Asm;

    using static Konst;
    using static Memories;

    /// <summary>
    /// Tracks the state of a process stream and the commands that effected the state
    /// </summary>
    public struct ProcessState<C,S> : IProcessState<C,S>
        where C : unmanaged, ICmd
    {
        internal S Current;

        List<C> Commands;

        [MethodImpl(Inline)]
        internal ProcessState(S state)
        {
            Current = state;
            Commands = new List<C>();
        }

        public S Evolved 
        {
            [MethodImpl(Inline)]
            get => Current;
        }

        /// <summary>
        /// Specifies the command process history
        /// </summary>
        public Seq<C> Processed
        {
            [MethodImpl(Inline)]
            get => new Seq<C>(Commands);
        }

        public void Handled(in C cmd)
            => Commands.Add(cmd);
        
        public ProcessState Generalized
            => new ProcessState(Current, from c in Processed select c as ICmd);
    }
}