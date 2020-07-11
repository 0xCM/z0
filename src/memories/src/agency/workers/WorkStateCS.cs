//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Konst;

    /// <summary>
    /// Tracks the state of a process stream and the commands that effected the state
    /// </summary>
    public struct WorkState<C,S> : IWorkState<C,S>
        where C : unmanaged, IOperands
    {
        internal S Current;

        List<C> Commands;

        [MethodImpl(Inline)]
        public WorkState(S state)
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
        
        public WorkState Generalized
            => new WorkState(Current, from c in Processed select c as IOperands);
    }
}