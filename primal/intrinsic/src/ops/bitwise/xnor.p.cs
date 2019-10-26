//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;
    using System.Runtime.Intrinsics.X86;
    
    using static As;
    using static zfunc;

    partial class ginx
    {

        /// <summary>
        /// Loads two vectors from respective pointers computes the XNOR between them, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the first vector will be read</param>
        /// <param name="pY">A pointer from which the second vector will be read</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vxnor<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            return vxnor(vA,vB);
        }

        /// <summary>
        /// Loads two vectors from respective pointers computes the XNOR between them, storing the result to a target pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the first vector will be read</param>
        /// <param name="pY">A pointer from which the second vector will be read</param>
        /// <param name="pDst">A pointer to which the computation will be stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vxnor<T>(N128 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            vstore(vxnor(vA,vB), pDst);
        }

        /// <summary>
        /// Loads two vectors from respective pointers computes the XNOR between them, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the first vector will be read</param>
        /// <param name="pY">A pointer from which the second vector will be read</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vxnor<T>(N256 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vloadu(pY, out Vector256<T> vB);
            return vxnor(vA,vB);
        }

        /// <summary>
        /// Loads two vectors from respective pointers computes the XNOR between them, storing the result to a target pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the first vector will be read</param>
        /// <param name="pY">A pointer from which the second vector will be read</param>
        /// <param name="pDst">A pointer to which the computation will be stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vxnor<T>(N256 n, T* pX, T* pY, T* pDst)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vloadu(pY, out Vector256<T> vB);
            vstore(vxnor(vA,vB), pDst);
        }
    }

}