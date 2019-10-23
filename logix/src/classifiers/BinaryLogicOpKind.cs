//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;


    /// <summary>
    /// Defines classifiers for logical binary operators
    /// </summary>
    [Flags]
    public enum BinaryLogicOpKind : uint
    {        
        /// <summary>
        /// Identifies an operator that always returns FALSE
        /// </summary>
        False = 0b0000,

        /// <summary>
        /// Identifies an operator that computes the complement of OR
        /// </summary>
        Nor = 0b0001,

        /// <summary>
        /// Identifies an operator that computes the converse nonimplication (AND NOT ) operator  that 
        /// computes the conjunction of the first operand with the negation of the second
        /// </summary>
        /// <remarks>
        /// Truth table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        AndNot = 0b0010,

        /// <summary>
        /// Identifies an operator that computes the negation of the right operand
        /// </summary>
        /// <remarks>
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        RightNot = 0b0011,

        /// <summary>
        /// Identifies an operator that computes the negation of the material conditional
        /// </summary>
        /// <remarks>
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        MaterialNonimplication = 0b0100,

        /// <summary>
        /// Identifies an operator that computes the negation of the left operand
        /// </summary>
        /// <remarks>
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        LeftNot = 0b0101,                    

        /// <summary>
        /// Identifies an XOR operator
        /// </summary>
        XOr = 0b0110,

        /// <summary>
        /// Identifies an operator that computes the complement of AND and 
        /// evaluates to true iff one or both operands are false
        /// </summary>
        Nand = 0b0111,

        /// <summary>
        /// Identifies an operator that computes the conjunction of its operands
        /// </summary>
        And = 0b1000,

        /// <summary>
        /// Identifies an operator that computes the negation of XOR and can be interpreted as an equality operator
        /// </summary>
        Xnor = 0b1001,

        /// <summary>
        /// Identifies an operator that computes the disjunction of its operands
        /// </summary>
        Or = 0b1110,
        
        /// <summary>
        /// Identifies an operator that selects the value of the left operand
        /// </summary>
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        LeftProject = 0b1010,

        /// <summary>
        /// Identifies an operator that evaluates the material conditional (implication) a → b
        /// </summary>
        /// <remarks>
        /// Truth table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        Implies = 0b1011,

        /// <summary>
        /// Identifies an operator that selects the value of the right operand
        /// </summary>
        /// <remarks>
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        RightProject = 0b1100,
        
        /// <summary>
        /// Identifies an operator that computes the converse implication a ← b
        /// </summary>
        /// <remarks>
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        ConvImplies = 0b1101,

       /// <summary>
       /// Identifies an operator that always returns True, irrespective of the supplied operands
       /// </summary>
        True = 0b1111,
    
    } 
}