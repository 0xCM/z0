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
        /// Loads a vector from a pointer and computes the bitwise complement, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vnot<T>(N128 n, T* pX)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            return vnot(vA);
        }

        /// <summary>
        /// Loads a vector from a pointer and computes the bitwise complement, storing the result to a pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <param name="pDst">A pointer to which the result of the computation will be written</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vnot<T>(N128 n, T* pX, T* pDst)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vstore(vnot(vA), pDst);
        }

        /// <summary>
        /// Loads a vector from a pointer and computes the bitwise complement, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vnot<T>(N256 n, T* pX)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            return vnot(vA);
        }

        /// <summary>
        /// Loads a vector from a pointer and computes the bitwise complement, storing the result to a pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <param name="pDst">A pointer to which the result of the computation will be written</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vnot<T>(N256 n, T* pX, T* pDst)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vstore(vnot(vA), pDst);
        }
    }

}