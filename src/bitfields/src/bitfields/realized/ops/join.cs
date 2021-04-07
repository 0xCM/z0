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

    partial struct BitFields
    {
         [MethodImpl(Inline), Op]
         public static byte join(Pair<byte> a, Pair<byte> b)
         {
             var dst = Bytes.sll(a.Left, a.Right);
             dst = Bytes.or(dst, Bytes.sll(b.Left, b.Right));
             return dst;
         }

         [MethodImpl(Inline), Op]
         public static byte join(Pair<byte> a, Pair<byte> b, Pair<byte> c)
         {
             var dst = Bytes.sll(a.Left, a.Right);
             dst = Bytes.or(dst, Bytes.sll(b.Left, b.Right));
             dst = Bytes.or(dst, Bytes.sll(c.Left, c.Right));
             return dst;
         }

         [MethodImpl(Inline), Op, Closures(Closure)]
         public static T join<T>(BitfieldSegment<T> a, BitfieldSegment<T> b)
            where T : unmanaged
        {
            var dst = gmath.sll(a.State, a.FirstIndex);
            dst = gmath.or(dst, gmath.sll(b.State, b.FirstIndex));
            return dst;
        }
    }
}