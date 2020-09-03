//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Typed;

    public readonly struct BitPop
    {
        public static Vector256<ulong> K1
            => V0d.vbroadcast(n256, MaskLiterals.Even64);

        public static Vector256<ulong> K2
            => V0d.vbroadcast(n256, MaskLiterals.Even64x2);

        public static Vector256<ulong> K4
            => V0d.vbroadcast(n256, MaskLiterals.Lsb64x8x4);

        public static Vector128<ulong> v128K1
            => V0d.vbroadcast(n128, MaskLiterals.Even64);

        public static Vector128<ulong> v128K2
            => V0d.vbroadcast(n128, MaskLiterals.Even64x2);

        public static Vector128<ulong> v128K4
            => V0d.vbroadcast(n128, MaskLiterals.Lsb64x8x4);
    }
}