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
        /// Determines whether a specified operand references a general-purpose register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit gp(RegOp r)
            => gp(r.RegClass);

        [MethodImpl(Inline), Op]
        public static bit gp(RegClassCode c)
            => c == RegClassCode.GP;

        [MethodImpl(Inline), Op]
        public static bit gp(RegOp r, RegWidthCode w)
            => w == r.Width && gp(r);
    }
}