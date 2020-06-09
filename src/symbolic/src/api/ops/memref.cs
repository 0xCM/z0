//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Control;

    partial class Symbolic
    {
        [MethodImpl(Inline)]
        public unsafe static MemoryRef memref(ReadOnlySpan<byte> src)
            => new MemoryRef(gptr(head(src)), src.Length);
    }
}