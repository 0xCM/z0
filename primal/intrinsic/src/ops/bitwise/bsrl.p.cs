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
        /// Shifts a pointer-identified vector by a specified number of bytes leftward
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">Pointer-identified memory from which the vector will be read</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector128<T> vbsrl<T>(N128 n, T* pX, byte count)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            return vbsrl(vA,count);
        }

        /// <summary>
        /// Shifts a pointer-identified vector by a specified number of bytes leftward and stores the result to pointer-identified memory
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">Pointer-identified memory from which the vector will be read</param>
        /// <param name="pDst">Pointer-identified memory to which the result will be written</param>
        /// <param name="count">The shift amount in bytes</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vbsrl<T>(N128 n, T* pX, T* pDst, byte count)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector128<T> vA);
            vstore(vbsrl(vA,count), pDst);
        }

        /// <summary>
        /// Shifts a pointer-identified vector by a specified number of bytes leftward
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">Pointer-identified memory from which the vector will be read</param>
        /// <param name="count">The shift amount in bytes</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe Vector256<T> vbsrl<T>(N256 n, T* pX, byte count)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            return vbsrl(vA,count);
        }

        /// <summary>
        /// Shifts a pointer-identified vector by a specified number of bytes leftward and stores the result to pointer-identified memory
        /// </summary>
        /// <param name="n">The bitness selector</param>
        /// <param name="pX">Pointer-identified memory from which the vector will be read</param>
        /// <param name="pDst">Pointer-identified memory to which the result will be stored</param>
        /// <param name="count">The shift amount in bytes</param>
        /// <typeparam name="T">The primal component type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void vbsrl<T>(N256 n, T* pX, T* pDst, byte count)
            where T : unmanaged
        {                    
            vloadu(pX, out Vector256<T> vA);
            vstore(vbsrl(vA,count), pDst);
        }

    }

}