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

    partial class Bitwise
    {

        public enum ExprArity
        {
            Literal = 0,

            Unary = 1,

            Binary = 2,

            Ternary = 3
        }

        /// <summary>
        /// Defines primitive operator classes in the expression language
        /// which can be combined to specify user-defined operator classes
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
            /// Bitwise OR
            /// </summary>
            Or = And << 1,

            /// <summary>
            /// Bitwise XOR
            /// </summary>
            XOr = Or << 1,

            /// <summary>
            /// One's complement
            /// </summary>
            Not = XOr << 1,

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

        }

        /// <summary>
        /// Defines logical operators whose operands are bitwise expressions
        /// </summary>
        [Flags]
        public enum LogicOpKind : uint
        {
            None = 0,
            
            /// <summary>
            /// Bitwise AND
            /// </summary>
            And = Pow2.T00,

            /// <summary>
            /// Bitwise OR
            /// </summary>
            Or = And << 1,

            /// <summary>
            /// Bitwise XOR
            /// </summary>
            XOr = Or << 1,

            /// <summary>
            /// Bitwise XOR
            /// </summary>
            Not = XOr << 1,
        
            /// <summary>
            /// Evaluates to 1 if the compared operands are equal, 0 otherwise
            /// </summary>
            Eq = Pow2.T10,


            /// <summary>
            /// Evaluates to 1 if the compared operands are not equal, 0 otherwise
            /// </summary>
            NEq = Eq << 1,

        }

    }
}