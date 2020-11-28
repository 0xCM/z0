//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Concurrent;

    using static z;
    using static Konst;

    using api = Pipes;

    public readonly struct Pipe<T> : IPipe<T>
    {
        internal readonly ConcurrentBag<T> Buffer;

        [MethodImpl(Inline)]
        internal Pipe(ConcurrentBag<T> buffer)
        {
            Buffer = buffer;
        }

        [MethodImpl(Inline)]
        public void Deposit(T src)
            => Sinks.deposit(src, this);

        [MethodImpl(Inline)]
        public bool Next(out T dst)
            => Sources.next(this, out dst);

        T ISource<T>.Next()
        {
            if(Next(out var dst))
                return dst;
            else
                return default;
        }
    }
}