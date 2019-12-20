//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;    
    using static Perm4Sym;
    
    /// <summary>
    /// Identifies 2-element cycles over 4 symbols
    /// </summary>
    public enum Perm2x4 : byte
    {
        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [0, 1, 4, 5]
        /// </summary>
        AC = A | C << 4,

        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [4, 5, 0, 1]
        /// </summary>
        CA = C | A << 4,

        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [0, 1, 6, 7]
        /// </summary>
        AD = A | D << 4,

        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [6, 7, 0, 1]
        /// </summary>
        DA = D | A << 4,

        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [2, 3, 4, 5]
        /// </summary>
        BC = B | C << 4,

        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [4, 5, 2, 3]
        /// </summary>
        CB = C | B << 4, 

        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [2, 3, 6, 7]
        /// </summary>
        BD = B | D << 4, 

        /// <summary>
        /// ([0, 1, 2, 3], [4, 5, 6, 7]) -> [6, 7, 2, 3]
        /// </summary>
        DB = D | B << 4,     
    }    
}