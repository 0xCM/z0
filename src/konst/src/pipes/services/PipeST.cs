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

    public readonly struct Pipe<S,T> : IPipe<S,T>
    {
        internal readonly ConcurrentBag<S> Buffer;

        [MethodImpl(Inline)]
        internal Pipe(ConcurrentBag<S> buffer)
        {
            Buffer = buffer;
        }

        [MethodImpl(Inline)]
        public void Deposit(S src)
            => Buffer.Add(src);

        [MethodImpl(Inline)]
        public bool Next(out T dst)
        {
            if(Buffer.TryTake(out var src))
            {
                dst = z.@as<S,T>(src);
                return true;
            }
            dst = default;
            return false;
        }

        T ISource<T>.Next()
        {
            if(Next(out var dst))
                return dst;
            else
                return default;
        }
    }
}