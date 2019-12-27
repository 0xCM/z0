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
    using C = OpCaptures;
    
    public static class OpCapture
    {
        /// <summary>
        /// Captures a unary operator
        /// </summary>
        /// <param name="f">The unary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.UnaryOp<F,T> unary<F,T>(F f, T t = default)
            where F : IUnaryOp<T>
                => new C.UnaryOp<F,T>(f);

        /// <summary>
        /// Captures a binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.BinaryOp<F,T> binary<F,T>(F f, T t = default)
            where F : IBinaryOp<T>
                => new C.BinaryOp<F,T>(f);

        /// <summary>
        /// Captures a vectorized 128-bit binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.BinaryOp<F,Vector128<T>> vbinary<F,T>(N128 w, F f, T t = default)
            where F : IBinaryOp<Vector128<T>>
            where T : unmanaged
                => new C.BinaryOp<F,Vector128<T>>(f);

        /// <summary>
        /// Captures a vectorized 128-bit binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.BinaryOp<F,Vector256<T>> vbinary<F,T>(N256 w, F f, T t = default)
            where F : IBinaryOp<Vector256<T>>
            where T : unmanaged
                => new C.BinaryOp<F,Vector256<T>>(f);
    }
}