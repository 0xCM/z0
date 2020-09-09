//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;
    using static BitMasks.Literals;

    public readonly struct BitPop
    {
        public static Vector256<ulong> K1
            => vbroadcast(n256, Even64);

        public static Vector256<ulong> K2
            => vbroadcast(n256, Even64x2);

        public static Vector256<ulong> K4
            => vbroadcast(n256, Lsb64x8x4);

        public static Vector128<ulong> v128K1
            => vbroadcast(n128, Even64);

        public static Vector128<ulong> v128K2
            => vbroadcast(n128, Even64x2);

        public static Vector128<ulong> v128K4
            => vbroadcast(n128, Lsb64x8x4);
    }
}