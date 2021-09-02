//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using static Root;
    using static core;

    partial struct AsmParser
    {
        [Op]
        public static Outcome hexcode(ReadOnlySpan<AsciCode> src, out AsmHexCode dst)
        {
            dst = default;
            var buffer = Cells.alloc(n128).Bytes;
            var j=0u;
            var result = Hex.parse(src, ref j, buffer);
            if(result.Fail)
                return result;

            var size = result.Data;
            if(size == 0)
                return (false, "Hexcode was empty");

            dst = AsmHexCode.load(slice(buffer,0,size));
            return result;
        }
    }
}