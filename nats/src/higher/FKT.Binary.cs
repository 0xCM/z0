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
        /// Nonparametric classification of binary functions
        /// </summary>
        public readonly struct BinaryFuncType : IFuncType, IFuncArity<N2>
        {
            public const FunctionClass Kind = FunctionClass.Func2;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(BinaryFuncType src)
                =>  src.Class;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Parametric classification of binary function types, f:T1-> T2 -> R
        /// </summary>
        public readonly struct FuncType<T1,T2,R> : IFuncType<T1,T2,R>
        {
            public const FunctionClass Kind = FunctionClass.Func2;


            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(FuncType<T1,T2,R> src)
                =>  src.Class;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Nonparametric classification of binary operators
        /// </summary>
        public readonly struct BinaryOpType : IFuncArity<N2>
        {
            public const FunctionClass Kind = FunctionClass.BinaryOp;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N2>(BinaryOpType src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpType(OperatorType<N2> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(BinaryOpType src)
                => src.Classifier;

            public FunctionClass Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        /// <summary>
        /// Operand-parametric classification of binary operators
        /// </summary>
        /// <typeparam name="T">The operand type</typeparam>
        public readonly struct BinaryOpType<T> : IFuncType<N2,T>
        {
            public const FunctionClass Kind = FunctionClass.BinaryOp;

            public FunctionClass Class { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N2>(BinaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorType<N3,T>(BinaryOpType<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpType<T>(OperatorType<N3,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionClass(BinaryOpType<T> src)
                => src.Class;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T>(BinaryOpType<T> src)
                => default;
            

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpType(BinaryOpType<T> src)
                => default;
        }

    }
}