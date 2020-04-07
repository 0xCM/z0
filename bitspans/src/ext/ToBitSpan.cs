//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Core;
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
            => BitSpan.from<byte>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this byte src, int maxbits)
            => BitSpan.from<byte>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this sbyte src)
            => BitSpan.from<byte>((byte)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this sbyte src, int maxbits)
            => BitSpan.from<sbyte>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src)
            => BitSpan.from<ushort>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src, int maxbits)
            => BitSpan.from<ushort>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this short src)
            => BitSpan.from<ushort>((ushort)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this short src, int maxbits)
            => BitSpan.from<short>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this int src)
            => BitSpan.from<uint>((uint)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this int src, int maxbits)
            => BitSpan.from<int>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this uint src)
            => BitSpan.from<uint>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this uint src, int maxbits)
            => BitSpan.from<uint>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this long src)
            => BitSpan.from<ulong>((ulong)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this long src, int maxbits)
            => BitSpan.from<long>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ulong src)
            => BitSpan.from<ulong>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ulong src, int maxbits)
            => BitSpan.from<ulong>(src).Truncate(maxbits);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this float src)
            => BitSpan.from<uint>(BitConvert.ToUInt32(src));

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this double src)
            => BitSpan.from<ulong>(BitConvert.ToUInt64(src));

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<byte> src)
            => BitSpan.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<ushort> src)
            => BitSpan.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<uint> src)
            => BitSpan.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this ReadOnlySpan<ulong> src)
            => BitSpan.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<byte> src)
            => BitSpan.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<ushort> src)
            => BitSpan.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<uint> src)
            => BitSpan.load(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        public static BitSpan ToBitSpan(this Span<ulong> src)
            => BitSpan.load(src);
   }
}