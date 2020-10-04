//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    /// <summary>
    /// Represents an iterable K-indexed bijection
    /// </summary>
    public readonly ref struct Bijection<S,T,K>
        where K : unmanaged
    {
        readonly Span<Paired<S,T>> Pairs;

        readonly ulong Last;

        readonly Span<ulong> Current;

        public Bijection(S[] src, T[] dst)
        {
            Last = (ulong)(min(src.Length, dst.Length) - 1) ;
            Pairs = span<Paired<S,T>>(Last + 1);
            Current =  new ulong[1]{ulong.MaxValue};
        }

        [MethodImpl(Inline)]
        ref readonly ulong NextPos()
        {
            ref var current = ref first(Current);
            if(current == Last)
                current = 0;
            else
                ++current;
            return ref current;
        }

        [MethodImpl(Inline)]
        public ref Paired<S,T> Next()
            => ref seek(Pairs, NextPos());

        [MethodImpl(Inline)]
        public ref Paired<S,T> Next(out bool last)
        {
            ref var x = ref seek(Pairs, NextPos());
            last = first(Current) == Last;
            return ref x;
        }

        public ref Paired<S,T> this[K index]
        {
            [MethodImpl(Inline)]
            get => ref seek(Pairs,uint64(index));
        }
    }
}