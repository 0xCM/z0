//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm16 : ulong
    {
        X0 = 0,
        
        X1 = 1,
        
        X2 = 2,

        X3 = 3,

        X4 = 4,

        X5 = 5,

        X6 = 6,

        X7 = 7,

        X8 = 8,

        X9 = 9,

        XA = 0xA,

        XB = 0xB,

        XC = 0xC,

        XD = 0xD,

        XE = 0xE,

        XF = 0xF,   

        Identity = 
              X0 << 00 | X1 << 04 | X2 << 08 | X3 << 12 
            | X4 << 16 | X5 << 20 | X6 << 24 | X7 << 28 
            | X8 << 32 | X9 << 36 | XA << 40 | XB << 44 
            | XC << 48 | XD << 52 | XE << 56 | XF << 60

    }

}