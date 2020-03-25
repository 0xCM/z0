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
    partial class FKT
    {
        /// <summary>
        /// Nonparametric classification of unary functions
        /// </summary>
        public readonly struct UnaryFuncType : IFuncType
        {
            public const FunctionClass Kind = FunctionClass.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(UnaryFuncType src)
                =>  src.Class;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Parametric classification of unary function types, f:T1-> R
        /// </summary>
        public readonly struct FuncType<T1,R> : IFuncType<T1,R>
        {
            public const FunctionClass Kind = FunctionClass.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<T1,R> src)
                =>  src.Class;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Nonparametric classification of unary operators
        /// </summary>
        public readonly struct UnaryOpType : IOperatorFuncType<N1>
        {
            public const FunctionClass Kind = FunctionClass.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(UnaryOpType src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N1>(UnaryOpType src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpType(OperatorType<N1> src)
                => default;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }


        /// <summary>
        /// Operand-parametric classification of unary operators
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public readonly struct UnaryOpType<T> : IFuncType<N1,T>
        {
            public const FunctionClass Kind = FunctionClass.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N1>(UnaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N1,T>(UnaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpType<T>(OperatorType<N1,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(UnaryOpType<T> src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(UnaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpType(UnaryOpType<T> src)
                => default;
            
            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }
    }
}