//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemoryAddressParser : ITextParser<MemoryAddress>
    {        
        public static ITextParser<MemoryAddress> Service => default(MemoryAddressParser);

        public ParseResult<MemoryAddress> Parse(string src)
            => Parsers.hex().Parse(src).TryMap(x => MemoryAddress.define(x));

        public MemoryAddress Parse(string src, MemoryAddress @default)
            => Parse(src).ValueOrDefault(@default);
    }
}
