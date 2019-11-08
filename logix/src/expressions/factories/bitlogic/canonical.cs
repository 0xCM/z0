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
        /// Defines a logical not operator over a logic expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp not(ILogicExpr a)
            => unary(Not, a);

        /// <summary>
        /// Defines a logical not operator over a bit literal
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp not(bit a)
            => unary(Not, a);

        /// <summary>
        /// Defines a logical not operator over a typed logic expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> not<T>(ILogicExpr<T> a)
            where T : unmanaged
                => unary(Not, a);

        /// <summary>
        /// Defines a logical not operator over a typed literal
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> not<T>(bit a)
            where T : unmanaged
                => unary<T>(Not, a);

        /// <summary>
        /// Defines a logical And operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp and(ILogicExpr a, ILogicExpr b)
            => binary(And, a, b);

        /// <summary>
        /// Defines a logical And operator over bit literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp and(bit a, bit b)
            => binary(And, a, b);

        /// <summary>
        /// Defines a logical And operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> and<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(And, a, b);

        /// <summary>
        /// Defines a logical And operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> and<T>(bit a, bit b)
            where T:  unmanaged
                => binary<T>(And, a, b);

        /// <summary>
        /// Defines a logical Nand operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(ILogicExpr a, ILogicExpr b)
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Nand operator over bit literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nand(bit a, bit b)
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Nand operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> nand<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Nand operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> nand<T>(bit a, bit b)
            where T : unmanaged
            => binary<T>(Nand, a, b);

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
        /// Defines a logical Or operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> or<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Or, a, b);

        /// <summary>
        /// Defines a logical Or operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> or<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(Or, a, b);


        /// <summary>
        /// Defines a nor operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp nor(ILogicExpr a, ILogicExpr b)
            => binary(Nor, a, b);

        /// <summary>
        /// Defines a logical Nor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> nor<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
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
        /// Defines a logical Nor operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> nor<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(Nor, a, b);

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
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> xor<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(XOr, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> xor<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(XOr, a, b);

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
        /// Defines a logical Xnor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> xnor<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Xnor, a, b);

        /// <summary>
        /// Defines a logical Xnor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> xnor<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(Xnor, a, b);

        /// <summary>
        /// Defines a left projection operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp left(ILogicExpr a, ILogicExpr b)
            => binary(LeftProject, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> left<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
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
        /// Defines a left projection operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> left<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(LeftProject, a, b);

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
        /// Defines a right projection operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> right<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(RightProject, a, b);

        /// <summary>
        /// Defines a right projection operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> right<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(RightProject, a, b);

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
        /// Defines a left negation operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> lnot<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(LeftNot, a, b);

        /// <summary>
        /// Defines a left negation operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> lnot<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(LeftNot, a, b);

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
        /// Defines a right negation operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> rnot<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(RightNot, a, b);

        /// <summary>
        /// Defines a right negation operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> rnot<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(RightNot, a, b);

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
        /// Defines a material implication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> imply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Implication, a, b);

        /// <summary>
        /// Defines a material implication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> imply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(Implication, a, b);

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
        /// Defines a material nonimplication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> notimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Nonimplication, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> notimply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(Nonimplication, a, b);

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
        /// Defines a converse implication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> cimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(ConverseImplication, a, b);

        /// <summary>
        /// Defines a converse implication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> cimply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(ConverseImplication, a, b);

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

        /// <summary>
        /// Defines a converse nonimplication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> cnotimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(ConverseNonimplication, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> cnotimply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(ConverseNonimplication, a, b);

        /// <summary>
        /// Defines a ternary select operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp select(ILogicExpr a, ILogicExpr b, ILogicExpr c)
            => ternary(TernaryOpKind.XCA, a, b, c);

        /// <summary>
        /// Defines a ternary select operator over bit literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp select(bit a, bit b, bit c)
            => ternary(TernaryOpKind.XCA, a, b, c);

        /// <summary>
        /// Defines a ternary select operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp<T> select<T>(ILogicExpr<T> a, ILogicExpr<T> b, ILogicExpr<T> c)
            where T : unmanaged
                => ternary(TernaryOpKind.XCA, a, b, c);


    }
}