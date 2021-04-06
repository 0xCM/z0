//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    partial struct asm
    {
        [MethodImpl(Inline), Op]
        public static ref ModRm modrm(in AsmHexCode src, uint4 offset)
            => ref @as<byte,ModRm>(skip(src.Bytes, offset));
    }
}