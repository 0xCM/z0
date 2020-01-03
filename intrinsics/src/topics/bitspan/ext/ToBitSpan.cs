//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
            => BitSpan.create<byte>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this sbyte src)
            => BitSpan.create<byte>((byte)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ushort src)
            => BitSpan.create<ushort>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this short src)
            => BitSpan.create<ushort>((ushort)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this int src)
            => BitSpan.create<uint>((uint)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this uint src)
            => BitSpan.create<uint>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this long src)
            => BitSpan.create<ulong>((ulong)src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this ulong src)
            => BitSpan.create<ulong>(src);

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this float src)
            => BitSpan.create<uint>(BitConvert.ToUInt32(src));

         [MethodImpl(Inline)]
         public static BitSpan ToBitSpan(this double src)
            => BitSpan.create<ulong>(BitConvert.ToUInt64(src));

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