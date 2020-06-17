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

    partial class XTend
    {
        /// <summary>
        /// Wraps a bitspan over a span of extant bits
        /// </summary>
        /// <param name="src">The source bits</param>
        [MethodImpl(Inline)]
        public static BitSpan ToBitSpan(this Span<bit> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this bit[] src)
            => BitSpans.load(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this byte src)
            => BitSpans.from<byte>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this byte src, int maxbits)
            => BitSpans.from<byte>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this sbyte src)
            => BitSpans.from<byte>((byte)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this sbyte src, int maxbits)
            => BitSpans.from<sbyte>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src)
            => BitSpans.from<ushort>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src, int maxbits)
            => BitSpans.from<ushort>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this short src)
            => BitSpans.from<ushort>((ushort)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this short src, int maxbits)
            => BitSpans.from<short>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this int src)
            => BitSpans.from<uint>((uint)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this int src, int maxbits)
            => BitSpans.from<int>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this uint src)
            => BitSpans.from<uint>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this uint src, int maxbits)
            => BitSpans.from<uint>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this long src)
            => BitSpans.from<ulong>((ulong)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this long src, int maxbits)
            => BitSpans.from<long>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ulong src)
            => BitSpans.from<ulong>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ulong src, int maxbits)
            => BitSpans.from<ulong>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this float src)
            => BitSpans.from<uint>(BitConvert.ToUInt32(src));

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this double src)
            => BitSpans.from<ulong>(BitConvert.ToUInt64(src));

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<byte> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<ushort> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<uint> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<ulong> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<byte> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<ushort> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<uint> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<ulong> src)
            => BitSpans.load(src);
   }
}