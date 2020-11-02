//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;
    using static UInt4;

    [ApiHost]
    public readonly struct AsmDecoder
    {
        [MethodImpl(Inline), Op]
        public static bool isrex(byte src)
            => (uint4)(src >> 4) == b0100;

        [MethodImpl(Inline), Op]
        public static ParseResult<RexPrefixBits> rex(byte src)
             => isrex(src)
             ? parsed(src.ToString(), RexPrefixBits.define(src))
             : unparsed<RexPrefixBits>(src.ToString(), $"src >> 4 != b0100");
    }
}