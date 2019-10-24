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
        /// Loads a 128-bit vector from a pointer and returns its bitwise complement
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 16 bytes of memory from which to load the first vector</param>
        /// <param name="pY">A pointer to at at least 16 bytes of memory to which the result of the computation is stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> not<T>(N128 n, T* pX)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            return vnot(vA);
        }

        /// <summary>
        /// Loads a 128-bit vector the first pointer and stores its bitwise complement to the second pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 16 bytes of memory from which to load the first vector</param>
        /// <param name="pY">A pointer to at at least 16 bytes of memory to which the result of the computation is stored</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void not<T>(N128 n, T* pX, T* pY)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vstore(vnot(vA), pY);
        }

        /// <summary>
        /// Loads a 256-bit vector from a pointer and returns its bitwise complement
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 32 bytes of memory from which to load the first vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> not<T>(N256 n, T* pA)
            where T : unmanaged
        {                    
            vloadu(pA, out Vector256<T> vA);
            return vnot(vA);
        }

        /// <summary>
        /// Loads a 256-bit vector the first pointer and stores its bitwise complement to the second pointer
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">A pointer to at at least 32 bytes of memory from which to load the first vector</param>
        /// <param name="pY">A pointer to at at least 32 bytes of memory from which to load the second vector</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void not<T>(N256 n, T* pA, T* pB)
            where T : unmanaged
        {                    
            vloadu(pA, out Vector256<T> vA);
            vstore(vnot(vA), pB);
        }


    }

}