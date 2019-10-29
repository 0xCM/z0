//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static BinaryLogicOpKind;
    using static UnaryLogicOpKind;

    public static partial class BitLogicSpec
    {
        /// <summary>
        /// Defines a logical not operator over an expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp not(ILogicExpr a)
            => unary(Not, a);

        /// <summary>
        /// Defines a logical not operator over a literal operand
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp not(bit a)
            => unary(Not, a);

        /// <summary>
        /// Defines a logical And operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp and(ILogicExpr a, ILogicExpr b)
            => binary(And, a, b);

        /// <summary>
        /// Defines a logical And operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp and(bit a, bit b)
            => binary(And, a, b);

        /// <summary>
        /// Defines a logical Nand operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(ILogicExpr a, ILogicExpr b)
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Nand operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(bit a, bit b)
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Or operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp or(ILogicExpr a, ILogicExpr b)
            => binary(Or, a, b);

        /// <summary>
        /// Defines a logical Or operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp or(bit a, bit b)
            => binary(Or, a, b);

        /// <summary>
        /// Defines a nor operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nor(ILogicExpr a, ILogicExpr b)
            => binary(Nor, a, b);

        /// <summary>
        /// Defines a nor operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nor(bit a, bit b)
            => binary(Nor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xor(ILogicExpr a, ILogicExpr b)
            => binary(XOr, a, b);

        /// <summary>
        /// Defines a logical Xor operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xor(bit a, bit b)
            => binary(XOr, a, b);

        /// <summary>
        /// Defines an xnor operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xnor(ILogicExpr a, ILogicExpr b)
            => binary(Xnor, a, b);

        /// <summary>
        /// Defines an xnor operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xnor(bit a, bit b)
            => binary(Xnor, a, b);

        /// <summary>
        /// Defines a left projection operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp left(ILogicExpr a, ILogicExpr b)
            => binary(LeftProject, a, b);

        /// <summary>
        /// Defines a left projection over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp left(bit a, bit b)
            => binary(LeftProject, a, b);

        /// <summary>
        /// Defines a right projection operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp right(ILogicExpr a, ILogicExpr b)
            => binary(RightProject, a, b);

        /// <summary>
        /// Defines a right projection over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp right(bit a, bit b)
            => binary(RightProject, a, b);

        /// <summary>
        /// Defines a left negation operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp lnot(ILogicExpr a, ILogicExpr b)
            => binary(LeftNot, a, b);

        /// <summary>
        /// Defines a left negation operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp lnot(bit a, bit b)
            => binary(LeftNot, a, b);

        /// <summary>
        /// Defines a right negation operator over expression operands 
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp rnot(ILogicExpr a, ILogicExpr b)
            => binary(RightNot, a, b);

        /// <summary>
        /// Defines a right negation operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp rnot(bit a, bit b)
            => binary(RightNot, a, b);

        /// <summary>
        /// Defines a material implication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp imply(ILogicExpr a, ILogicExpr b)
            => binary(Implication, a, b);
        
        /// <summary>
        /// Defines a material implication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp imply(bit a, bit b)
            => binary(Implication, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp notimply(ILogicExpr a, ILogicExpr b)
            => binary(Nonimplication, a, b);
        
        /// <summary>
        /// Defines a material nonimplication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp notimply(bit a, bit b)
            => binary(Nonimplication, a, b);

        /// <summary>
        /// Defines a converse implication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cimply(ILogicExpr a, ILogicExpr b)
            => binary(ConverseImplication, a, b);

        /// <summary>
        /// Defines a converse implication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cimply(bit a, bit b)
            => binary(ConverseImplication, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cnotimply(ILogicExpr a, ILogicExpr b)
            => binary(ConverseNonimplication, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cnotimply(bit a, bit b)
            => binary(ConverseNonimplication, a, b);

    }
}