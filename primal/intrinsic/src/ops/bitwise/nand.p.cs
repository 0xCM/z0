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
        /// Loads two 128-bit vectors from supplied pointers and returns the bitwise NAND between them
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 16 bytes of memory from which to load the first vector</param>
        /// <param name="pY">A pointer to at at least 16 bytes of memory from which to load the second vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vnand<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            return vnand(vA,vB);
        }

        /// <summary>
        /// Loads two 128-bit vectors from the first two pointers and stores the result of computing their bitwise NAND to the third pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 16 bytes of memory from which to load the first vector</param>
        /// <param name="pY">A pointer to at at least 16 bytes of memory from which to load the second vector</param>
        /// <param name="pZ">A pointer to at at least 16 bytes of memory to which the computation result is stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vnand<T>(N128 n, T* pX, T* pY, T* pZ)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vloadu(pY, out Vector128<T> vB);
            vstore(vnand(vA,vB), pZ);
        }

        /// <summary>
        /// Loads two 256-bit vectors from supplied pointers and returns the bitwise NAND between them
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 32 bytes of memory from which to load the first vector</param>
        /// <param name="pY">A pointer to at at least 32 bytes of memory from which to load the second vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vnand<T>(N256 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vloadu(pY, out Vector256<T> vB);
            return vnand(vA,vB);
        }

        /// <summary>
        /// Loads two 256-bit vectors from the first two pointers and stores the result of computing their bitwise NAND to the third pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 32 bytes of memory from which to load the first vector</param>
        /// <param name="pY">A pointer to at at least 32 bytes of memory from which to load the second vector</param>
        /// <param name="pZ">A pointer to at at least 32 bytes of memory to which the computation result is stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vnand<T>(N256 n, T* pX, T* pY, T* pZ)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vloadu(pY, out Vector256<T> vB);
            vstore(vnand(vA,vB), pZ);
        }


    }

}