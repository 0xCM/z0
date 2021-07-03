//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static RegFacets;

    partial struct AsmRegs
    {
        /// <summary>
        /// Determines the width of a specified operand
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static RegWidthCode width(RegOp src)
            => (RegWidthCode)(src.Bitfield & 0b111);

        /// <summary>
        /// Determines the width of the register represented by a specified kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidthCode width(RegKind src)
            => (RegWidthCode)Bits.slice((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.RegWidth);
    }
}