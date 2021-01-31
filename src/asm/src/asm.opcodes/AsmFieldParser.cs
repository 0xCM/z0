//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    [ApiHost]
    public readonly struct AsmFieldParser
    {
        [MethodImpl(Inline), Op]
        public Address8 Parse(string src, out Address8 result, Address8? @default = null)
            => result = new Address8(HexNumericParser.parse(src, z8));

        [MethodImpl(Inline), Op]
        public Address16 Parse(string src, out Address16 result, Address16? @default = null)
            => result = new Address16(HexNumericParser.parse(src, z16));

        [MethodImpl(Inline), Op]
        public Address32 Parse(string src, out Address32 result, Address32? @default = null)
            => result = new Address32(HexNumericParser.parse(src, z32));

        [MethodImpl(Inline), Op]
        public MemoryAddress Parse(string src, out MemoryAddress result, MemoryAddress? @default = null)
            => result = address(HexNumericParser.parse(src, z64));

        [MethodImpl(Inline), Op]
        public BinaryCode Parse(string src, out BinaryCode result)
            => result = HexByteParser.Service.ParseData(src).ValueOrDefault(BinaryCode.Empty);
    }
}