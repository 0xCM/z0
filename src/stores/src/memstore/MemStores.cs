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
        public ReadOnlySpan<byte> load(in MemRef src)
            => src.Load();

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ReadOnlySpan<T> load<T>(in MemRef src)
            where T : struct
                => src.Load<T>();

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> load(ReadOnlySpan<MemRef> refs, MemStoreIndex n)
            => load<byte>(memref(refs,n));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<T> src, int offset)
            => ref Reader.skip(src, offset);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public ref readonly T cell<T>(ReadOnlySpan<MemRef> refs, MemStoreIndex n, int offset)
             where T : struct
                => ref cell<T>(load<T>(memref(refs,n)), offset);

        [MethodImpl(Inline), Op]
        public ref readonly byte cell(ReadOnlySpan<MemRef> refs, MemStoreIndex n, int i)
            => ref Reader.skip(load(memref(refs,n)),i);

        [MethodImpl(Inline), Op]
        public ref readonly MemRef memref(ReadOnlySpan<MemRef> refs, MemStoreIndex n)
            => ref cell(refs, n);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<MemRef> refs, MemStoreIndex n, int offset)
            => Reader.slice(load(refs, n),offset);

        [MethodImpl(Inline), Op]
        public ReadOnlySpan<byte> slice(ReadOnlySpan<MemRef> refs, MemStoreIndex n, int offset, int length)
            => Reader.slice(load(refs,n), offset, length);

        [MethodImpl(Inline)]
        public ulong sib(in MemRef n, int i, byte scale, ushort offset)
            => ((ulong)scale)*cell(n.Load(),i) + (ulong)offset;

        [MethodImpl(Inline)]
        public ulong sib(ReadOnlySpan<MemRef> refs, in MemStoreIndex n, int i, byte scale, ushort offset)
            => sib(memref(refs,n), i, scale,offset);
        
        static SpanReader Reader 
            => SpanReader.Service;
    }
}