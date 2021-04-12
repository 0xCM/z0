//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmEncoder
    {
        [MethodImpl(Inline), Op]
        public static AsmHexCode escape(EscapeCode escape, uint4 index)
        {
            var dst = AsmBytes.hexcode();
            dst.Cell(index) = (byte)escape;
            return dst;
        }
    }
}