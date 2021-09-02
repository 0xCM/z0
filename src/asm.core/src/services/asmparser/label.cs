//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    using SQ = SymbolicQuery;

    partial struct AsmParser
    {
        [Op]
        public static int label(ReadOnlySpan<char> src, out AsmBlockLabel dst)
        {
            var i = SQ.index(src,Chars.Colon);
            if(i > 0)
                dst = text.format(SQ.left(src,i));
            else
                dst = AsmBlockLabel.Empty;
            return i;
        }
    }
}