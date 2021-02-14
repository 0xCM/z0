//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.MemoryStore, true)]
    public readonly struct MemoryStore
    {
        const NumericKind Closure = UnsignedInts;

        public static MemoryStore Service => default;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Load(MemorySegment src)
            => src.Load();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public ReadOnlySpan<T> Load<T>(MemorySegment src)
            where T : struct
                => src.Load<T>();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Load(ReadOnlySpan<MemorySegment> src, MemorySlot n)
            => Load<byte>(Segment(src,n));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public ref readonly T Cell<T>(ReadOnlySpan<T> src, int offset)
            => ref memory.skip(src, (uint)offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public ref readonly T Cell<T>(ReadOnlySpan<MemorySegment> src, MemorySlot n, int offset)
             where T : struct
                => ref Cell<T>(Load<T>(Segment(src,n)), offset);

        [MethodImpl(Inline), Op]
        public ref readonly byte Cell(ReadOnlySpan<MemorySegment> src, MemorySlot n, int i)
            => ref memory.skip(Load(Segment(src,n)),(uint)i);

        [MethodImpl(Inline), Op]
        public ref readonly MemorySegment Segment(ReadOnlySpan<MemorySegment> refs, MemorySlot n)
            => ref Cell(refs, n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Slice(ReadOnlySpan<MemorySegment> refs, MemorySlot n, int offset)
            => memory.slice(Load(refs, n),offset);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> Slice(ReadOnlySpan<MemorySegment> refs, MemorySlot n, int offset, int length)
            => memory.slice(Load(refs,n), offset, length);

        [MethodImpl(Inline)]
        public ulong Sib(MemorySegment n, int i, byte scale, ushort offset)
            => ((ulong)scale)*Cell(n.Load(),i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong Sib(ReadOnlySpan<MemorySegment> refs, in MemorySlot n, int i, byte scale, ushort offset)
            => Sib(Segment(refs,n), i, scale,offset);
    }
}