//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Perm16L;
    using static Quartet;

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

    partial class PermLits
    {
        public const Perm16L Perm16Identity =  
            (Perm16L)(
              (ulong)X0 << 00 | (ulong)X1 << 04 | (ulong)X2 << 08 | (ulong)X3 << 12 
            | (ulong)X4 << 16 | (ulong)X5 << 20 | (ulong)X6 << 24 | (ulong)X7 << 28 
            | (ulong)X8 << 32 | (ulong)X9 << 36 | (ulong)XA << 40 | (ulong)XB << 44 
            | (ulong)XC << 48 | (ulong)XD << 52 | (ulong)XE << 56 | (ulong)XF << 60);    
    }
}