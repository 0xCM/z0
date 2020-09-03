//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    
    using static BitSeq4;

    /// <summary>
    /// Classifies binary boolean and bitwise logical operations
    /// </summary>    
    public enum BinaryBitLogic : byte
    {         
        /// <summary>
        /// Classifies a logical  binary operator false(a,b) := bv(0000)
        /// </summary>
        /// <remarks>
        /// bv(0000) = id(True)
        /// </remarks>
        False = b0000,

        /// <summary>
        /// Identifies the operator and(a,b) := bv(1000)
        /// </summary>
        /// <remarks>
        /// bv(1000) = id(Nor)
        /// 0 0 0
        /// 1 0 0
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        And = b0001,

        /// <summary>
        /// Identifies the operator cnotimply(a,b) := and(a, ~b) = bv(0010)
        /// </summary>
        /// <remarks>
        /// bv(0010) = id(ConverseNonimplication)
        /// Truth table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        CNonImpl = b0010,

        /// <summary>
        /// Classifes a logical binary operator left(a,b) := a = bv(1010)
        /// </summary>
        /// <remarks>
        /// bv(1010) = id(RightNot)
        /// Truth Table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        LProject = b0011,

        /// <summary>
        /// Identifies a logical binary operator notimply(a,b) := and(~a, b) = bv(0100)
        /// </summary>
        /// <remarks>
        /// bv(0100) = id(Nonimplication)
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        NonImpl = b0100,

        /// <summary>
        /// Identifies the operator right(a,b) := b = bv(1100)
        /// </summary>
        /// <remarks>
        /// bv(1100) = id(LeftNot)
        /// Truth table:
        /// 0 0 0
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        RProject = b0101,

        /// <summary>
        /// Identifies the operator xor(a,b) := bv(0110)
        /// </summary>
        /// <remarks>
        /// bv(0110) = id(XOr)
        /// Truth Table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        Xor = b0110,

        /// <summary>
        /// Identifies the operator or(a,b) := bv(1110)
        /// </summary>
        /// <remarks>
        /// bv(1110) = id(Nand)
        /// Truth Table:
        /// 0 0 0
        /// 1 0 1
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        Or = b0111,

        /// <summary>
        /// Identifies the operator that computes nor(a,b) := not(or(a,b)) = bv(0001)
        /// </summary>
        /// <remarks>
        /// bv(0001) = id(And)
        /// Truth Table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        Nor = b1000, 

        /// <summary>
        /// Classifies a binary operator xnor(a,b) := not(xor(a,b)) = bv(1001)
        /// </summary>
        /// <remarks>
        /// bv(1001) = id(Xnor)
        /// Truth Table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        Xnor = b1001, 

        /// <summary>
        /// Classifes a logical binary operator rnot(a,b) := not(b) = bv(0011)
        /// </summary>
        /// <remarks>
        /// bv(0011) = id(LeftProject)
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 0
        /// </remarks>
        RNot = b1010, 

        /// <summary>
        /// Identifies the operator imply(a,b) := or(a, not(b)) = bv(1011)
        /// </summary>
        /// <remarks>
        /// bv(1011) = id(Implication)
        /// Truth table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 0
        /// 1 1 1
        /// </remarks>
        Impl = b1011,

        /// <summary>
        /// Identifies the operator lnot(a,b) := not(a) = bv(0101)
        /// </summary>
        /// <remarks>
        /// bv(0101) = id(RightProject)
        /// Truth table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        LNot = b1100, 

        /// <summary>
        /// Identifies the operator cimply(a,b) := or(not(a), b) = bv(1101)
        /// </summary>
        /// bv(1101) = id(ConverseImplication)
        /// <remarks>
        /// Truth table:
        /// 0 0 1
        /// 1 0 0
        /// 0 1 1
        /// 1 1 1
        /// </remarks>
        CImpl = b1101,

        /// <summary>
        /// Identifies the operator nand(a,b) := not(and(a,b)) = bv(0111)
        /// </summary>
        /// <remarks>
        /// bv(0111) = id(Or)
        /// Truth Table:
        /// 0 0 1
        /// 1 0 1
        /// 0 1 1
        /// 1 1 0
        /// </remarks>
        Nand = b1110, 
        
        /// <summary>
        /// Identifies the operator true(a,b) = bv(1111)
        /// </summary>
        /// <remarks>
        /// bv(1111) = id(False)
        /// </remarks>
        True = b1111, 
    }      
}