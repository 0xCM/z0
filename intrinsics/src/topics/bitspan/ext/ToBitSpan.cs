//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static zfunc;
    using static BitSpan;

    public static class ToBitSpanX
    {

        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this Span<bit> src)
            => load(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this bit[] src)
            => load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this byte src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this sbyte src)
            => BitSpan.load((byte)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this short src)
            => BitSpan.load((ushort)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this int src)
            => BitSpan.load((uint)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this uint src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this long src)
            => BitSpan.load((ulong)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ulong src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this float src)
            => BitSpan.load(BitConvert.ToUInt32(src));

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this double src)
            => BitSpan.load(BitConvert.ToUInt64(src));

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<byte> src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<byte> src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<ushort> src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<ushort> src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<uint> src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<uint> src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this Span<ulong> src)
            => BitSpan.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ReadOnlySpan<ulong> src)
            => BitSpan.load(src);

    }
}