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
        /// Determines whether a specified operand references a ymm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit ymm(RegOp r)
            => ymm(r.RegClass);

        /// <summary>
        /// Determines whether a specified class code designates a ymm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit ymm(RegClassCode c)
            => c == RegClassCode.YMM;
    }
}