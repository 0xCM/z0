//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct Buffers
    {
        /// <summary>
        /// Zero-fills a token-identified buffer and returns the cleared memory content
        /// </summary>
        [MethodImpl(Inline), Op]
        public static Span<byte> clear(in NativeBuffers src, byte index)
            => sys.clear(edit(src.Token(index)));

        [MethodImpl(Inline), Op]
        public static void clear(BufferToken src)
            => edit(src).Clear();
    }
}