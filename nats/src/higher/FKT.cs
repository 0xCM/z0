//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    /// <summary>
    /// Function-kinded types
    /// </summary>
    public static partial class FKT
    {
        /// <summary>
        /// Parametric classification of emmission functions, f:-> R
        /// </summary>
        public readonly struct FuncType<R> : IFuncType<R>
        {
            public const FunctionClass Kind = FunctionClass.Func0;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<R> src)
                =>  src.Classifier;


            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Operator classification predicated on parametric arity
        /// </summary>
        /// <typeparam name="N">The arity type</typeparam>
        public readonly struct OperatorType<N> : IOperatorFuncType<N>
            where N : unmanaged, ITypeNat
        {
            public static FunctionClass Kind => FK.ofk<N>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(OperatorType<N> src)
                => src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Operator classification predicated on parametric arity and operand type
        /// </summary>
        /// <typeparam name="N">The arity type</typeparam>
        /// <typeparam name="T">The operand type</typeparam>
        public readonly struct OperatorType<N,T> : IOperatorFuncType<N,T>
            where N : unmanaged, ITypeNat
        {
            public static FunctionClass Kind => FK.ofk<N>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(OperatorType<N,T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(OperatorType<N,T> src)
                => default;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

    }
}