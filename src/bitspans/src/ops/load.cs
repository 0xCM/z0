//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial class BitSpans
    {
         [MethodImpl(Inline), Op]
         public static BitSpan load(Span<bit> src)
            => new BitSpan(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(byte src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(sbyte src)
            => BitSpans.create(src);

         [MethodImpl(Inline)]
         public static BitSpan load(ushort src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(short src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(int src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(uint src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(long src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(ulong src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(float src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan load(double src)
            => BitSpans.create(src);

    }
}