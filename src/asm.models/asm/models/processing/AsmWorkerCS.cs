//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct AsmWorker<C,S> : IAsmWorker<C,S>
        where C : unmanaged, IAsmOperands
        where S : IAsmWorkerState<C,S>
    {
        [MethodImpl(Inline)]
        public void Process(in C cmd, ref S state)
        {
            state.Handled(cmd);
        }

        [MethodImpl(Inline)]
        public void Process(IAsmOperands cmd, ref S state)
            => Process((C)cmd, ref state);
    }
}