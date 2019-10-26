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
        /// Loads a vector from a pointer and applies a right shift, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vsrl<T>(N128 n, T* pX, byte offset)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            return vsrl(vA,offset);
        }

        /// <summary>
        /// Loads a vector from a pointer and applies a right shift, storing the result to a target pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <param name="pDst">A pointer to which the computation will be stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vsrl<T>(N128 n, T* pX, byte offset, T* pDst)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vstore(vsrl(vA,offset), pDst);
        }

        /// <summary>
        /// Loads a vector from a pointer and applies a right shift, returning the result to the caller
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vsrl<T>(N256 n, T* pX, byte offset)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            return vsrl(vA,offset);
        }

        /// <summary>
        /// Loads a vector from a pointer and applies a right shift, storing the result to a target pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer from which the source vector will be read</param>
        /// <param name="pDst">A pointer to which the computation will be stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vsrl<T>(N256 n, T* pX, byte offset, T* pDst)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vstore(vsrl(vA,offset), pDst);
        }
    }
}