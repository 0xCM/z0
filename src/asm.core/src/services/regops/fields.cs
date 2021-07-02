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
        public static RegWidthCode width(RegOp src)
            => (RegWidthCode)(src.Bitfield & 0b111);

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidthCode width(RegKind src)
            => (RegWidthCode)Bits.slice((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.RegWidth);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndexCode index(RegKind src)
            => (RegIndexCode)Bits.slice((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.RegCode);

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

        /// <summary>
        /// Combines a <see cref='RegIndexCode'/>, a <see cref='RegClassCode'/> and a <see cref='RegWidthCode'/> to produce a <see cref='RegKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegKind kind(RegIndexCode i, RegClassCode k, RegWidthCode w)
            => (RegKind)((uint)i  << IndexField | (uint)k << ClassField | (uint)w << WidthField);

        [MethodImpl(Inline), Op]
        public static void split(RegKind src, out RegIndexCode c, out RegClassCode k, out RegWidthCode w)
        {
            c = index(src);
            k = @class(src);
            w = width(src);
        }
    }
}