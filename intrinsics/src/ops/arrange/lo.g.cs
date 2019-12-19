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
    using static As;

    partial class ginx
    {        
        /// <summary>
        /// Creates a scalar vector from the lower 64 bits of the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vlo<T>(Vector128<T> src)
            where T : unmanaged
                =>  vgeneric<T>(vzerohi(v64u(src)));

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
        /// Extracts the lower 256-bits from the source vector
        /// </summary>
        /// <param name="src">The source vector</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vlo<T>(Vector512<T> src)
            where T : unmanaged
                => src.Lo;       

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

        [MethodImpl(Inline)]
        public static Vector128<T> vlo_i<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vlo(vcast8i(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vlo(vcast16i(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vlo(vcast32i(src)));
            else
                return vgeneric<T>(dinx.vlo(vcast64i(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vlo_u<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vlo(vcast8u(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vlo(vcast16u(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vlo(vcast32u(src)));
            else 
                return vgeneric<T>(dinx.vlo(vcast64u(src)));
        }

        [MethodImpl(Inline)]
        public static Vector128<T> vlo_f<T>(Vector256<T> src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(fpinx.vlo(vcast32f(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(fpinx.vlo(vcast64f(src)));
            else 
                throw unsupported<T>();
        }
    }
}