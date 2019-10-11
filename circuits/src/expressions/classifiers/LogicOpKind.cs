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
    public enum LogicOpKind : uint
    {
        None = 0,
        
        /// <summary>
        /// Logical AND
        /// </summary>
        And = Pow2.T00,

        /// <summary>
        /// Logical OR
        /// </summary>
        Or = And << 1,

        /// <summary>
        /// Logical XOR
        /// </summary>
        XOr = Or << 1,

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
        Nor = Identity << 1,
        
        /// <summary>
        /// A binary operator that computes the negation of XOR and is
        /// functionally equivalent to bit value equality
        /// </summary>
        XNor = Nor << 1,

        /// <summary>
        /// A binary operator that evaluates to true iff one or both operands are false
        /// </summary>
        Nand = XNor << 1,

        /// <summary>
        /// A binary operator that evaluates the implication a -> b that means if p is true then b is true
        /// </summary>
        Implies = Nand << 1,

    } 
}