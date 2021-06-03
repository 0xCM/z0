//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly partial struct Bitfields
    {
        const NumericKind Closure = UnsignedInts;

         [MethodImpl(Inline), Op, Closures(Closure)]
         public static T join<T>(BitfieldSeg<T> a, BitfieldSeg<T> b)
            where T : unmanaged
        {
            var dst = gmath.sll(a.State, (byte)a.FirstIndex);
            dst = gmath.or(dst, gmath.sll(b.State, (byte)b.FirstIndex));
            return dst;
        }
   }
}