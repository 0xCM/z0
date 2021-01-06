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
        public ReadOnlySpan<byte> load(in MemorySegment src)
            => src.Load();

        [MethodImpl(Inline), Op, Closures(Closure)]
        public ReadOnlySpan<T> load<T>(in MemorySegment src)
            where T : struct
                => src.Load<T>();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(ReadOnlySpan<MemorySegment> src, MemorySlot n)
            => load<byte>(segment(src,n));

        [MethodImpl(Inline), Op, Closures(Closure)]
        public ref readonly T cell<T>(ReadOnlySpan<T> src, int offset)
            => ref memory.skip(src, (uint)offset);

        [MethodImpl(Inline), Op, Closures(Closure)]
        public ref readonly T cell<T>(ReadOnlySpan<MemorySegment> src, MemorySlot n, int offset)
             where T : struct
                => ref cell<T>(load<T>(segment(src,n)), offset);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(ReadOnlySpan<MemorySegment> src, MemorySlot n, int i)
            => ref memory.skip(load(segment(src,n)),(uint)i);

        [MethodImpl(Inline), Op]
        public ref readonly MemorySegment segment(ReadOnlySpan<MemorySegment> refs, MemorySlot n)
            => ref cell(refs, n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<MemorySegment> refs, MemorySlot n, int offset)
            => memory.slice(load(refs, n),offset);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<MemorySegment> refs, MemorySlot n, int offset, int length)
            => memory.slice(load(refs,n), offset, length);

        [MethodImpl(Inline)]
        public ulong sib(in MemorySegment n, int i, byte scale, ushort offset)
            => ((ulong)scale)*cell(n.Load(),i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong sib(ReadOnlySpan<MemorySegment> refs, in MemorySlot n, int i, byte scale, ushort offset)
            => sib(segment(refs,n), i, scale,offset);
    }
}