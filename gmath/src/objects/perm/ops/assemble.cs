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
        /// Constructs a permutation of length four from four ordered symbols
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm4 assemble(Perm4 x0, Perm4 x1, Perm4 x2, Perm4 x3)
        {               
            var dst = 0u;
            dst |= (uint)x0;
            dst |= (uint)x1 << 2;
            dst |= (uint)x2 << 4;
            dst |= (uint)x3 << 6;
            return (Perm4)dst;
        }

        /// <summary>
        /// Constructs a permutation of length 8 from 8 ordered symbols
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm8 assemble(
            Perm8 x0, Perm8 x1, Perm8 x2, Perm8 x3, 
            Perm8 x4, Perm8 x5, Perm8 x6, Perm8 x7)
        {               
            var dst = (uint)x0       | (uint)x1 << 3  | (uint)x2 << 6  | (uint)x3 << 9 
                    | (uint)x4 << 12 | (uint)x5 << 15 | (uint)x6 << 18 | (uint)x7 << 21; 
            return (Perm8)dst;
        }

        /// <summary>
        /// Constructs a permutation of length 16 from 16 ordered symbols
        /// </summary>
        [MethodImpl(Inline)]
        public static Perm16 assemble(
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
    }
}