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
        /// Defines a unary increment expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> inc<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicOpKind.Inc, operand);

        /// <summary>
        /// Defines a unary increment expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> inc<T>(T operand)
            where T : unmanaged
                => inc(literal(operand));

        /// <summary>
        /// Defines a unary decrement expression
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> dec<T>(IExpr<T> operand)
            where T : unmanaged
                => unary(UnaryLogicOpKind.Dec, operand);

        /// <summary>
        /// Defines a decrement increment expression with a literal operand
        /// </summary>
        /// <param name="operand">The expression operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline)]
        public static UnaryLogicOp<T> dec<T>(T operand)
            where T : unmanaged
                => dec(literal(operand));


    }

}