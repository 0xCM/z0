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


        public readonly struct Operator<N> : IHKFunc<Operator<N>>
            where N : unmanaged, ITypeNat
        {
            public static HKFunctionKind Kind => OpFunctionKind<N>();

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Operator<N> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(Operator<N> src)
                => default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct Operator<N,T> : IHKFunc<Operator<N,T>,N>
            where N : unmanaged, ITypeNat

        {
            public static HKFunctionKind Kind => OpFunctionKind<N>();

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(Operator<N,T> src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType<T,T>(Operator<N,T> src)
                => default;


            [MethodImpl(Inline)]
            public static implicit operator FuncType(Operator<N,T> src)
                => default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOp : IHKFunc<UnaryOp,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryOp;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(UnaryOp src)
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

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryOp<T> : IHKFunc<UnaryOp<T>,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryOp;

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
            public static implicit operator HKFunctionKind(UnaryOp<T> src)
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

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp : IHKFunc<BinaryOp,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryOp;

            [MethodImpl(Inline)]
            public static implicit operator Operator<N2>(BinaryOp src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator BinaryOp(Operator<N2> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(BinaryOp src)
                => src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryOp<T> : IHKFunc<BinaryOp<T>,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryOp;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

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
            public static implicit operator HKFunctionKind(BinaryOp<T> src)
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

        public readonly struct TernaryOp : IHKFunc<TernaryOp>
        {
            public const HKFunctionKind Kind = HKFunctionKind.TernaryOp;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator Operator<N3>(TernaryOp src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryOp(Operator<N3> src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(TernaryOp src)
                => src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(TernaryOp src)
                => default;

            [MethodImpl(Inline)]
            public static implicit operator TernaryFunc(TernaryOp src)
                => default;

        }

        public readonly struct TernaryOp<T> : IHKFunc<TernaryOp>
        {
            public const HKFunctionKind Kind = HKFunctionKind.TernaryOp;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(TernaryOp<T> src)
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

        static HKFunctionKind OpFunctionKind<N>(N n = default)
            where N : unmanaged, ITypeNat
            => n.NatValue switch {
                1 => HKFunctionKind.UnaryOp,
                2 => HKFunctionKind.BinaryOp,
                3 => HKFunctionKind.TernaryOp,
                _ => HKFunctionKind.None
            };

    }
}