//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics.X86;
 
    using static zfunc;

    public enum Peano : int
    {
        P1x1 = 1,

        P1x2 = P1x1 + P1x1,

        P1x3 = P1x2 + P1x1,

        P1x4 = P1x3 + P1x1,

        P1x5 = P1x4 + P1x1,

        P1x6 = P1x5 + P1x1,

        P1x7 = P1x6 + P1x1,

        P1x8 = P1x7 + P1x1,

        P1x9 = P1x8 + P1x1,

        P2x1 = P1x2,

        P2x2 = P2x1 + P2x1,

        P2x3 = P2x2 + P2x1,

        P2x4 = P2x3 + P2x1,

        P2x5 = P2x4 + P2x1,

        P2x6 = P2x5 + P2x1,

        P3x1 = P1x3,

        P3x2 = P3x1 + P3x1,

        P3x3 = P3x2 + P3x1,

        P3x4 = P3x3 + P3x1,

        P4x4 = P3x4 + P3x1,

        P6x1 = P1x6,

        P6x2 = P6x1 + P6x1,

        P6x3 = P6x2 + P6x1,

        P6x4 = P6x3 + P6x1,

        P8x1 = P1x8,

        P8x2 = P8x1 + P8x1,

        P8x3 = P8x2 + P8x1,

        P8x4 = P8x3 + P8x1,

        P8x5 = P8x4 + P8x1,

    }

    public static partial class BitMasks
    {            


    }


}