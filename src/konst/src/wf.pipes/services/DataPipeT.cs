//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static Konst;

    using api = Pipes;

    public readonly struct DataPipe<T> : IDataPipe<T>
        where T : struct
    {
        internal readonly ConcurrentBag<T> Buffer;

        [MethodImpl(Inline)]
        public DataPipe(ConcurrentBag<T> buffer)
        {
            Buffer = buffer;
        }

        [MethodImpl(Inline)]
        public void Deposit(in T src)
            => api.deposit(this, src);

        [MethodImpl(Inline)]
        public bool Next(out T dst)
            => api.next(this, out dst);
    }
}