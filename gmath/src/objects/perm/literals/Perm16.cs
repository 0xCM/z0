//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm16 : ulong
    {
        X0 = 0b0000,
        
        X1 = 0b0001,
        
        X2 = 0b0010,

        X3 = 0b0011,

        X4 = 0b0100,

        X5 = 0b0101,

        X6 = 0b0110,

        X7 = 0b0111,

        X8 = 0b1000,

        X9 = 0b1001,

        XA = 0b1010,

        XB = 0b1011,

        XC = 0b1100,

        XD = 0b1101,

        XE = 0b1110,

        XF = 0b1111,   

        Identity = 
              X0 << 00 | X1 << 04 | X2 << 08 | X3 << 12 
            | X4 << 16 | X5 << 20 | X6 << 24 | X7 << 28 
            | X8 << 32 | X9 << 36 | XA << 40 | XB << 44 
            | XC << 48 | XD << 52 | XE << 56 | XF << 60,

        Reverse = 
              XF << 00 | XE << 04 | XD << 08 | XC << 12 
            | XB << 16 | XA << 20 | X9 << 24 | X8 << 28 
            | X7 << 32 | X6 << 36 | X5 << 40 | X4 << 44 
            | X3 << 48 | X2 << 52 | X1 << 56 | X0 << 60,
        

    }

}