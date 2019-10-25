//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classifies boolean binary operators
    /// </summary>
    [Flags]
    public enum BinaryLogicOpKind : uint
    {        
        /// <summary>
        /// Classifies a binary operator that always returns FALSE
        /// </summary>
        /// <remarks>
        /// Signature: 0000
        /// </remarks>
        False = 0b0000,

        /// <summary>
        /// Identifies a binary operator that computes the complement of OR
        /// </summary>
        /// <remarks>
        /// Signature: 0001
        /// </remarks>
        Nor = 0b001,

        /// <summary>
        /// Identifies a binary operator that computes the converse nonimplication (AND NOT) operator  that 
        /// computes the conjunction of the first operand with the negation of the second
        /// </summary>
        /// <remarks>
        /// Signature: 0010
        /// Truth table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        AndNot = 0b0010,

        /// <summary>
        /// Identifies a binary operator that computes the negation of the right operand
        /// </summary>
        /// <remarks>
        /// Signature: 0011
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        RightNot = 0b0011,

        /// <summary>
        /// Identifies a binary operator that computes the negation of the material conditional
        /// </summary>
        /// <remarks>
        /// Signature: 0100
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        MaterialNonimplication = 0b0100,

        /// <summary>
        /// Classifies a binary operator that computes the negation of the left operand
        /// </summary>
        /// <remarks>
        /// Signature: 0101
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        LeftNot = 0b0101,

        /// <summary>
        /// Classifies a binary operator that computes the XOR between its operands
        /// </summary>
        /// <remarks>
        /// Signature: 0110
        /// </remarks>
        XOr = 0b0110,

        /// <summary>
        /// Identifies a binary operator that computes the complement of AND and evaluates to true iff one or both operands are false
        /// </summary>
        /// <remarks>
        /// Signature: 0111
        /// </remarks>
        Nand = 0b0111,

        /// <summary>
        /// Classifies a binary operator that computes the conjunction of its operands
        /// </summary>
        /// <remarks>
        /// Signature: 1000
        /// </remarks>
        And = 0b1000,

        /// <summary>
        /// Classifies a binary operator that computes the negation of XOR and can be interpreted as an equality operator
        /// </summary>
        /// <remarks>
        /// Signature: 1001
        /// </remarks>
        Xnor = 0b1001,
        
        /// <summary>
        /// Classifes a binary operator that selects the value of the left operand
        /// </summary>
        /// <remarks>
        /// Signature: 1010
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        LeftProject = 0b1010,

        /// <summary>
        /// Classifies a binary operator that evaluates the material conditional (implication) a → b
        /// </summary>
        /// <remarks>
        /// Truth table:
        /// Signature: 1011
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        Implies = 0b1011,

        /// <summary>
        /// Classifies a binary operator that selects the value of the right operand
        /// </summary>
        /// <remarks>
        /// Signature: 1100
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        RightProject = 0b1100,

        /// <summary>
        /// Classifies a binary operator that computes the converse implication a ← b
        /// </summary>
        /// <remarks>
        /// Signature: 1101
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        ConvImplies = 0b1101,

        /// <summary>
        /// Classifies a binary operator that computes the disjunction of its operands
        /// </summary>
        /// <remarks>
        /// Signature: 1110
        /// </remarks>
        Or = 0b1110,

        /// <summary>
        /// Classifies a binary operator that always returns TRUE
        /// </summary>
        /// <remarks>
        /// Signature: 1111
        /// </remarks>
        True = 0b1111,
    
    } 
}