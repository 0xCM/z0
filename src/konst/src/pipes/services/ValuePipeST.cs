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

    public readonly struct ValuePipe<S,T> : IValuePipe<S,T>
        where S : struct
        where T : struct
    {
        internal readonly ConcurrentBag<S> Buffer;

        [MethodImpl(Inline)]
        internal ValuePipe(ConcurrentBag<S> buffer)
        {
            Buffer = buffer;
        }

       [MethodImpl(Inline)]
       public void Deposit(in S src)
            => Sinks.deposit(src,this);

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