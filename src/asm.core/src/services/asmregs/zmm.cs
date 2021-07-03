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
        /// Determines whether a specified operand references an zmm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit zmm(RegOp r)
            => zmm(r.RegClass);

        /// <summary>
        /// Determines whether a specified class code designates a zmm register
        /// </summary>
        /// <param name="r">The operand</param>
        [MethodImpl(Inline), Op]
        public static bit zmm(RegClassCode c)
            => c == RegClassCode.ZMM;
    }
}