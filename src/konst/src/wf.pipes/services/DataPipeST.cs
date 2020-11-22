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

    public readonly struct DataPipe<S,T> : IDataPipe<S,T>
        where S : struct
        where T : struct
    {
        internal readonly ConcurrentBag<S> Buffer;

        [MethodImpl(Inline)]
        internal DataPipe(ConcurrentBag<S> buffer)
        {
            Buffer = buffer;
        }

       [MethodImpl(Inline)]
       public void Deposit(in S src)
            => api.deposit(this, src);

        [MethodImpl(Inline)]
        public bool Next(out T dst)
            => api.next(this, out dst);
    }
}