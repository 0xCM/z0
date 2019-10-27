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
        /// Loads a source vector from a pointer and returns true if all bits are on, and false otherwise
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to the data for the source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool vtestc<T>(N128 n, T* pX)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            return vtestc(vA);
        }

        /// <summary>
        /// Loads a source vector and mask from respective pointers and computes the testc metric, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to the data for the first vector</param>
        /// <param name="pY">A pointer to the data for the first vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool vtestc<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            return vtestc(vA,vB);
        }

        /// <summary>
        /// Loads a source vector from a pointer and returns true if all bits are on, and false otherwise
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to the data for the source vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool vtestc<T>(N256 n, T* pX)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            return vtestc(vA);
        }

        /// <summary>
        /// Loads a source vector and mask from respective pointers and computes the testc metric, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to the data for the first vector</param>
        /// <param name="pY">A pointer to the data for the first vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe bool vtestc<T>(N256 n, T* pA, T* pB)
            where T : unmanaged
        {                    
            vloadu(pA, out Vector256<T> vA);
            vloadu(pB, out Vector256<T> vB);
            return vtestc(vA,vB);
        }
    }

}