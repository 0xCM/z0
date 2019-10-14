//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Specifies ternary logic operator identifiers consistent with AVX-512 encoding
    /// </summary>
    [Flags]
    public enum NullaryLogic : byte
    {
        
        /// <summary>
        /// Identifies the function that accepts no input always returns false
        /// </summary>
        False = 0,

        /// <summary>
        /// Identifies the function that accepts no input always returns true
        /// </summary>
        True = 1
    }
}


