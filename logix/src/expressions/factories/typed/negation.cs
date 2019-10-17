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

    partial class TypedLogicSpec
    {
        /// <summary>
        /// Defines a a bitwise complement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> not<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicOpKind.Not, operand);

        /// <summary>
        /// Defines a a bitwise complement expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> not<T>(T operand)
            where T : unmanaged
                => not(literal(operand));

        /// <summary>
        /// Defines a two's-complement negation expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> negate<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicOpKind.Negate, operand);

        /// <summary>
        /// Defines a two's-complement negation expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> negate<T>(T operand)
            where T : unmanaged
                => negate(literal(operand));

        /// <summary>
        /// Defines a bitwise NAND expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> nand<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicOpKind.Nand, lhs,rhs);

        /// <summary>
        /// Defines a bitwise NAND expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> nand<T>(T lhs, T rhs)
            where T : unmanaged
                => nand(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise NOR expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> nor<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicOpKind.Nor, lhs,rhs);

        /// <summary>
        /// Defines a bitwise NOR expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> nor<T>(T lhs, T rhs)
            where T : unmanaged
                => nor(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise XNOR expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> xnor<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicOpKind.Xnor, lhs,rhs);

        /// <summary>
        /// Defines a bitwise XNOR expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> xnor<T>(T lhs, T rhs)
            where T : unmanaged
                => xnor(literal(lhs), literal(rhs));
    }

}