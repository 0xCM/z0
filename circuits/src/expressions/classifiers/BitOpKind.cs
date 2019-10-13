//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    
    using static zfunc;

    /// <summary>
    /// Defines primitive operator classes that can be combined to specify user-defined operator classes
    /// </summary>
    [Flags]
    public enum BitOpKind : uint
    {            
        Literal = 0,
        
        /// <summary>
        /// Bitwise AND
        /// </summary>
        And = Pow2.T00,
        
        /// <summary>
        /// Bitwise complement of AND
        /// </summary>
        Nand = And << 1,

        /// <summary>
        /// Bitwise OR
        /// </summary>
        Or = Nand << 1,

        /// <summary>
        /// Bitwise complement of OR
        /// </summary>
        Nor = Or << 1,
        
        /// <summary>
        /// Bitwise XOR
        /// </summary>
        XOr = Nor << 1,

        /// <summary>
        /// Bitwise complement of XOR and logical equivalent of value equality operator
        /// </summary>
        XNor = XOr << 1,

        /// <summary>
        /// Bitwise complement
        /// </summary>
        Not = XNor << 1,

        /// <summary>
        /// Two's complement
        /// </summary>
        Negate = Not << 1,

        /// <summary>
        /// Logical left-shift
        /// </summary>
        Sll = Pow2.T10 << 1,

        /// <summary>
        /// Logical right-shift
        /// </summary>
        Srl = Sll << 1,

        /// <summary>
        /// Rotate left
        /// </summary>
        Rotl = Srl << 1,

        /// <summary>
        /// Rotate right
        /// </summary>
        Rotr = Rotl << 1,

        /// <summary>
        /// Arightmetic increment
        /// </summary>
        Inc = Rotr << 1,

        /// <summary>
        /// Arightmetic decrement
        /// </summary>
        Dec = Inc << 1,
    }

    /// <summary>
    /// Classifies shift operators
    /// </summary>
    [Flags]
    public enum ShiftOpKind : uint
    {
        /// <summary>
        /// Logical left-shift
        /// </summary>
        Sll = BitOpKind.Sll,

        /// <summary>
        /// Logical right-shift
        /// </summary>
        Srl = BitOpKind.Srl,

        /// <summary>
        /// Left circular shift
        /// </summary>
        Rotl = BitOpKind.Rotl,

        /// <summary>
        /// Right circular shift
        /// </summary>
        Rotr  = BitOpKind.Rotr,
    }
}