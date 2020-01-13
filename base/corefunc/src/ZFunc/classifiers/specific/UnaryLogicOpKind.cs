//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classifies unary logic operators
    /// </summary>
    public enum UnaryLogicOpKind : byte
    {
        /// <summary>
        /// The unary operator that always returns false
        /// </summary>
        False = 0b00,

        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = 0b01,        

        /// <summary>
        /// The identity operator
        /// </summary>
        Identity = 0b10,
        
        /// <summary>
        /// The unary operator that always returns true
        /// </summary>
        True = 0b11,

    }

}