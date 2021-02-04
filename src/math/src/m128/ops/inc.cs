//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct Math128
    {
        [MethodImpl(Inline), Inc]
        public static ref ulong inc(ref ulong x)
        {
            var o = Tuples.@const(1ul,0ul);
            add(x, o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Inc]
        public static void inc(in ulong x, ref ulong y)
        {
            var o = Tuples.@const(1ul,0ul);
            add(x, o.Left, ref y);
        }

        [MethodImpl(Inline), Inc]
        public static ref ConstPair<ulong> inc(ref ConstPair<ulong> x)
        {
            x = add(x, Tuples.@const(1ul,0ul));
            return ref x;
        }
    }
}