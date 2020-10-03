//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    [ApiHost(ApiNames.MemoryStore)]
    public readonly struct MemoryStore
    {
        public static MemoryStore Service => default;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(in SegRef src)
            => src.Load();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> load<T>(in SegRef src)
            where T : struct
                => src.Load<T>();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(ReadOnlySpan<SegRef> refs, MemorySlot n)
            => load<byte>(memref(refs,n));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<T> src, int offset)
            => ref z.skip(src, (uint)offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<SegRef> refs, MemorySlot n, int offset)
             where T : struct
                => ref cell<T>(load<T>(memref(refs,n)), offset);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(ReadOnlySpan<SegRef> refs, MemorySlot n, int i)
            => ref z.skip(load(memref(refs,n)),(uint)i);

        [MethodImpl(Inline), Op]
        public ref readonly SegRef memref(ReadOnlySpan<SegRef> refs, MemorySlot n)
            => ref cell(refs, n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<SegRef> refs, MemorySlot n, int offset)
            => z.slice(load(refs, n),offset);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<SegRef> refs, MemorySlot n, int offset, int length)
            => z.slice(load(refs,n), offset, length);

        [MethodImpl(Inline)]
        public ulong sib(in SegRef n, int i, byte scale, ushort offset)
            => ((ulong)scale)*cell(n.Load(),i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong sib(ReadOnlySpan<SegRef> refs, in MemorySlot n, int i, byte scale, ushort offset)
            => sib(memref(refs,n), i, scale,offset);
    }
}