//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    public readonly struct MemoryAddressParser : ITextParser<MemoryAddress>
    {
        public static ParseResult<MemoryAddress> parse(string src)
            => HexNumericParser.parse64u(src).TryMap(x => new MemoryAddress(x));

        [MethodImpl(Inline)]
        public static MemoryAddress succeed(string src)
            => parse(src).ValueOrDefault();

        public ParseResult<MemoryAddress> Parse(string src)
            => HexNumericParser.parse64u(src).TryMap(x => new MemoryAddress(x));

        [MethodImpl(Inline)]
        public MemoryAddress Parse(string src, MemoryAddress @default)
            => Parse(src).ValueOrDefault(@default);
    }
}