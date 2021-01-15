//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    partial struct AsmBuilder
    {
        [MethodImpl(Inline), Op]
        public Imm<W8,byte> imm8(byte value)
            => value;
    }
}