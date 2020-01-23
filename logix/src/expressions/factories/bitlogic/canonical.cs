//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    
    using static zfunc;
    using static BinaryBitLogicKind;
    using static UnaryBitLogicKind;

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
            => binary(Xor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp xor(bit a, bit b)
            => binary(Xor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> xor<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Xor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> xor<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(Xor, a, b);

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
            => binary(LProject, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> left<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(LProject, a, b);

        /// <summary>
        /// Defines a left projection over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp left(bit a, bit b)
            => binary(LProject, a, b);

        /// <summary>
        /// Defines a left projection operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> left<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(LProject, a, b);

        /// <summary>
        /// Defines a right projection operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp right(ILogicExpr a, ILogicExpr b)
            => binary(RProject, a, b);

        /// <summary>
        /// Defines a right projection over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp right(bit a, bit b)
            => binary(RProject, a, b);

        /// <summary>
        /// Defines a right projection operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> right<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(RProject, a, b);

        /// <summary>
        /// Defines a right projection operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> right<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(RProject, a, b);

        /// <summary>
        /// Defines a left negation operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp lnot(ILogicExpr a, ILogicExpr b)
            => binary(LNot, a, b);

        /// <summary>
        /// Defines a left negation operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp lnot(bit a, bit b)
            => binary(LNot, a, b);

        /// <summary>
        /// Defines a left negation operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> lnot<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(LNot, a, b);

        /// <summary>
        /// Defines a left negation operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> lnot<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(LNot, a, b);

        /// <summary>
        /// Defines a right negation operator over expression operands 
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp rnot(ILogicExpr a, ILogicExpr b)
            => binary(RNot, a, b);

        /// <summary>
        /// Defines a right negation operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp rnot(bit a, bit b)
            => binary(RNot, a, b);

        /// <summary>
        /// Defines a right negation operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> rnot<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(RNot, a, b);

        /// <summary>
        /// Defines a right negation operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> rnot<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(RNot, a, b);

        /// <summary>
        /// Defines a material implication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp imply(ILogicExpr a, ILogicExpr b)
            => binary(Impl, a, b);

        /// <summary>
        /// Defines a material implication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp imply(bit a, bit b)
            => binary(Impl, a, b);

        /// <summary>
        /// Defines a material implication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> imply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Impl, a, b);

        /// <summary>
        /// Defines a material implication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> imply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(Impl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp notimply(ILogicExpr a, ILogicExpr b)
            => binary(NonImpl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp notimply(bit a, bit b)
            => binary(NonImpl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> notimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(NonImpl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> notimply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(NonImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cimply(ILogicExpr a, ILogicExpr b)
            => binary(CImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cimply(bit a, bit b)
            => binary(CImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> cimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(CImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> cimply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(CImpl, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cnotimply(ILogicExpr a, ILogicExpr b)
            => binary(CNonImpl, a, b);

       /// <summary>
        /// Defines a converse nonimplication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp cnotimply(bit a, bit b)
            => binary(CNonImpl, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> cnotimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(CNonImpl, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOp<T> cnotimply<T>(bit a, bit b)
            where T : unmanaged
                => binary<T>(CNonImpl, a, b);

        /// <summary>
        /// Defines a ternary select operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp select(ILogicExpr a, ILogicExpr b, ILogicExpr c)
            => ternary(TernaryBitLogicKind.XCA, a, b, c);

        /// <summary>
        /// Defines a ternary select operator over bit literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp select(bit a, bit b, bit c)
            => ternary(TernaryBitLogicKind.XCA, a, b, c);

        /// <summary>
        /// Defines a ternary select operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOp<T> select<T>(ILogicExpr<T> a, ILogicExpr<T> b, ILogicExpr<T> c)
            where T : unmanaged
                => ternary(TernaryBitLogicKind.XCA, a, b, c);


    }
}