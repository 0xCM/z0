//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;


    /// <summary>
    /// Defines logical operators whose operands are bitwise expressions
    /// </summary>
    [Flags]
    public enum BinaryLogic : uint
    {
        
        /// <summary>
        /// Logical FALSE
        /// </summary>
        False = 0b0000,
        
        /// <summary>
        /// Logical AND
        /// </summary>
        And = 0b1000,

        AndNot = 0b0010,
        
        /// <summary>
        /// Logical OR
        /// </summary>
        Or = 0b1110,

        /// <summary>
        /// Logical XOR
        /// </summary>
        XOr = 0b0110,

        /// <summary>
        /// Logial NOT
        /// </summary>
        Not = XOr << 1,
        
        /// <summary>
        /// A unary operator that yields the value of its operand
        /// </summary>
        Identity = Not << 1,
        
        /// <summary>
        /// A binary operator that computes the negation of OR
        /// </summary>
        Nor = 0b0001,
        
        /// <summary>
        /// A binary operator that computes the negation of XOR and is functionally equivalent to bit value equality
        /// </summary>
        XNor = 0b1001,

        /// <summary>
        /// A binary operator that evaluates to true iff one or both operands are false
        /// </summary>
        Nand = 0b0111,

        True = 0b1111,

        /// <summary>
        /// A binary operator that evaluates the implication a -> b that means if p is true then b is true
        /// </summary>
        Implies = Pow2.T08,


    } 
}