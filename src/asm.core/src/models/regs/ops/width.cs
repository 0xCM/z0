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
        /// Determines the width of the register represented by a specified kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static NativeWidthCode width(RegKind src)
            => (NativeWidthCode)Bits.slice((uint)src, (byte)RegFieldIndex.W, (byte)RegFieldWidth.RegWidth);

        /// <summary>
        /// Determines the width of a specified operand
        /// </summary>
        /// <param name="src">The source operand</param>
        [MethodImpl(Inline), Op]
        public static NativeWidthCode width(RegOp src)
            => (NativeWidthCode)(src.Bitfield & 0b111);

        [MethodImpl(Inline), Op]
        public static ushort bitwidth(NativeWidthCode src)
            => src == NativeWidthCode.W80 ? (ushort)80 : (ushort)Pow2.pow((byte)(((byte)src) << 3));
    }
}