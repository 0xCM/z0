//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct Worker<P,C,S> : IWorker<Worker<P,C,S>, C, S>
        where P : unmanaged, IWorker
        where C : unmanaged, IAsmOperands
        where S : IWorkState<C,S>
    {
        [MethodImpl(Inline)]
        public static implicit operator Worker<C,S>(Worker<P,C,S> src)
            => new Worker<C,S>();

        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
            => Generalized.Process(cmd,ref state);

        [MethodImpl(Inline)]
        public void Process(IAsmOperands cmd, ref S state)
            => Generalized.Process(cmd, ref state);

        Worker<C,S> Generalized
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}