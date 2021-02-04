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
        [MethodImpl(Inline), Dec]
        public static ref ulong dec(ref ulong x)
        {
            var o = Tuples.@const(1ul,0ul);
            sub(in x, in o.Left, ref x);
            return ref x;
        }

        [MethodImpl(Inline), Dec]
        public static void dec(in ulong x, ref ulong y)
        {
            var o = Tuples.@const(1ul,0ul);
            sub(in x, in o.Left, ref y);
        }

        [MethodImpl(Inline), Dec]
        public static ref ConstPair<ulong> dec(ref ConstPair<ulong> x)
        {
            x = sub(x, Tuples.@const(1ul,0ul));
            return ref x;
        }
    }
}