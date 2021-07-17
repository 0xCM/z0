//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct AsmRegs
    {
        [MethodImpl(Inline), Op]
        public static ushort bitwidth(RegWidthCode src)
            => src == RegWidthCode.W80 ? (ushort)80 : (ushort)Pow2.pow((byte)(((byte)src) << 3));
    }
}