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
    using System.Text;

    using static zfunc;    

    /// <summary>
    /// Defines lierals that define arangments of for symbols that do not include permutations
    /// </summary>
    public enum Arrange4L : byte
    {
        /// <summary>
        /// Identifies the first of four symbols
        /// </summary>
        A = Perm4L.A,

        /// <summary>
        /// Identifies the second of four symbols
        /// </summary>
        B = Perm4L.B,

        /// <summary>
        /// Identifies the third of four ssymbols
        /// </summary>
        C = Perm4L.C,

        /// <summary>
        /// Identifies the fourth of four symbols
        /// </summary>
        D = Perm4L.D,

        ABCD = A | (B << 2) | (C << 4) | (D << 6),

        DCBA = D | (C << 2) | (B << 4) | (A << 6),

        AAAA = A | (A << 2) | (A << 4) | (A << 6),
        
        BBBB = B | (B << 2) | (B << 4) | (B << 6),

        CCCC = C | (C << 2) | (C << 4) | (C << 6),

        DDDD = D | (D << 2) | (D << 4) | (D << 6),

        AABB = A | (A<< 2) | (B << 4) | (B << 6),

        BBAA = B | (B<< 2) | (A << 4) | (A << 6),


   }

   public enum Arrange2 : byte
   {
        A = 0b0,

        B = 0b01,

        C = 0b10,

        D = 0b11,

        AB = 0b1110_0100,    

        BA = 0b0100_1110,


   }
}