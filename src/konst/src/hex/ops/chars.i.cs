//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    partial class Hex
    {
        /// <summary>
        /// Computes the 2-character hex representation of a signed byte
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(sbyte src)
            => chars((byte)src);

        /// <summary>
        /// Computes the 4-character hex representation of a signed 16-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(short src)
            => chars((ushort)src);

        /// <summary>
        /// Computes the 8-character hex representation of a signed 32-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(int src)
            => chars((uint)src);

        /// <summary>
        /// Computes the 16-character hex representation of a signed 64-bit integer
        /// </summary>
        /// <param name="src">The byte value</param>
        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(long src)
            => chars((ulong)src);

        [MethodImpl(Inline), Op]
        public static void chars(sbyte src, Span<char> dst, int offset)
            => chars((byte)src,dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(short src, Span<char> dst, int offset)
            => chars((ushort)src,dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(int src, Span<char> dst, int offset)
            => chars((uint)src,dst,offset);

        [MethodImpl(Inline), Op]
        public static void chars(long src, Span<char> dst, int offset)        
            => chars((ulong)src,dst,offset);
    }
}