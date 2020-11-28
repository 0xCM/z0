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

    public readonly struct ValuePipe<T> : IValuePipe<T>
        where T : struct
    {
        internal readonly ConcurrentBag<T> Buffer;

        [MethodImpl(Inline)]
        public ValuePipe(ConcurrentBag<T> buffer)
        {
            Buffer = buffer;
        }

        [MethodImpl(Inline)]
        public void Deposit(in T src)
            => Sinks.deposit(src, this);

        [MethodImpl(Inline)]
        public bool Next(out T dst)
            => Sources.next(this, out dst);

        [MethodImpl(Inline)]
        public T Next()
        {
            Next(out var dst);
            return dst;
        }
     }
}