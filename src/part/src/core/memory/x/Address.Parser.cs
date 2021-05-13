//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    partial class XTend
    {
        public static ParseFunction<MemoryAddress> Parser(this MemoryAddress src)
            => AddressParser.parse;

        public static ParseFunction<MemoryAddress> Parser(this Address32 src)
            => AddressParser.parse;
    }
}