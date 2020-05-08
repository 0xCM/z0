//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Seed;    
    using static Memories;

    /// <summary>
    /// Defines canonical literals for representing terms of permutations on 16 symbols
    /// </summary>
    public enum Perm16L : ulong
    {
        X0 = Perm16Sym.X0,
        
        X1 = Perm16Sym.X1,
        
        X2 = Perm16Sym.X2,

        X3 = Perm16Sym.X3,

        X4 = Perm16Sym.X4,

        X5 = Perm16Sym.X5,

        X6 = Perm16Sym.X6,

        X7 = Perm16Sym.X7,

        X8 = Perm16Sym.X8,

        X9 = Perm16Sym.X9,

        XA = Perm16Sym.XA,

        XB = Perm16Sym.XB,

        XC = Perm16Sym.XC,

        XD = Perm16Sym.XD,

        XE = Perm16Sym.XE,

        XF = Perm16Sym.XF,

        Identity = 
              X0 << 00 | X1 << 04 | X2 << 08 | X3 << 12 
            | X4 << 16 | X5 << 20 | X6 << 24 | X7 << 28 
            | X8 << 32 | X9 << 36 | XA << 40 | XB << 44 
            | XC << 48 | XD << 52 | XE << 56 | XF << 60,    
    }
}