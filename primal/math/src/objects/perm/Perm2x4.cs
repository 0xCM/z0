//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static zfunc;    
    
    /// <summary>
    /// Identifies 2-element cycles over 4 symbols
    /// </summary>
    public enum Perm2x4 : byte
    {
        /// <summary>
        /// [00 10 00 00]:([0, 1, 2, 3], [4, 5, 6, 7]) -> [0, 1, 4, 5]
        /// </summary>
        AC = Perm4.A | Perm4.C << 4,

        /// <summary>
        /// [00 00 00 10]:([0, 1, 2, 3], [4, 5, 6, 7]) -> [4, 5, 0, 1]
        /// </summary>
        CA = Perm4.C | Perm4.A << 4,

        /// <summary>
        /// [00 11 00 00]:([0, 1, 2, 3], [4, 5, 6, 7]) -> [0, 1, 6, 7]
        /// </summary>
        AD = Perm4.A | Perm4.D << 4,

        /// <summary>
        /// [00 00 00 11]:([0, 1, 2, 3], [4, 5, 6, 7]) -> [6, 7, 0, 1]
        /// </summary>
        DA = Perm4.D | Perm4.A << 4,

        /// <summary>
        /// [00 10 00 01]:([0, 1, 2, 3], [4, 5, 6, 7]) -> [2, 3, 4, 5]
        /// </summary>
        BC = Perm4.B | Perm4.C << 4,

        /// <summary>
        /// [00 01 00 10]:([0, 1, 2, 3], [4, 5, 6, 7]) -> [4, 5, 2, 3]
        /// </summary>
        CB = Perm4.C | Perm4.B << 4, 

        /// <summary>
        /// [00 11 00 01]:([0, 1, 2, 3], [4, 5, 6, 7]) -> [2, 3, 6, 7]
        /// </summary>
        BD = Perm4.B | Perm4.D << 4, 

        /// <summary>
        /// [00 01 00 11:] ([0, 1, 2, 3], [4, 5, 6, 7]) -> [6, 7, 2, ]
        /// </summary>
        DB = Perm4.D | Perm4.B << 4,     
    }    
}