//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public interface IAsmWorker
    {
        void Process(IAsmOperands args, IAsmWorkerState state)
        {


        }
    }

    public interface IAsmWorker<C>: IAsmWorker
        where C : IAsmOperands
    {

    }

    public interface IAsmWorker<C,S> : IAsmWorker<C>
        where C : unmanaged, IAsmOperands
        where S : IAsmWorkerState
    {
        void Process(in C cmd, ref S state);

        [MethodImpl(Inline)]
        void Process(IAsmOperands cmd, ref S state)
            => Process((C)cmd, ref state);
    }

    public interface IAsmWorker<P,C,S> : IAsmWorker<C>
        where P : unmanaged, IAsmWorker<P,C,S>
        where C : unmanaged, IAsmOperands
        where S : IAsmWorkerState
    {
        void Process(in C cmd, ref S state);
    }
}