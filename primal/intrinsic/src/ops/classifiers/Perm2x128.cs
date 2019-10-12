//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
       
    using static zfunc;

    /// <summary>
    /// Literals that define a new 256-bit vector by selecting 128-bits lanes from two 256-bit source vectors
    /// via a perm2x128 intrinsic function
    /// </summary>
    public enum Perm2x128 : byte
    {
        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [1, 3, 0, 2]
        /// </summary>
        AC = 0b00000010,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [5, 7, 0, 2]
        /// </summary>
        AD = 0b00000011,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [1, 3, 4, 6]
        /// </summary>
        BC = 0b00010010,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [5, 7, 4, 6]
        /// </summary>
        BD = 0b00010011,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [0, 2, 1, 3]
        /// </summary>
        CA = 0b00100000,
        
        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [0, 2, 5, 7]
        /// </summary>
        DA = 0b00110000,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [4, 6, 1, 3]
        /// </summary>
        CB = 0b00100001,

        /// <summary>
        /// ([0, 2, 4, 6], [1, 3, 5, 7]) -> [4, 6, 5, 7]
        /// </summary>
        DB = 0b00110001,
    }
}