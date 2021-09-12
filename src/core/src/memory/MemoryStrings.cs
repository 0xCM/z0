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

    [ApiHost]
    public readonly struct MemoryStrings
    {
        [MethodImpl(Inline), Op]
        public static MemoryStrings load(uint entries, uint length, MemoryAddress offsetbase, MemoryAddress charbase)
            => new MemoryStrings(entries, length, offsetbase, charbase);

        [MethodImpl(Inline), Op]
        public static MemoryStrings load(ReadOnlySpan<byte> offsets, ReadOnlySpan<char> chars)
            => new MemoryStrings((uint)(offsets.Length/4), (uint)chars.Length, address(offsets), address(chars));

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

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> chars(in MemoryStrings src)
            => cover(src.CharBase.Pointer<char>(), src.CharCount);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> chars(in MemoryStrings src, int index)
            => slice(chars(src), offset(src,index), length(src,index));

        [MethodImpl(Inline), Op]
        public static ReadOnlySpan<char> chars(in MemoryStrings src, uint index)
            => chars(src,(int)index);

        [MethodImpl(Inline), Op]
        public static unsafe ReadOnlySpan<char> chars(MemoryAddress @base, int i0, int i1)
            => cover(@base.Pointer<char>() + i0, (i1 - i0));

        // [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        // public static void iter<T>(in MemoryStrings src, Symbols<T> symbols, Action<T,int,uint> f)
        //     where T : unmanaged
        // {
        //     var count = min(symbols.Length, src.EntryCount);
        //     for(var i=0; i<count; i++)
        //     {
        //         ref readonly var symbol = ref skip(symbols,i);
        //         f(symbols[(uint)i].Kind, i, length(src,i));
        //     }
        // }

        public readonly uint EntryCount;

        public readonly uint CharCount;

        public readonly MemoryAddress OffsetBase;

        public readonly MemoryAddress CharBase;

        [MethodImpl(Inline)]
        public MemoryStrings(uint entries, uint chars, MemoryAddress offsetbase, MemoryAddress charbase)
        {
            EntryCount = entries;
            CharCount = chars;
            OffsetBase = offsetbase;
            CharBase = charbase;
        }

        public ReadOnlySpan<char> this[int index]
        {
            [MethodImpl(Inline)]
            get => chars(this,index);
        }

        [MethodImpl(Inline)]
        public ref readonly uint Offset(uint index)
            => ref skip(Offsets,index);

        public ReadOnlySpan<char> Data
        {
            [MethodImpl(Inline)]
            get => chars(this);
        }

        public unsafe ReadOnlySpan<uint> Offsets
        {
            [MethodImpl(Inline)]
            get => offsets(this);
        }
    }
}