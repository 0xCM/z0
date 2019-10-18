//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    /// <summary>
    /// Classifies logical operators that accept no input
    /// </summary>
    [Flags]
    public enum NullaryLogicOpKind : byte
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


