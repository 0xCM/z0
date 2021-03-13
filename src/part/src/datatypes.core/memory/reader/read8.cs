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

    partial struct ByteReader
    {
        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> read8(in long src)
            => new Span<byte>(gptr(in src), 8);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> read8(in ulong src)
            => new Span<byte>(gptr(src), 8);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> read8(in double src)
            => new Span<byte>(gptr(src), 8);
    }
}