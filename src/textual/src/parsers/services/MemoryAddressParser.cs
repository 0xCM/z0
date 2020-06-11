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
        public static MemoryAddressParser Service => default(MemoryAddressParser);

        [MethodImpl(Inline)]
        public ParseResult<MemoryAddress> Parse(string src)
            => Parsers.hex().Parse(src).TryMap(x => Addresses.address(x));

        [MethodImpl(Inline)]
        public MemoryAddress Parse(string src, MemoryAddress @default)
            => Parse(src).ValueOrDefault(@default);
    }
}