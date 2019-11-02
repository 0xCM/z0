//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classifies binary bitwise operators
    /// </summary>
    //[Flags]
    public enum BinaryBitwiseOpKind : byte
    {
        /// <summary>
        /// Classifies a bitwise binary operator true(a,b) = 0xFFFFFFF...
        /// </summary>
        True = BinaryLogicOpKind.True,

        /// <summary>
        /// Identifies a binary bitwise operator that always a value will all bits off
        /// </summary>
        False = BinaryLogicOpKind.False,

        /// <summary>
        /// Identifies an operator that computes and(a,b)
        /// </summary>
        And = BinaryLogicOpKind.And,

        /// <summary>
        /// Classifies a bitwise binary operator nand(a,b) := not(and(a,b))
        /// </summary>
        Nand = BinaryLogicOpKind.Nand,

            /// <summary>
        /// Classifies a bitwise binary operator or(a,b) := OR(a,b)
        /// </summary>
        Or = BinaryLogicOpKind.Or,

        /// <summary>
        /// Classifies a bitwise binary operator that computes nor(a,b) := not(or(a,b))
        /// </summary>
        Nor = BinaryLogicOpKind.Nor,

        /// <summary>
        /// Classifies a bitwise binary operator that computes xor(a,b) = XOR(a,b)
        /// </summary>
        XOr = BinaryLogicOpKind.XOr,
    
        /// <summary>
        /// Classifies a bitwise binary operator xnor(a,b) := ~xor(a,b)
        /// </summary>
        Xnor = BinaryLogicOpKind.Xnor,
        
        /// <summary>
        /// Classifes a bitwise binary operator left(a,b) := a
        /// </summary>
        LeftProject = BinaryLogicOpKind.LeftProject,

        /// <summary>
        /// Identifies an operator that computes right(a,b) = b
        /// </summary>
        RightProject = BinaryLogicOpKind.RightProject,

        /// <summary>
        /// Classifies a bitwise binary operator lnot(a,b) := not(a)
        /// </summary>
        LeftNot = BinaryLogicOpKind.LeftNot,

        /// <summary>
        /// Classifes a bitwise binary operator rnot(a,b) := not(b)
        /// </summary>
        RightNot = BinaryLogicOpKind.RightNot,

        /// <summary>
        /// Classifies a bitwise binary operator imply(a,b) := or(a, not(b))
        /// </summary>
        Implication = BinaryLogicOpKind.Implication,

        /// <summary>
        /// Identifies a bitwise binary operator notimply(a,b) := and(not(a), b)
        /// </summary>
        Nonimplication = BinaryLogicOpKind.Nonimplication,

        /// <summary>
        /// Identifies an operator cnotimply(a,b) := and(a,not(b))
        /// </summary>
        ConverseNonimplication = BinaryLogicOpKind.ConverseNonimplication,

        /// <summary>
        /// Classifies a bitwise binary operator cimply(a,b) := or(not(a), b)
        /// </summary>
        ConverseImplication = BinaryLogicOpKind.ConverseImplication,

    }
    

}