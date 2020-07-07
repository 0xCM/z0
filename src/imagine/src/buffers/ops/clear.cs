//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct Buffers
    {
        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline)]
        public static Span<byte> clear(in BufferSeq src, byte index)
            => sys.clear(cover(src.Token(index)));

        [MethodImpl(Inline), Op]
        public static void clear(BufferToken src)
            => cover(src).Clear();
    }
}