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
        [MethodImpl(Inline), Op]
        public static RegIndexCode index(RegOp src)
            =>(RegIndexCode)Bits.segment(src.Bitfield, 10, 15);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndexCode index(RegKind src)
            => (RegIndexCode)Bits.slice((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.RegCode);
    }
}
