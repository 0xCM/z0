//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static Root;

    partial class TypedLogicSpec
    {
        /// <summary>
        /// Defines a typed literal where all bits are on
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> @true<T>()
            where T : unmanaged
                => maxval<T>();

        /// <summary>
        /// Defines a 128-bit cpu vector where all bits are on
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<Vector128<T>> @true<T>(N128 n)
            where T : unmanaged
                => literal(gvec.vones<T>(n));

        /// <summary>
        /// Defines a 128-bit cpu vector where all bits are on
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<Vector256<T>> @true<T>(N256 n)
            where T : unmanaged
                => literal(gvec.vones<T>(n));

        /// <summary>
        /// Defines a typed literal where all bits are off
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> @false<T>()
            where T : unmanaged
                => zero<T>();

        [MethodImpl(Inline)]
        public static LiteralExpr<Vector256<T>> @false<T>(N256 n)
            where T : unmanaged
                => literal(default(Vector256<T>));

        /// <summary>
        /// Defines a bitwise and expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> and<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitLogicOpKind.And, lhs,rhs);

        /// <summary>
        /// Defines a bitwise and expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> and<T>(T lhs, T rhs)
            where T : unmanaged
                => and(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise or expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> or<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitLogicOpKind.Or, lhs,rhs);

        /// <summary>
        /// Defines a bitwise or expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> or<T>(T lhs, T rhs)
            where T : unmanaged
                => or(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise xor expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> xor<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitLogicOpKind.Xor, lhs,rhs);

        /// <summary>
        /// Defines a bitwise xor expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> xor<T>(T lhs, T rhs)
            where T : unmanaged
                => xor(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a a bitwise complement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitwiseOpExpr<T> not<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryBitLogicOpKind.Not, operand);

        /// <summary>
        /// Defines a a bitwise complement expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryBitwiseOpExpr<T> not<T>(T operand)
            where T : unmanaged
                => not(literal(operand));

        /// <summary>
        /// Defines a bitwise NAND expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> nand<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitLogicOpKind.Nand, lhs,rhs);

        /// <summary>
        /// Defines a bitwise NAND expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> nand<T>(T lhs, T rhs)
            where T : unmanaged
                => nand(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise NOR expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> nor<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitLogicOpKind.Nor, lhs,rhs);

        /// <summary>
        /// Defines a bitwise NOR expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> nor<T>(T lhs, T rhs)
            where T : unmanaged
                => nor(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise XNOR expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> xnor<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitLogicOpKind.Xnor, lhs,rhs);

        /// <summary>
        /// Defines a bitwise XNOR expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOpExpr<T> xnor<T>(T lhs, T rhs)
            where T : unmanaged
                => xnor(literal(lhs), literal(rhs));
    }
}