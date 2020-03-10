//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static Nats;
    using static FKT;

    public static class FK
    {
        /// <summary>
        /// Reifies an emitter
        /// </summary>
        /// <param name="r">An emission type representative</param>
        /// <typeparam name="R">The emitted type</typeparam>
        [MethodImpl(Inline)]
        public static FuncType<R> fk<R>(R r = default)
            => default;

        /// <summary>
        /// Reifies a unary function
        /// </summary>
        /// <param name="t1">An operand type representativev</param>
        /// <param name="r">An result type representative</param>
        /// <typeparam name="R">The result type</typeparam>
        [MethodImpl(Inline)]
        public static FuncType<T1,R> fk<T1,R>(T1 t1 = default, R r = default)
            => default;

        /// <summary>
        /// Reifies a binary function
        /// </summary>
        /// <param name="t1">An operand type representativev</param>
        /// <param name="t2">An operand type representativev</param>
        /// <param name="r">An result type representative</param>
        /// <typeparam name="R">The result type</typeparam>
        [MethodImpl(Inline)]
        public static FuncType<T1,T2,R> fk<T1,T2,R>(T1 t1 = default, T2 t2 = default, R r = default)
            => default;

        /// <summary>
        /// Reifies a ternary function
        /// </summary>
        /// <param name="t1">An operand type representativev</param>
        /// <param name="t2">An operand type representativev</param>
        /// <param name="t3">An operand type representativev</param>
        /// <param name="r">An result type representative</param>
        /// <typeparam name="R">The result type</typeparam>
        [MethodImpl(Inline)]
        public static FuncType<T1,T2,T3,R> fk<T1,T2,T3,R>(T1 t1 = default, T2 t2 = default, T3 t3 = default, R r = default)
            => default;

        /// <summary>
        /// Refifies a unary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static OperatorType<N1,T> op<T>(N1 n, T t = default)
            => default;

        /// <summary>
        /// Refifies a binary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static OperatorType<N2,T> op<T>(N2 n,  T t = default)
            => default;

        /// <summary>
        /// Refifies a ternary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static OperatorType<N3,T> op<T>(N3 n, T t = default)
            => default;

        [MethodImpl(Inline)]
        public static UnaryOpType op(N1 n)
            => default;

        [MethodImpl(Inline)]
        public static BinaryOpType op(N2 n)
            => default;

        [MethodImpl(Inline)]
        public static TernaryOpType op(N3 n)
            => default;

        [MethodImpl(Inline)]
        public static FunctionClass ofk<N>(N n = default)
            where N : unmanaged, ITypeNat
            => nateval<N>() switch {
                1 => FunctionClass.UnaryOp,
                2 => FunctionClass.BinaryOp,
                3 => FunctionClass.TernaryOp,
                _ => FunctionClass.None
            };         
    }
}