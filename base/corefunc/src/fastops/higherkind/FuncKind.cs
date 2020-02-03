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

        public readonly struct FuncKindType : IFuncKind
        {
            public const FunctionKind Kind = FunctionKind.None;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(FuncKindType src)
                =>  src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct FuncType<R> : IFuncKind<R>
        {
            public const FunctionKind Kind = FunctionKind.Func0;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(FuncType<R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(FuncType<R> src)
                =>  default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct FuncType<T1,R> : IFuncKind<T1,R>
        {
            public const FunctionKind Kind = FunctionKind.Func1;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(FuncType<T1,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(FuncType<T1,R> src)
                =>  default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct FuncType<T1,T2,R> : IFuncKind<T1,T2,R>
        {
            public const FunctionKind Kind = FunctionKind.Func2;


            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(FuncType<T1,T2,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(FuncType<T1,T2,R> src)
                =>  default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct FuncType<T1,T2,T3,R> : IFuncKind<T1,T2,T3,R>
        {
            public const FunctionKind Kind = FunctionKind.Func3;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(FuncType<T1,T2,T3,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(FuncType<T1,T2,T3,R> src)
                =>  default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryFunc : IFuncKind, IFuncArity<N1>
        {
            public const FunctionKind Kind = FunctionKind.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(UnaryFunc src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(UnaryFunc src)
                =>  default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryFunc : IFuncKind, IFuncArity<N2>
        {
            public const FunctionKind Kind = FunctionKind.BinaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(BinaryFunc src)
                =>  src.Classifier;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryFunc : IFuncKind, IFuncArity<N3>
        {
            public const FunctionKind Kind = FunctionKind.TernaryFunc;


            [MethodImpl(Inline)]
            public static implicit operator FunctionKind(TernaryFunc src)
                =>  src.Classifier;


            [MethodImpl(Inline)]
            public static implicit operator FuncKindType(TernaryFunc src)
                =>  default;

            public FunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

    }
}