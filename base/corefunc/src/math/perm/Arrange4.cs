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
        A = 0b00,

        /// <summary>
        /// Identifies the second of four symbols
        /// </summary>
        B = 0b01,

        /// <summary>
        /// Identifies the third of four ssymbols
        /// </summary>
        C = 0b10,

        /// <summary>
        /// Identifies the fourth of four symbols
        /// </summary>
        D = 0b11,

        AAAA = A | (A << 2) | (A << 4) | (A << 6),
        
        BBBB = B | (B << 2) | (B << 4) | (B << 6),

        CCCC = C | (C << 2) | (C << 4) | (C << 6),

        DDDD = D | (D << 2) | (D << 4) | (D << 6),

        AABB = A | (A<< 2) | (B << 4) | (B << 6),
   }


}