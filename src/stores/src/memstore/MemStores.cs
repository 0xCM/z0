//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
 
    using static Konst;

    [ApiHost]
    public readonly struct MemStores
    {
        public static MemStores Service => default;

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(in MemoryRef src)
            => src.Load();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> load<T>(in MemoryRef src)
            where T : struct
                => src.Load<T>();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(ReadOnlySpan<MemoryRef> refs, MemStoreIndex n)
            => load<byte>(memref(refs,n));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<T> src, int offset)
            => ref Reader.skip(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<MemoryRef> refs, MemStoreIndex n, int offset)
             where T : struct
                => ref cell<T>(load<T>(memref(refs,n)), offset);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(ReadOnlySpan<MemoryRef> refs, MemStoreIndex n, int i)
            => ref Reader.skip(load(memref(refs,n)),i);

        [MethodImpl(Inline), Op]
        public ref readonly MemoryRef memref(ReadOnlySpan<MemoryRef> refs, MemStoreIndex n)
            => ref cell(refs, n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<MemoryRef> refs, MemStoreIndex n, int offset)
            => Reader.slice(load(refs, n),offset);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<MemoryRef> refs, MemStoreIndex n, int offset, int length)
            => Reader.slice(load(refs,n), offset, length);

        [MethodImpl(Inline)]
        public ulong sib(in MemoryRef n, int i, byte scale, ushort offset)
            => ((ulong)scale)*cell(n.Load(),i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong sib(ReadOnlySpan<MemoryRef> refs, in MemStoreIndex n, int i, byte scale, ushort offset)
            => sib(memref(refs,n), i, scale,offset);
        
        static SpanReader Reader 
            => SpanReader.Service;
    }
}