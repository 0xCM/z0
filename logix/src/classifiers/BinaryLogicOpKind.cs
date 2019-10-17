//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Defines classifiers for binary (2-argument) operators
    /// </summary>
    [Flags]
    public enum BinaryLogicOpKind : uint
    {        
        /// <summary>
        /// Identifies an operator that always returns FALSE, irrespective of the supplied operands
        /// </summary>
        False = 0b0000,
        
        /// <summary>
        /// Identifies an AND operator
        /// </summary>
        And = 0b1000,

        /// <summary>
        /// Identifies an AND NOT operator that computes the AND of the first operand with the complement of the second
        /// 
        /// </summary>
        AndNot = 0b0010,
        
        /// <summary>
        /// Identifies an OR operator
        /// </summary>
        Or = 0b1110,

        /// <summary>
        /// Identifies an XOR operator
        /// </summary>
        XOr = 0b0110,
            
        /// <summary>
        /// Identifies an operator that computes the complement of OR
        /// </summary>
        Nor = 0b0001,
        
        /// <summary>
        /// Identifies an operator that computes the complement of XOR and can
        /// thus be interpreted as a value-based equality operator
        /// </summary>
        Xnor = 0b1001,

        /// <summary>
        /// Identifies an operator that computes the complement of AND and 
        /// evaluates to true iff one or both operands are false
        /// </summary>
        Nand = 0b0111,

       /// <summary>
       /// Identifies an operator that always returns True, irrespective of the supplied operands
       /// </summary>
        True = 0b1111,

        /// <summary>
        /// Identifies an operator that evaluates the implication a -> b that means if p is true then b is true
        /// </summary>
        Implies = Pow2.T08,
    
    } 
}