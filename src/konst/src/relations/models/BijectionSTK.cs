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

    using api = Relations;

    /// <summary>
    /// Represents an iterable K-indexed bijection
    /// </summary>
    public ref struct Bijection<S,T>
    {
        readonly Span<Paired<S,T>> Pairs;

        readonly ulong Last;

        readonly uint Count;

        ulong Current;

        public Bijection(S[] src, T[] dst)
        {
            Count = (uint)insist(src,dst);
            Last = Count - 1;
            Pairs = span<Paired<S,T>>(Count);
            api.project(src,dst,Pairs);
            Current =  ulong.MaxValue;
        }

        [MethodImpl(Inline)]
        public Bijection(Paired<S,T>[] pairs)
        {
            Count = (uint)pairs.Length;
            Last = Count - 1;
            Pairs = pairs;
            Current = ulong.MaxValue;
        }

        [MethodImpl(Inline)]
        ulong NextPos()
        {
            if(Current == Last)
                Current = 0;
            else
                ++Current;
            return Current;
        }

        [MethodImpl(Inline)]
        public ref Paired<S,T> Next()
            => ref seek(Pairs, NextPos());

        [MethodImpl(Inline)]
        public ref Paired<S,T> Next(out bool last)
        {
            ref var x = ref seek(Pairs, NextPos());
            last = Current == Last;
            return ref x;
        }
    }
}