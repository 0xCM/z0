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
    public enum BinaryBitwiseOpKind : uint
    {
        /// <summary>
        /// Identifies a binary bitwise operator that always a value will all bits off
        /// </summary>
        False = BinaryLogicOpKind.False,

        /// <summary>
        /// Identifies an operator that computes not(or(a,b))
        /// </summary>
        Nor = BinaryLogicOpKind.Nor,

        /// <summary>
        /// Identifies an operator that computes and(a,not(b))
        /// </summary>
        AndNot = BinaryLogicOpKind.AndNot,

        /// <summary>
        /// Identifies an operator that computes right(a,not(b)) = not(b)
        /// </summary>
        RightNot = BinaryLogicOpKind.RightNot,

        /// <summary>
        /// Identifies an operator that computes left(not(a), b) = not(a)
        /// </summary>
        LeftNot = BinaryLogicOpKind.LeftNot,

        /// <summary>
        /// Identifies an operator that computes xor(a,b)
        /// </summary>
        XOr = BinaryLogicOpKind.XOr,

        /// <summary>
        /// Identifies an operator that computes not(and(a,b))
        /// </summary>
        Nand = BinaryLogicOpKind.Nand,

        /// <summary>
        /// Identifies an operator that computes and(a,b)
        /// </summary>
        And = BinaryLogicOpKind.And,
        
        /// <summary>
        /// Identifies an operator that computes or(a,b)
        /// </summary>
        Or = BinaryLogicOpKind.Or,

        /// <summary>
        /// Identifies an operator that computes not(xor(a,b))
        /// </summary>
        Xnor = BinaryLogicOpKind.Xnor,
        
        /// <summary>
        /// Identifies an operator that computes left(a,b) = a
        /// </summary>
        LeftProject = BinaryLogicOpKind.LeftProject,

        /// <summary>
        /// Identifies an operator that computes the bitwise equivalent of the material conditional
        /// </summary>
        Implies = BinaryLogicOpKind.Implies,

        /// <summary>
        /// Identifies an operator that computes right(a,b) = b
        /// </summary>
        RightProject = BinaryLogicOpKind.RightProject,

        /// <summary>
        /// Identifies an operator for which the result always has all bits on
        /// </summary>
        True = BinaryLogicOpKind.True,


    }
     


}