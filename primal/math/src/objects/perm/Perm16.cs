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

    }

    public static class Perm16Spec
    {
        [MethodImpl(Inline)]
        public static Perm16 Assemble(
            Perm16 x0, Perm16 x1, Perm16 x2, Perm16 x3, 
            Perm16 x4, Perm16 x5, Perm16 x6, Perm16 x7, 
            Perm16 x8, Perm16 x9, Perm16 xA, Perm16 xB, 
            Perm16 xC, Perm16 xD, Perm16 xE, Perm16 xF) 
        {               
            var dst = 
                  (ulong)x0       | (ulong)x1 << 4  | (ulong)x2 << 8  | (ulong)x3 << 12 
                | (ulong)x4 << 16 | (ulong)x5 << 20 | (ulong)x6 << 24 | (ulong)x7 << 28 
                | (ulong)x8 << 32 | (ulong)x9 << 36 | (ulong)xA << 40 | (ulong)xB << 44 
                | (ulong)xC << 48 | (ulong)xD << 52 | (ulong)xE << 56 | (ulong)xF << 60;

            return (Perm16)dst;
        }

        public static readonly Perm16 Identity
            = Assemble(
                Perm16.X0, Perm16.X1, Perm16.X2, Perm16.X3,
                Perm16.X4, Perm16.X5, Perm16.X6, Perm16.X7,
                Perm16.X8, Perm16.X9, Perm16.XA, Perm16.XB,
                Perm16.XC, Perm16.XD, Perm16.XE, Perm16.XF);
        
        public static readonly Perm16 Reverse
            = Assemble(
                Perm16.XF,Perm16.XE,Perm16.XD,Perm16.XC,
                Perm16.XB,Perm16.XA,Perm16.X9,Perm16.X8,
                Perm16.X7,Perm16.X6,Perm16.X5,Perm16.X4,
                Perm16.X3,Perm16.X2,Perm16.X1,Perm16.X0);

    }
}