//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Logix
{
    using System;
    using System.Linq;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;
    
    using static zfunc;

    partial class TypedLogicSpec
    {
        /// <summary>
        /// Defines a typed literal where all bits are on
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> @true<T>()
            where T : unmanaged
                => gmath.maxval<T>();

        /// <summary>
        /// Defines a 128-bit cpu vector where all bits are on
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<Vector128<T>> @true<T>(N128 n)
            where T : unmanaged
                => literal(ginx.vones<T>(n));


        /// <summary>
        /// Defines a 128-bit cpu vector where all bits are on
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<Vector256<T>> @true<T>(N256 n)
            where T : unmanaged
                => literal(ginx.vones<T>(n));

        /// <summary>
        /// Defines a typed literal where all bits are off
        /// </summary>
        /// <typeparam name="T">The literal type</typeparam>
        [MethodImpl(Inline)]
        public static LiteralExpr<T> @false<T>()
            where T : unmanaged
                => gmath.zero<T>();

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
        public static BinaryBitwiseOp<T> and<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitwiseOpKind.And, lhs,rhs);

        /// <summary>
        /// Defines a bitwise and expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> and<T>(T lhs, T rhs)
            where T : unmanaged
                => and(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise or expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> or<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitwiseOpKind.Or, lhs,rhs);

        /// <summary>
        /// Defines a bitwise or expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> or<T>(T lhs, T rhs)
            where T : unmanaged
                => or(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise xor expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> xor<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitwiseOpKind.XOr, lhs,rhs);

        /// <summary>
        /// Defines a bitwise xor expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> xor<T>(T lhs, T rhs)
            where T : unmanaged
                => xor(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a a bitwise complement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOpSpec<T> not<T>(ITypedExpr<T> operand)
            where T : unmanaged
                => unary(UnaryBitwiseOpKind.Not, operand);

        /// <summary>
        /// Defines a a bitwise complement expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOpSpec<T> not<T>(T operand)
            where T : unmanaged
                => not(literal(operand));

        /// <summary>
        /// Defines a two's-complement negation expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOpSpec<T> negate<T>(ITypedExpr<T> operand)
            where T : unmanaged
                => unary(UnaryBitwiseOpKind.Negate, operand);

        /// <summary>
        /// Defines a two's-complement negation expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryOpSpec<T> negate<T>(T operand)
            where T : unmanaged
                => negate(literal(operand));

        /// <summary>
        /// Defines a bitwise NAND expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> nand<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitwiseOpKind.Nand, lhs,rhs);

        /// <summary>
        /// Defines a bitwise NAND expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> nand<T>(T lhs, T rhs)
            where T : unmanaged
                => nand(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise NOR expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> nor<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitwiseOpKind.Nor, lhs,rhs);

        /// <summary>
        /// Defines a bitwise NOR expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> nor<T>(T lhs, T rhs)
            where T : unmanaged
                => nor(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise XNOR expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> xnor<T>(ITypedExpr<T> lhs, ITypedExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryBitwiseOpKind.Xnor, lhs,rhs);

        /// <summary>
        /// Defines a bitwise XNOR expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryBitwiseOp<T> xnor<T>(T lhs, T rhs)
            where T : unmanaged
                => xnor(literal(lhs), literal(rhs));
 

    }

}