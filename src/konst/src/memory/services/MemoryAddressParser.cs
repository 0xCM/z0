//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryAddressParser : ITextParser<MemoryAddress>
    {
        public static ParseResult<MemoryAddress> parse(string src)
            => HexNumericParser.parse(src).TryMap(x => z.address(x));

        [MethodImpl(Inline)]
        public static MemoryAddress succeed(string src)
            => parse(src).ValueOrDefault();

        public static MemoryAddressParser Service
            => default(MemoryAddressParser);

        public ParseResult<MemoryAddress> Parse(string src)
            => HexNumericParser.parse(src).TryMap(x => z.address(x));

        [MethodImpl(Inline)]
        public MemoryAddress Parse(string src, MemoryAddress @default)
            => Parse(src).ValueOrDefault(@default);
    }
}