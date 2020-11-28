//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
   using System;
   using System.Runtime.CompilerServices;
   using System.Linq;

   using static Konst;

    partial class XBitSpans
    {
        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this Span<Bit32> src)
            => BitSpans.load32(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this Bit32[] src)
            => BitSpans.load32(src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this byte src)
            => BitSpans.from<byte>(src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this byte src, int maxbits)
            => BitSpans.from<byte>(src).Truncate(maxbits);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this sbyte src)
            => BitSpans.from<byte>((byte)src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this sbyte src, int maxbits)
            => BitSpans.from<sbyte>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan32 ToBitSpan32(this ushort src)
            => BitSpans.from<ushort>(src);

         [MethodImpl(Inline)]
         public static BitSpan32 ToBitSpan32(this ushort src, int maxbits)
            => BitSpans.from<ushort>(src).Truncate(maxbits);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this short src)
            => BitSpans.from<ushort>((ushort)src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this short src, int maxbits)
            => BitSpans.from<short>(src).Truncate(maxbits);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this int src)
            => BitSpans.from<uint>((uint)src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this int src, int maxbits)
            => BitSpans.from<int>(src).Truncate(maxbits);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this uint src)
            => BitSpans.from<uint>(src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this uint src, int maxbits)
            => BitSpans.from<uint>(src).Truncate(maxbits);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this long src)
            => BitSpans.from<ulong>((ulong)src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this long src, int maxbits)
            => BitSpans.from<long>(src).Truncate(maxbits);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this ulong src)
            => BitSpans.from<ulong>(src);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this ulong src, int maxbits)
            => BitSpans.from<ulong>(src).Truncate(maxbits);

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this float src)
            => BitSpans.from<uint>(UI.u32(src));

         [MethodImpl(Inline), Op]
         public static BitSpan32 ToBitSpan32(this double src)
            => BitSpans.from<ulong>(UI.u64(src));

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this ReadOnlySpan<byte> src)
            => BitSpans.load32(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this ReadOnlySpan<ushort> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this ReadOnlySpan<uint> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this ReadOnlySpan<ulong> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this Span<byte> src)
            => BitSpans.load32(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this Span<ushort> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this Span<uint> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan32 ToBitSpan32(this Span<ulong> src)
            => BitSpans.load(src);
   }
}