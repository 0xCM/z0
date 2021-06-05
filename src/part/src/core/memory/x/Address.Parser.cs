//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    partial class XTend
    {
        public static ParserDelegate<MemoryAddress> Parser(this MemoryAddress src)
            => AddressParser.parse;

        public static ParserDelegate<MemoryAddress> Parser(this Address32 src)
            => AddressParser.parse;
    }
}