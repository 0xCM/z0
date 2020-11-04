//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static BinaryBitLogicKind;
    using static UnaryBitLogicKind;

    [ApiHost]
    public partial struct BitLogicSpec
    {
        /// <summary>
        /// Defines a logical not operator over a logic expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOpExpr not(ILogicExpr a)
            => unary(Not, a);

        /// <summary>
        /// Defines a logical not operator over a bit literal
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOpExpr not(Bit32 a)
            => unary(Not, a);

        /// <summary>
        /// Defines a logical not operator over a typed logic expression
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOpExpr<T> not<T>(ILogicExpr<T> a)
            where T : unmanaged
                => unary(Not, a);

        /// <summary>
        /// Defines a logical not operator over a typed literal
        /// </summary>
        /// <param name="a">The operand</param>
        [MethodImpl(Inline)]
        public static UnaryLogicOpExpr<T> not<T>(Bit32 a)
            where T : unmanaged
                => unary<T>(Not, a);

        /// <summary>
        /// Defines a logical And operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr and(ILogicExpr a, ILogicExpr b)
            => binary(And, a, b);

        /// <summary>
        /// Defines a logical And operator over bit literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr and(Bit32 a, Bit32 b)
            => binary(And, a, b);

        /// <summary>
        /// Defines a logical And operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> and<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(And, a, b);

        /// <summary>
        /// Defines a logical And operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> and<T>(Bit32 a, Bit32 b)
            where T:  unmanaged
                => binary<T>(And, a, b);

        /// <summary>
        /// Defines a logical Nand operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr nand(ILogicExpr a, ILogicExpr b)
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Nand operator over bit literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr nand(Bit32 a, Bit32 b)
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Nand operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> nand<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
            => binary(Nand, a, b);

        /// <summary>
        /// Defines a logical Nand operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> nand<T>(Bit32 a, Bit32 b)
            where T : unmanaged
            => binary<T>(Nand, a, b);

        /// <summary>
        /// Defines a logical Or operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr or(ILogicExpr a, ILogicExpr b)
            => binary(Or, a, b);

        /// <summary>
        /// Defines a logical Or operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr or(Bit32 a, Bit32 b)
            => binary(Or, a, b);

        /// <summary>
        /// Defines a logical Or operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> or<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Or, a, b);

        /// <summary>
        /// Defines a logical Or operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> or<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(Or, a, b);

        /// <summary>
        /// Defines a nor operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr nor(ILogicExpr a, ILogicExpr b)
            => binary(Nor, a, b);

        /// <summary>
        /// Defines a logical Nor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> nor<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Nor, a, b);

        /// <summary>
        /// Defines a nor operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr nor(Bit32 a, Bit32 b)
            => binary(Nor, a, b);

        /// <summary>
        /// Defines a logical Nor operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> nor<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(Nor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr xor(ILogicExpr a, ILogicExpr b)
            => binary(Xor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr xor(Bit32 a, Bit32 b)
            => binary(Xor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> xor<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Xor, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> xor<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(Xor, a, b);

        /// <summary>
        /// Defines an xnor operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr xnor(ILogicExpr a, ILogicExpr b)
            => binary(Xnor, a, b);

        /// <summary>
        /// Defines an xnor operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr xnor(Bit32 a, Bit32 b)
            => binary(Xnor, a, b);

        /// <summary>
        /// Defines a logical Xnor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> xnor<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Xnor, a, b);

        /// <summary>
        /// Defines a logical Xnor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> xnor<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(Xnor, a, b);

        /// <summary>
        /// Defines a left projection operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr left(ILogicExpr a, ILogicExpr b)
            => binary(LProject, a, b);

        /// <summary>
        /// Defines a logical Xor operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> left<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(LProject, a, b);

        /// <summary>
        /// Defines a left projection over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr left(Bit32 a, Bit32 b)
            => binary(LProject, a, b);

        /// <summary>
        /// Defines a left projection operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> left<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(LProject, a, b);

        /// <summary>
        /// Defines a right projection operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr right(ILogicExpr a, ILogicExpr b)
            => binary(RProject, a, b);

        /// <summary>
        /// Defines a right projection over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr right(Bit32 a, Bit32 b)
            => binary(RProject, a, b);

        /// <summary>
        /// Defines a right projection operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> right<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(RProject, a, b);

        /// <summary>
        /// Defines a right projection operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> right<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(RProject, a, b);

        /// <summary>
        /// Defines a left negation operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr lnot(ILogicExpr a, ILogicExpr b)
            => binary(LNot, a, b);

        /// <summary>
        /// Defines a left negation operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr lnot(Bit32 a, Bit32 b)
            => binary(LNot, a, b);

        /// <summary>
        /// Defines a left negation operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> lnot<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(LNot, a, b);

        /// <summary>
        /// Defines a left negation operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> lnot<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(LNot, a, b);

        /// <summary>
        /// Defines a right negation operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr rnot(ILogicExpr a, ILogicExpr b)
            => binary(RNot, a, b);

        /// <summary>
        /// Defines a right negation operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr rnot(Bit32 a, Bit32 b)
            => binary(RNot, a, b);

        /// <summary>
        /// Defines a right negation operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> rnot<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(RNot, a, b);

        /// <summary>
        /// Defines a right negation operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> rnot<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(RNot, a, b);

        /// <summary>
        /// Defines a material implication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr imply(ILogicExpr a, ILogicExpr b)
            => binary(Impl, a, b);

        /// <summary>
        /// Defines a material implication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr imply(Bit32 a, Bit32 b)
            => binary(Impl, a, b);

        /// <summary>
        /// Defines a material implication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> imply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(Impl, a, b);

        /// <summary>
        /// Defines a material implication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> imply<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(Impl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr notimply(ILogicExpr a, ILogicExpr b)
            => binary(NonImpl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr notimply(Bit32 a, Bit32 b)
            => binary(NonImpl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> notimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(NonImpl, a, b);

        /// <summary>
        /// Defines a material nonimplication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> notimply<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(NonImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr cimply(ILogicExpr a, ILogicExpr b)
            => binary(CImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr cimply(Bit32 a, Bit32 b)
            => binary(CImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> cimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(CImpl, a, b);

        /// <summary>
        /// Defines a converse implication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> cimply<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(CImpl, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr cnotimply(ILogicExpr a, ILogicExpr b)
            => binary(CNonImpl, a, b);

       /// <summary>
        /// Defines a converse nonimplication operator over literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr cnotimply(Bit32 a, Bit32 b)
            => binary(CNonImpl, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static BinaryLogicOpExpr<T> cnotimply<T>(ILogicExpr<T> a, ILogicExpr<T> b)
            where T : unmanaged
                => binary(CNonImpl, a, b);

        /// <summary>
        /// Defines a converse nonimplication operator over typed literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        static BinaryLogicOpExpr<T> cnotimply<T>(Bit32 a, Bit32 b)
            where T : unmanaged
                => binary<T>(CNonImpl, a, b);

        /// <summary>
        /// Defines a ternary select operator over expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOpExpr select(ILogicExpr a, ILogicExpr b, ILogicExpr c)
            => ternary(TernaryBitLogicKind.XCA, a, b, c);

        /// <summary>
        /// Defines a ternary select operator over bit literal operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOpExpr select(Bit32 a, Bit32 b, Bit32 c)
            => ternary(TernaryBitLogicKind.XCA, a, b, c);

        /// <summary>
        /// Defines a ternary select operator over typed expression operands
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        [MethodImpl(Inline)]
        public static TernaryLogicOpExpr<T> select<T>(ILogicExpr<T> a, ILogicExpr<T> b, ILogicExpr<T> c)
            where T : unmanaged
                => ternary(TernaryBitLogicKind.XCA, a, b, c);
    }
}