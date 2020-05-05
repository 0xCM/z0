//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    public readonly struct MemoryAddressParser : IParser<MemoryAddress>
    {        
        public static IParser<MemoryAddress> Service => default(MemoryAddressParser);

        public ParseResult<MemoryAddress> Parse(string src)
            => HexParsers.Scalar.Parse(src).TryMap(x => MemoryAddress.Define(x));

        public MemoryAddress Parse(string src, MemoryAddress @default)
            => Parse(src).ValueOrDefault(@default);
    }
}
