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

    public readonly struct Pipe<T> : IPipe<T>
    {
        readonly ConcurrentBag<T> Buffer;

        [MethodImpl(Inline)]
        internal Pipe(ConcurrentBag<T> buffer)
            => Buffer = buffer;

        [MethodImpl(Inline)]
        public void Deposit(T src)
            => Buffer.Add(src);

        [MethodImpl(Inline)]
        public bool Next(out T dst)
            => Buffer.TryTake(out dst);

        T ISource<T>.Next()
        {
            if(Next(out var dst))
                return dst;
            else
                return default;
        }
    }
}