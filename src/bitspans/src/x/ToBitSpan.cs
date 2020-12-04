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
        public static BitSpan ToBitSpan(this Span<bit> src)
            => BitSpans.load(src);

        /// <summary>
        /// Loads a bitspan from an array
        /// </summary>
        /// <param name="src">The source array</param>
         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this bit[] src)
            => BitSpans.load(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this byte src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this sbyte src)
            => BitSpans.create(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this short src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this int src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this uint src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this long src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this ulong src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this float src)
            => BitSpans.create(src);

         [MethodImpl(Inline), Op]
         public static BitSpan ToBitSpan(this double src)
            => BitSpans.create(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this ReadOnlySpan<byte> src)
            => BitSpans.create(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this ReadOnlySpan<ushort> src)
            => BitSpans.create(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this ReadOnlySpan<uint> src)
            => BitSpans.create(src);


        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this ReadOnlySpan<ulong> src)
            => BitSpans.create(src);


        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this Span<byte> src)
            => BitSpans.create(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this Span<ushort> src)
            => BitSpans.create(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this Span<uint> src)
            => BitSpans.create(src);

        /// <summary>
        /// Loads a bitspan from a packed span of scalars
        /// </summary>
        /// <param name="src">The packed source</param>
        [MethodImpl(Inline), Op]
        public static BitSpan ToBitSpan(this Span<ulong> src)
            => BitSpans.create(src);
   }
}