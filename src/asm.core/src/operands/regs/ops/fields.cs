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
        public static RegWidth width(RegWidthIndex wi)
            => (RegWidth)Pow2.pow((byte)wi);

        [MethodImpl(Inline), Op]
        public static RegWidth width(RegOp src)
            => width((RegWidthIndex)(src.Bitfield & 0b111));

        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidth width(RegKind src)
            => (RegWidth)Bits.slice((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.W);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndex index(RegKind src)
            => (RegIndex)Bits.slice((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.C);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClass @class(RegKind src)
            => (RegClass)Bits.slice((uint)src, (byte)FieldIndex.K, (byte)FieldWidth.K);

        /// <summary>
        /// Determines the register class from the operand
        /// </summary>
        /// <param name="src">The register operand</param>
        [MethodImpl(Inline), Op]
        public static RegClass @class(RegOp src)
            => (RegClass)Bits.segment(src.Bitfield, 5, 9);

        /// <summary>
        /// Combines a <see cref='RegIndex'/>, a <see cref='RegClass'/> and a <see cref='RegWidth'/> to produce a <see cref='RegKind'/>
        /// </summary>
        /// <param name="i">The register index</param>
        /// <param name="k">The register class</param>
        /// <param name="w">The register width</param>
        [MethodImpl(Inline), Op]
        public static RegKind kind(RegIndex i, RegClass k, RegWidth w)
            => (RegKind)((uint)i  << IndexField | (uint)k << ClassField | (uint)w << WidthField);

        [MethodImpl(Inline), Op]
        public static void split(RegKind src, out RegIndex c, out RegClass k, out RegWidth w)
        {
            c = index(src);
            k = @class(src);
            w = width(src);
        }
    }
}