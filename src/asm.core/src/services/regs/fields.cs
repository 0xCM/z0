//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;
    using static RegFacets;

    partial struct AsmRegs
    {
        /// <summary>
        /// Determines the register width from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegWidth width(RegKind src)
            => (RegWidth)Bits.bitslice((uint)src, (byte)FieldIndex.W, (byte)FieldWidth.W);

        /// <summary>
        /// Determines the register code from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegIndex index(RegKind src)
            => (RegIndex)Bits.bitslice((uint)src, (byte)FieldIndex.C, (byte)FieldWidth.C);

        /// <summary>
        /// Determines the register class from the kind
        /// </summary>
        /// <param name="src">The source kind</param>
        [MethodImpl(Inline), Op]
        public static RegClass @class(RegKind src)
            => (RegClass)Bits.bitslice((uint)src, (byte)FieldIndex.K, (byte)FieldWidth.K);

        [MethodImpl(Inline), Op]
        public static void split(RegKind src, out RegIndex c, out RegClass k, out RegWidth w)
        {
            c = index(src);
            k = @class(src);
            w = width(src);
        }
    }
}