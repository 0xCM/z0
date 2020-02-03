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
        public static Operator<N1,T> opk<T>(N1 n, T t = default)
            => default;

        /// <summary>
        /// Refifies a binary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static Operator<N2,T> opk<T>(N2 n,  T t = default)
            => default;

        /// <summary>
        /// Refifies a ternary op kind
        /// </summary>
        /// <param name="n">The arity selector</param>
        /// <param name="t">A parametric selector</param>
        /// <typeparam name="T">Any type that distinguishes the kind in a given context</typeparam>
        [MethodImpl(Inline)]
        public static Operator<N3,T> opk<T>(N3 n, T t = default)
            => default;


        [MethodImpl(Inline)]
        public static UnaryOp opk(N1 n)
            => default;

        [MethodImpl(Inline)]
        public static BinaryOp opk(N2 n)
            => default;

        [MethodImpl(Inline)]
        public static TernaryOp opk(N3 n)
            => default;


        public readonly struct Operator<N> : IFuncKind<Operator<N>>
            where N : unmanaged, ITypeNat
        {
            public static FunctionKind Kind => OpFunctionKind<N>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(Operator<N> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(Operator<N> src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct Operator<N,T> : IFuncKind<Operator<N,T>,N>
            where N : unmanaged, ITypeNat

        {
            public static FunctionKind Kind => OpFunctionKind<N>();

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(Operator<N,T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(Operator<N,T> src)
                => default;


            [MethodImpl(Inline)]
            public static implicit operator FuncType(Operator<N,T> src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOp : IFuncKind<UnaryOp,N1>
        {
            public const FunctionKind Kind = FunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(UnaryOp src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N1>(UnaryOp src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOp(Operator<N1> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(UnaryOp src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOp<T> : IFuncKind<UnaryOp<T>,N1>
        {
            public const FunctionKind Kind = FunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N1>(UnaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N1,T>(UnaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOp<T>(Operator<N1,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(UnaryOp<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(UnaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator UnaryOp(UnaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(UnaryOp<T> src)
                => default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp : IFuncKind<BinaryOp,N2>
        {
            public const FunctionKind Kind = FunctionKind.BinaryOp;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N2>(BinaryOp src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(Operator<N2> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(BinaryOp src)
                => src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp<T> : IFuncKind<BinaryOp<T>,N2>
        {
            public const FunctionKind Kind = FunctionKind.BinaryOp;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator Operator<N2>(BinaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N3,T>(BinaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOp<T>(Operator<N3,T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(BinaryOp<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T>(BinaryOp<T> src)
                => default;
            
            [MethodImpl(Inline)]
            public static implicit operator FuncType(BinaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(BinaryOp<T> src)
                => default;
        }

        public readonly struct TernaryOp : IFuncKind<TernaryOp>
        {
            public const FunctionKind Kind = FunctionKind.TernaryOp;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator Operator<N3>(TernaryOp src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOp(Operator<N3> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(TernaryOp src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(TernaryOp src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFunc(TernaryOp src)
                => default;

        }

        public readonly struct TernaryOp<T> : IFuncKind<TernaryOp>
        {
            public const FunctionKind Kind = FunctionKind.TernaryOp;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(TernaryOp<T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(TernaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T,T,T>(TernaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFunc(TernaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N3>(TernaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N3,T>(TernaryOp<T> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOp<T>(Operator<N3,T> src)
                => default;

        }

        static FunctionKind OpFunctionKind<N>(N n = default)
            where N : unmanaged, ITypeNat
            => n.NatValue switch {
                1 => FunctionKind.UnaryOp,
                2 => FunctionKind.BinaryOp,
                3 => FunctionKind.TernaryOp,
                _ => FunctionKind.None
            };

    }
}