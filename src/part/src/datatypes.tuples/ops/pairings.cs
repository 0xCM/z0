//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial class Tuples
    {
        [MethodImpl(Inline)]
        public static Pairings<A,B> pairings<A,B>(Paired<A,B>[] src)
            => src;

        public static Pairings<A,B> pairings<A,B>(ReadOnlySpan<A> left, ReadOnlySpan<B> right)
        {
            var count = corefunc.min(left.Length, right.Length);
            var dst = span<Paired<A,B>>(count);
            pairings(left,right,dst);
            return dst;
        }

        [MethodImpl(Inline)]
        public static void pairings<A,B>(ReadOnlySpan<A> left, ReadOnlySpan<B> right, Pairings<A,B> dst)
        {
            var count = corefunc.min(left.Length, right.Length);
            for(var i=0u; i<count; i++)
                dst[i] = paired(skip(left,i), skip(right,i));
        }
    }
}