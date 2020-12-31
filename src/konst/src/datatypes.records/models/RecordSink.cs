//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct RecordSink<T> : IRecordSink<T>
        where T : struct
    {
        readonly Receiver<T> Receiver;

        [MethodImpl(Inline)]
        public RecordSink(Receiver<T> dst)
            => Receiver = dst;

        [MethodImpl(Inline)]
        public void Deposit(in T src)
            => Receiver?.Invoke(src);
    }
}