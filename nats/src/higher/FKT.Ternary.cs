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
        /// Nonparametric classification of ternary functions
        /// </summary>
        public readonly struct TernaryFuncType : IFuncType
        {
            public const FunctionClass Kind = FunctionClass.TernaryFunc;


            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(TernaryFuncType src)
                =>  src.Class;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Parametric classification of ternary function types, f:T1-> T2 -> T3 -> R
        /// </summary>
        public readonly struct FuncType<T1,T2,T3,R> : IFuncType<T1,T2,T3,R>
        {
            public const FunctionClass Kind = FunctionClass.TernaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<T1,T2,T3,R> src)
                =>  src.Class;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Nonparametric classification of ternary operators
        /// </summary>
        public readonly struct TernaryOpType : IOperatorFuncType<N3>
        {
            public const FunctionClass Kind = FunctionClass.TernaryOp;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3>(TernaryOpType src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpType(OperatorType<N3> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(TernaryOpType src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFuncType(TernaryOpType src)
                => default;
        }

        /// <summary>
        /// Operand-parametric classification of ternary operators
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public readonly struct TernaryOpType<T> : IOperatorFuncType<N3,T>
        {
            public const FunctionClass Kind = FunctionClass.TernaryOp;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(TernaryOpType<T> src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T,T>(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFuncType(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3>(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3,T>(TernaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpType<T>(OperatorType<N3,T> src)
                => default;
        }        
    }
}