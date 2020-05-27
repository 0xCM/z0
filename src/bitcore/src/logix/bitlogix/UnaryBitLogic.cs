//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Duet;

    /// <summary>
    /// Classifies unary logic operators
    /// </summary>
    public enum UnaryBitLogic : byte
    {
        None = 0,
        
        /// <summary>
        /// The unary operator that always returns false
        /// </summary>
        False = b00,

        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = b01,        

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity = b10,
        
        /// <summary>
        /// The unary operator that always returns true
        /// </summary>
        True = b11,        
    }  
}