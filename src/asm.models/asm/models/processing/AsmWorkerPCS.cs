//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmWorker<P,C,S> : IAsmWorker<AsmWorker<P,C,S>, C, S>
        where P : unmanaged, IAsmWorker
        where C : unmanaged, IAsmOperands
        where S : IAsmWorkerState<C,S>
    {
        [MethodImpl(Inline)]
        public static implicit operator AsmWorker<C,S>(AsmWorker<P,C,S> src)
            => new AsmWorker<C,S>();

        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
            => Generalized.Process(cmd,ref state);

        [MethodImpl(Inline)]
        public void Process(IAsmOperands cmd, ref S state)
            => Generalized.Process(cmd, ref state);

        AsmWorker<C,S> Generalized
        {
            [MethodImpl(Inline)]
            get => default;
        }
    }
}