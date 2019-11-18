//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    
    
    using static zfunc;    
    using static aux;

    partial class ginx
    {        
        /// <summary>
        /// Creates a scalar vector from the lower 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vlo<T>(Vector128<T> src)
            where T : unmanaged
                =>  As.generic<T>(dinx.vmovelo(v64u(src)));

        /// <summary>
        /// Extracts the lo 128-bit lane of the source vector to scalar targets
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static void vlo<T>(Vector256<T> src, out ulong x0, out ulong x1)
            where T : unmanaged
                => dinx.vlo(v64u(src), out x0, out x1);

        /// <summary>
        /// Extracts the lo 128-bit lane of the source vector to a pair
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static ref Pair<ulong> vlo<T>(Vector256<T> src, ref Pair<ulong> dst)
            where T : unmanaged        
                => ref dinx.vlo(v64u(src), ref dst);

        /// <summary>
        /// Extracts the lo 128-bit lane of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vlo<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vlo_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vlo_i(src);
            else 
                return vlo_f(src);
        }
    }
}