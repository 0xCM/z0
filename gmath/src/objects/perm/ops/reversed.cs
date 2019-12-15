//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.InteropServices;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static zfunc;    

    partial class Perm
    {

        /// <summary>
        /// Defines the canonical literal representation of the reversal of the identity permutation on 4 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        public static Perm4 reversed(N4 n)
            => Perm4.DCBA;

        /// <summary>
        /// Defines the canonical literal representation of the reversal of the identity permutation on 8 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        [MethodImpl(Inline)]
        public static Perm8 reversed(N8 n)
            => assemble(
                Perm8.H, Perm8.G, Perm8.F, Perm8.E,
                Perm8.D, Perm8.C, Perm8.B, Perm8.A);

        /// <summary>
        /// Returns the canonical literal representation of the reversal of the identity permutation on 16 symbols
        /// </summary>
        /// <param name="n">The symbol count selector</param>
        public static Perm16 reversed(N16 n)
            => assemble(
                Perm16.XF,Perm16.XE,Perm16.XD,Perm16.XC,
                Perm16.XB,Perm16.XA,Perm16.X9,Perm16.X8,
                Perm16.X7,Perm16.X6,Perm16.X5,Perm16.X4,
                Perm16.X3,Perm16.X2,Perm16.X1,Perm16.X0);


    }

}