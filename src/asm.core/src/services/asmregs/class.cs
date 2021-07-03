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
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClassCode @class(RegKind src)
            => (RegClassCode)Bits.slice((uint)src, (byte)FieldIndex.K, (byte)FieldWidth.RegClass);

        /// <summary>
        /// Determines the register class from the operand
        /// </summary>
        /// <param name="src">The register operand</param>
        [MethodImpl(Inline), Op]
        public static RegClassCode @class(RegOp src)
            => (RegClassCode)Bits.segment(src.Bitfield, 5, 9);
    }
}