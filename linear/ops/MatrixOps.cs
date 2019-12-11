//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static zfunc;

    partial class Linear
    {        
        /// <summary>
        /// Computes the sum of two matrices and stores the result in a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,T> add<M,N,T>(MBlock256<M,N,T> A, MBlock256<M,N,T> B, ref MBlock256<M,N,T> C)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            ginx.vadd(A.Unsized, B.Unsized, C.Unsized);
            return ref C;
        }

        /// <summary>
        /// Computes the difference of two matrices and stores the result in a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,T> sub<M,N,T>(MBlock256<M,N,T> A, MBlock256<M,N,T> B, ref MBlock256<M,N,T> C)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            ginx.vsub(A.Unsized, B.Unsized, C.Unsized);
            return ref C;
        }

        /// <summary>
        /// Computes the bitwise AND of corresponding matrix entries and stores the result in a caller-supplied target matrix
        /// </summary>
        /// <param name="A">The left matrix</param>
        /// <param name="B">The right matrix</param>
        /// <param name="C">The target matrix</param>
        /// <typeparam name="M">The natural row count type</typeparam>
        /// <typeparam name="N">The natural column count type</typeparam>
        /// <typeparam name="T">The element type</typeparam>
        [MethodImpl(Inline)]
        public static ref MBlock256<M,N,T> and<M,N,T>(MBlock256<M,N,T> A, MBlock256<M,N,T> B, ref MBlock256<M,N,T> C)
            where M : unmanaged, ITypeNat
            where N : unmanaged, ITypeNat
            where T : unmanaged    
        {
            and(A.Unsized,B.Unsized, C.Unsized);
            return ref C;
        }
    }
}