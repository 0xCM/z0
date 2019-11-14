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
    public enum Arrange4 : byte
    {
         /// <summary>
        /// Identifies the first of four symbols
        /// </summary>
        A = Perm4.A,

        /// <summary>
        /// Identifies the second of four symbols
        /// </summary>
        B = Perm4.B,

        /// <summary>
        /// Identifies the third of four ssymbols
        /// </summary>
        C = Perm4.C,

        /// <summary>
        /// Identifies the fourth of four symbols
        /// </summary>
        D = Perm4.D,

        AAAA = A | (A << 2) | (A << 4) | (A << 6),
        
        BBBB = B | (B << 2) | (B << 4) | (B << 6),

        CCCC = C | (C << 2) | (C << 4) | (C << 6),

        DDDD = D | (D << 2) | (D << 4) | (D << 6),

        AABB = A | (A<< 2) | (B << 4) | (B << 6),

        DCBA = D | (C << 2) | (B << 4) | (A << 6),
   }
}