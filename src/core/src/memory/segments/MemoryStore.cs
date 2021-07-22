//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    [ApiHost]
    public readonly struct MemoryStore
    {
        public static MemoryStore Service => default;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Load(MemorySeg src)
            => src.Load();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Load(ReadOnlySpan<MemorySeg> src, MemorySlot n)
            => MemorySegs.load(src,n);

        [MethodImpl(Inline), Op]
        public ref readonly byte Cell(ReadOnlySpan<MemorySeg> src, MemorySlot n, int i)
            => ref MemorySegs.cell(src,n,i);

        [MethodImpl(Inline)]
        public ulong Sib(ReadOnlySpan<MemorySeg> refs, in MemorySlot n, int i, byte scale, ushort offset)
            => MemorySegs.sib(refs, n, i, scale, offset);
    }
}