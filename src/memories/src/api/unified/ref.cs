//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    partial class Memories
    {
        [MethodImpl(Inline)]
        public unsafe static MemoryRef @ref(ReadOnlySpan<byte> src)
            => new MemoryRef(gptr(head(src)), src.Length);
    }
}
