//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Linq;

    partial class Root
    {
        /// <summary>
        /// Projects a source byte onto a byte reference
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static unsafe void store8(byte src, ref byte dst)
            => *((byte*)ptr(ref dst)) = src;

        /// <summary>
        /// Projects 16 contiguous source bits onto a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static unsafe void store16(ushort src, ref byte dst)
            => *((ushort*)ptr(ref dst)) = src;

        /// <summary>
        /// Projects 32 contiguous source bits onto a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static unsafe void store32(uint src, ref byte dst)
            => *((uint*)ptr(ref dst)) = src;

        /// <summary>
        /// Projects 64 contiguous source bits onto a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The bit target</param>
        [MethodImpl(Inline)]
        public static unsafe void store64(ulong src, ref byte dst)
            => *((ulong*)ptr(ref dst)) = src;        
    }
}