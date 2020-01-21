//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static zfunc;

    /// <summary>
    /// Classifies binary bitwise operators
    /// </summary>
    public enum BinaryBitwiseOpKind : byte
    {
        /// <summary>
        /// Classifies a bitwise binary operator true(a,b) = 0xFFFFFFF...
        /// </summary>
        True = BinaryBitLogicKind.True,

        /// <summary>
        /// Identifies a binary bitwise operator that always a value will all bits off
        /// </summary>
        False = BinaryBitLogicKind.False,

        /// <summary>
        /// Identifies an operator that computes and(a,b)
        /// </summary>
        And = BinaryBitLogicKind.And,

        /// <summary>
        /// Classifies a bitwise binary operator nand(a,b) := not(and(a,b))
        /// </summary>
        Nand = BinaryBitLogicKind.Nand,

            /// <summary>
        /// Classifies a bitwise binary operator or(a,b) := OR(a,b)
        /// </summary>
        Or = BinaryBitLogicKind.Or,

        /// <summary>
        /// Classifies a bitwise binary operator that computes nor(a,b) := not(or(a,b))
        /// </summary>
        Nor = BinaryBitLogicKind.Nor,

        /// <summary>
        /// Classifies a bitwise binary operator that computes xor(a,b) = XOR(a,b)
        /// </summary>
        XOr = BinaryBitLogicKind.XOr,
    
        /// <summary>
        /// Classifies a bitwise binary operator xnor(a,b) := ~xor(a,b)
        /// </summary>
        Xnor = BinaryBitLogicKind.Xnor,
        
        /// <summary>
        /// Classifes a bitwise binary operator left(a,b) := a
        /// </summary>
        LeftProject = BinaryBitLogicKind.LeftProject,

        /// <summary>
        /// Identifies an operator that computes right(a,b) = b
        /// </summary>
        RightProject = BinaryBitLogicKind.RightProject,

        /// <summary>
        /// Classifies a bitwise binary operator lnot(a,b) := not(a)
        /// </summary>
        LeftNot = BinaryBitLogicKind.LeftNot,

        /// <summary>
        /// Classifes a bitwise binary operator rnot(a,b) := not(b)
        /// </summary>
        RightNot = BinaryBitLogicKind.RightNot,

        /// <summary>
        /// Classifies a bitwise binary operator imply(a,b) := or(a, not(b))
        /// </summary>
        Implication = BinaryBitLogicKind.Implication,

        /// <summary>
        /// Identifies a bitwise binary operator notimply(a,b) := and(not(a), b)
        /// </summary>
        Nonimplication = BinaryBitLogicKind.Nonimplication,

        /// <summary>
        /// Identifies an operator cnotimply(a,b) := and(a,not(b))
        /// </summary>
        ConverseNonimplication = BinaryBitLogicKind.ConverseNonimplication,

        /// <summary>
        /// Classifies a bitwise binary operator cimply(a,b) := or(not(a), b)
        /// </summary>
        ConverseImplication = BinaryBitLogicKind.ConverseImplication,

    }
}