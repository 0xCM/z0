//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public readonly struct MemoryStore
    {
        public static MemoryStore Service => default;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Load(MemorySegment src)
            => src.Load();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Load(ReadOnlySpan<MemorySegment> src, MemorySlot n)
            => memory.load(src,n);

        [MethodImpl(Inline), Op]
        public ref readonly byte Cell(ReadOnlySpan<MemorySegment> src, MemorySlot n, int i)
            => ref memory.cell(src,n,i);

        [MethodImpl(Inline)]
        public ulong Sib(ReadOnlySpan<MemorySegment> refs, in MemorySlot n, int i, byte scale, ushort offset)
            => memory.sib(refs, n, i, scale, offset);
    }
}