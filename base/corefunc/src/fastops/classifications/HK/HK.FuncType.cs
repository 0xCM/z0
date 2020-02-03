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

        public readonly struct FuncType : IHKFunc<FuncType>
        {
            public const HKFunctionKind Kind = HKFunctionKind.None;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(FuncType src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct FuncType<R> : IHKFunc<FuncType<R>,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func0;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(FuncType<R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(FuncType<R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct FuncType<T1,R> : IHKFunc<FuncType<T1,R>,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func1;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(FuncType<T1,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(FuncType<T1,R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct FuncType<T1,T2,R> : IHKFunc<FuncType<T1,T2,R>,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func2;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(FuncType<T1,T2,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(FuncType<T1,T2,R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}

        }

        public readonly struct FuncType<T1,T2,T3,R> : IHKFunc<FuncType<T1,T2,T3,R>,N3>
        {
            public const HKFunctionKind Kind = HKFunctionKind.Func3;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(FuncType<T1,T2,T3,R> src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(FuncType<T1,T2,T3,R> src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct UnaryFunc : IHKFunc<UnaryFunc,N1>
        {
            public const HKFunctionKind Kind = HKFunctionKind.UnaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(UnaryFunc src)
                =>  src.Classifier;

            [MethodImpl(Inline)]
            public static implicit operator FuncType(UnaryFunc src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct BinaryFunc : IHKFunc<BinaryFunc,N2>
        {
            public const HKFunctionKind Kind = HKFunctionKind.BinaryFunc;

            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(BinaryFunc src)
                =>  src.Classifier;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

        public readonly struct TernaryFunc : IHKFunc<TernaryFunc>
        {
            public const HKFunctionKind Kind = HKFunctionKind.TernaryFunc;


            [MethodImpl(Inline)]
            public static implicit operator HKFunctionKind(TernaryFunc src)
                =>  src.Classifier;


            [MethodImpl(Inline)]
            public static implicit operator FuncType(TernaryFunc src)
                =>  default;

            public HKFunctionKind Classifier { [MethodImpl(Inline)] get=> Kind;}
        }

    }
}