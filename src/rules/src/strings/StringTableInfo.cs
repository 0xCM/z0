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

    public struct StringTableInfo
    {
        [MethodImpl(Inline), Op]
        public static StringTableInfo define(uint entries, uint length, MemoryAddress offsetbase, MemoryAddress charbase)
            => new StringTableInfo(entries, length, offsetbase, charbase);

        [MethodImpl(Inline), Op]
        public static StringTableInfo infer(ReadOnlySpan<byte> offsets, ReadOnlySpan<char> chars)
            => new StringTableInfo((uint)(offsets.Length/4), (uint)chars.Length, address(offsets), address(chars));

        public uint EntryCount;

        public uint CharCount;

        public MemoryAddress OffsetBase;

        public MemoryAddress CharBase;

        [MethodImpl(Inline)]
        public StringTableInfo(uint entries, uint chars, MemoryAddress offsetbase, MemoryAddress charbase)
        {
            EntryCount = entries;
            CharCount = chars;
            OffsetBase = offsetbase;
            CharBase = charbase;
        }
    }
}