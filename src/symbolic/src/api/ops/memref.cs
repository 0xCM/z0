//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    
    using static Konst;
    using static Root;

    partial class Symbolic
    {
        [MethodImpl(Inline)]
        public unsafe static MemRef memref(ReadOnlySpan<byte> src)
            => new MemRef(gptr(head(src)), src.Length);
    }
}