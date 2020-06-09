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
        public ReadOnlySpan<byte> slice(StoreIndex n, int offset)
            => Reader.slice(load(n),offset);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(StoreIndex n, int offset, int length)
            => Reader.slice(load(n), offset, length);
    }
}