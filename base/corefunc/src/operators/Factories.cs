//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    using R = ZOpR;

    partial class ZOps
    {
        /// <summary>
        /// Captures a unary operator
        /// </summary>
        /// <param name="f">The unary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static R.UnaryOp<F,T> unary<F,T>(F f, T t = default)
            where F : IUnaryOp<T>
                => new R.UnaryOp<F,T>(f);

        /// <summary>
        /// Captures a binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static R.BinaryOp<F,T> binary<F,T>(F f, T t = default)
            where F : IBinaryOp<T>
                => new R.BinaryOp<F,T>(f);

        /// <summary>
        /// Captures a vectorized 128-bit binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static R.BinaryOp<F,Vector128<T>> vbinary<F,T>(N128 w, F f, T t = default)
            where F : IBinaryOp<Vector128<T>>
            where T : unmanaged
                => new R.BinaryOp<F,Vector128<T>>(f);

        /// <summary>
        /// Captures a vectorized 128-bit binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static R.BinaryOp<F,Vector256<T>> vbinary<F,T>(N256 w, F f, T t = default)
            where F : IBinaryOp<Vector256<T>>
            where T : unmanaged
                => new R.BinaryOp<F,Vector256<T>>(f);

        /// <summary>
        /// Captures a delegate and presents it as a unary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static R.UnaryDelegate<T> unary<T>(Func<T,T> f, string name, T t = default)
            => new R.UnaryDelegate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a binary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static R.BinaryDelegate<T> binary<T>(Func<T,T,T> f, string name, T t = default)
            => new R.BinaryDelegate<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a ternary operator
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain/codomain type</typeparam>
        [MethodImpl(Inline)]
        public static R.TernaryOp<T> ternary<T>(Func<T,T,T,T> f, string name, T t = default)
            => new R.TernaryOp<T>(f,name);

        /// <summary>
        /// Captures a delegate and presents it as a unary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static R.UnaryPred<T> predicate<T>(Func<T,bit> f, string name, T t = default)
            => new R.UnaryPred<T>(f,name);
            
        /// <summary>
        /// Captures a delegate and presents it as a binary predicate
        /// </summary>
        /// <param name="f">The delegate to capture</param>
        /// <param name="name">The operator name</param>
        /// <param name="t">A point representative</param>
        /// <typeparam name="T">The delegate domain type</typeparam>
        [MethodImpl(Inline)]
        public static R.BinaryPred<T> predicate<T>(Func<T,T,bit> f, string name, T t = default)
            => new R.BinaryPred<T>(f,name);

    }
}