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
        /// <summary>
        /// Computes the <see cref='RegName'/> for a specified register operand
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static RegName name(RegOp src)
            => AsmRegNames.name(src);
    }
}