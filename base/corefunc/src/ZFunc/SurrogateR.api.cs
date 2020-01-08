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
    using C = OpReps;
    
    /// <summary>
    /// Defines api surface for creating surrogate operator (R)epresentations
    /// </summary>
    public static class SurrogateR
    {
        /// <summary>
        /// Captures a unary operator
        /// </summary>
        /// <param name="f">The unary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.UnaryRep<F,T> unary<F,T>(F f, T t = default)
            where F : IUnaryOp<T>
                => new C.UnaryRep<F,T>(f);

        /// <summary>
        /// Captures a binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.BinaryRep<F,T> binary<F,T>(F f, T t = default)
            where F : IBinaryOp<T>
                => new C.BinaryRep<F,T>(f);

        /// <summary>
        /// Captures a vectorized 128-bit binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.BinaryRep<F,Vector128<T>> vbinary<F,T>(N128 w, F f, T t = default)
            where F : IBinaryOp<Vector128<T>>
            where T : unmanaged
                => new C.BinaryRep<F,Vector128<T>>(f);

        /// <summary>
        /// Captures a vectorized 128-bit binary operator
        /// </summary>
        /// <param name="f">The binary operator</param>
        /// <param name="t">A respresentative point in the operator domain</param>
        /// <typeparam name="F">The operator type</typeparam>
        /// <typeparam name="T">The operator domain type</typeparam>
        [MethodImpl(Inline)]
        public static C.BinaryRep<F,Vector256<T>> vbinary<F,T>(N256 w, F f, T t = default)
            where F : IBinaryOp<Vector256<T>>
            where T : unmanaged
                => new C.BinaryRep<F,Vector256<T>>(f);
    }
}