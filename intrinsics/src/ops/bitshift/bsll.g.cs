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
    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Applies a leftward shift over the full 128 vector bits at byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        /// <typeparam name="T">THe primal component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInts)]
        public static Vector128<T> vbsll<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vbsll(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbsll(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vbsll(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbsll(v64u(x), count));
            else
                throw unsupported<T>();
        }

        /// <summary>
        /// Applies a leftward shift to each 128-bit lane at byte-level resolution
        /// </summary>
        /// <param name="x">The source vector</param>
        /// <param name="count">The number of bytes to shift</param>
        /// <typeparam name="T">THe primal component type</typeparam>
        [MethodImpl(Inline), ZFunc(PrimalKind.UnsignedInts)]
        public static Vector256<T> vbsll<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vbsll(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vbsll(v16u(x), count));
            else if(typeof(T) == typeof(uint)) 
                return vgeneric<T>(dinx.vbsll(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return vgeneric<T>(dinx.vbsll(v64u(x), count));
            else
                throw unsupported<T>();
        }
    }
}