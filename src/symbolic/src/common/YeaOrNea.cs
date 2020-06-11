//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;

    /// <summary>
    /// A binary choice, symbolically
    /// </summary>
    public enum YeaOrNea : ushort
    {
        /// <summary>
        /// Aye
        /// </summary>
        Y = AsciLetterUp.Y,

        /// <summary>
        /// ~Aye
        /// </summary>
        N = AsciLetterUp.N,       
    }
}