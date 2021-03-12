//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    partial class XTend
    {
        public static ParseFunction<MemoryAddress> Parser(this MemoryAddress src)
            => Addresses.parse;

        public static ParseFunction<MemoryAddress> Parser(this Address32 src)
            => Addresses.parse;
    }
}