//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    partial struct z
    {
        [MethodImpl(Inline)]
        public static MemorySegment segment(MemoryAddress @base, ByteSize bytes)
            => memory.segment(@base, bytes);

        [MethodImpl(Inline)]
        public unsafe static MemorySegment segment(ReadOnlySpan<byte> src)
            => memory.segment(src);
    }
}