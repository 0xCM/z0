//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Perm16L;
    using static BitSeq4;

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm16L : ulong
    {
        X0 = b0000,
        
        X1 = b0001,
        
        X2 = b0010,

        X3 = b0011,

        X4 = b0100,

        X5 = b0101,

        X6 = b0110,

        X7 = b0111,

        X8 = b1000,

        X9 = b1001,

        XA = b1010,

        XB = b1011,

        XC = b1100,

        XD = b1101,

        XE = b1110,

        XF = b1111,
    }


}