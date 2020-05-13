//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static refs;

    partial struct ByteReader
    {
        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> ReadAll(short src)
            => new Span<byte>(constptr(in src), 2);

        /// <summary>
        /// Reads the bytes that define a numeric value
        /// </summary>
        /// <param name="src">The value to read</param>
        [MethodImpl(Inline), Op]
        public static unsafe Span<byte> ReadAll(ushort src)
            => new Span<byte>(constptr(in src), 2);

        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(ushort src, N0 n)    
            => skip8(src,n);
                    
        /// <summary>
        /// Reads a source byte, identified by natural index
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="n">The byte index selector</param>
        [MethodImpl(Inline), Op]
        public static byte Read(ushort src, N1 n)    
            => skip8(src,n);

    }
}