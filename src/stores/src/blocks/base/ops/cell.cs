//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    partial struct MemoryStore
    {
        [MethodImpl(Inline), Op]
        public ref readonly byte cell(StoreIndex n, int i)
            => ref Reader.skip(load(memref(n)),i);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(in MemoryBlock src, int i)
            => ref Blocks.cell(src,i);

        [MethodImpl(Inline)]
        ref readonly T cell<T>(ReadOnlySpan<T> src, int offset)
            => ref Reader.skip(src, offset);
    }
}