//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;
    using static zfunc;

    partial class HK
    {
        /// <summary>
        /// Refifies a unary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static OperatorFunc<N1,T> opfk<T>(N1 n, T t = default)
            => default;

        /// <summary>
        /// Refifies a binary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static OperatorFunc<N2,T> opfk<T>(N2 n,  T t = default)
            => default;

        /// <summary>
        /// Refifies a ternary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static OperatorFunc<N3,T> opfk<T>(N3 n, T t = default)
            => default;

        [MethodImpl(Inline)]
        public static UnaryOpFunc opfk(N1 n)
            => default;

        [MethodImpl(Inline)]
        public static BinaryOpFunc opfk(N2 n)
            => default;

        [MethodImpl(Inline)]
        public static TernaryOpFunc opfk(N3 n)
            => default;

        public readonly struct OperatorFunc<Arity> : IOperatorFuncKind<Arity>
            where Arity : unmanaged, ITypeNat
        {
            public static FunctionKind Kind => OpFunctionKind<Arity>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(OperatorFunc<Arity> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(OperatorFunc<Arity> src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct OperatorFunc<Arity,T> : IOperatorFuncKind<Arity,T>
            where Arity : unmanaged, ITypeNat

        {
            public static FunctionKind Kind => OpFunctionKind<Arity>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(OperatorFunc<Arity,T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(OperatorFunc<Arity,T> src)
                => default;


            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(OperatorFunc<Arity,T> src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOpFunc : IOperatorFuncKind<N1>
        {
            public const FunctionKind Kind = FunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(UnaryOpFunc src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N1>(UnaryOpFunc src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpFunc(OperatorFunc<N1> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(UnaryOpFunc src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOpFunc<T> : IFuncKind<N1,T>
        {
            public const FunctionKind Kind = FunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N1>(UnaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N1,T>(UnaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpFunc<T>(OperatorFunc<N1,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(UnaryOpFunc<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(UnaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOpFunc(UnaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(UnaryOpFunc<T> src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOpFunc : IFuncArity<N2>
        {
            public const FunctionKind Kind = FunctionKind.BinaryOp;

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N2>(BinaryOpFunc src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpFunc(OperatorFunc<N2> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(BinaryOpFunc src)
                => src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOpFunc<T> : IFuncKind<N2,T>
        {
            public const FunctionKind Kind = FunctionKind.BinaryOp;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N2>(BinaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N3,T>(BinaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpFunc<T>(OperatorFunc<N3,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(BinaryOpFunc<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T>(BinaryOpFunc<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(BinaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOpFunc(BinaryOpFunc<T> src)
                => default;
        }

        public readonly struct TernaryOpFunc : IOperatorFuncKind<N3>
        {
            public const FunctionKind Kind = FunctionKind.TernaryOp;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N3>(TernaryOpFunc src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpFunc(OperatorFunc<N3> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(TernaryOpFunc src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(TernaryOpFunc src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFunc(TernaryOpFunc src)
                => default;
        }

        public readonly struct TernaryOpFunc<T> : IOperatorFuncKind<N3,T>
        {
            public const FunctionKind Kind = FunctionKind.TernaryOp;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(TernaryOpFunc<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(TernaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T,T>(TernaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFunc(TernaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N3>(TernaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator OperatorFunc<N3,T>(TernaryOpFunc<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOpFunc<T>(OperatorFunc<N3,T> src)
                => default;
        }

        static FunctionKind OpFunctionKind<N>(N n = default)
            where N : unmanaged, ITypeNat
            => nateval<N>() switch {
                1 => FunctionKind.UnaryOp,
                2 => FunctionKind.BinaryOp,
                3 => FunctionKind.TernaryOp,
                _ => FunctionKind.None
            };
    }
}