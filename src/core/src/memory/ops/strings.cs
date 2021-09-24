//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    unsafe partial struct memory
    {
        [MethodImpl(Inline), Op]
        public static MemoryStrings strings(uint entries, uint length, MemoryAddress offsetbase, MemoryAddress charbase)
            => new MemoryStrings(entries, length, offsetbase, charbase);

        [MethodImpl(Inline), Op]
        public static MemoryStrings strings(ReadOnlySpan<byte> offsets, ReadOnlySpan<char> chars)
            => new MemoryStrings(ecount(offsets), (uint)chars.Length, address(offsets), address(chars));

        [MethodImpl(Inline)]
        public static MemoryStrings<K> strings<K>(ReadOnlySpan<byte> offsets, ReadOnlySpan<char> chars)
            where K : unmanaged
                => new MemoryStrings<K>(strings(offsets,chars));

        [MethodImpl(Inline), Op]
        static uint ecount(ReadOnlySpan<byte> offsets)
            => (uint)(offsets.Length/4);

        [MethodImpl(Inline), Op]
        public static unsafe ref readonly uint offset(in MemoryStrings info, int index)
        {
            var src = recover<uint>(cover(info.OffsetBase.Pointer<byte>(), info.EntryCount*4));
            return ref skip(src,index);
        }

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<uint> offsets(in MemoryStrings src)
            => recover<uint>(cover(src.OffsetBase.Pointer<byte>(), src.EntryCount*4));

        [MethodImpl(Inline), Op]
        public static uint length(in MemoryStrings src, int index)
        {
            var a = offset(src, index);
            var b = 0u;
            if(index == src.EntryCount - 1)
                b = src.CharCount;
            else
                b = offset(src, index + 1);
            return (uint)(b - a);
        }
    }
}