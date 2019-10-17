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
        /// Defines a bitwise and expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> and<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicOpKind.And, lhs,rhs);


        /// <summary>
        /// Defines a bitwise and expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> and<T>(T lhs, T rhs)
            where T : unmanaged
                => and(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise or expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> or<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicOpKind.Or, lhs,rhs);

        /// <summary>
        /// Defines a bitwise or expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> or<T>(T lhs, T rhs)
            where T : unmanaged
                => or(literal(lhs), literal(rhs));

        /// <summary>
        /// Defines a bitwise xor expression
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> xor<T>(IExpr<T> lhs, IExpr<T> rhs)
            where T : unmanaged
                => binary(BinaryLogicOpKind.XOr, lhs,rhs);

        /// <summary>
        /// Defines a bitwise xor expression with literal operands
        /// </summary>
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static BinaryLogicOp<T> xor<T>(T lhs, T rhs)
            where T : unmanaged
                => xor(literal(lhs), literal(rhs));



    }

}