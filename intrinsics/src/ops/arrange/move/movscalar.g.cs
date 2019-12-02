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
    
    using static zfunc;    
    using static As;
    
    partial class ginx
    {
        /// <summary>
        /// Loads a scalar into the first component of a 128-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector128<T> vmovscalar<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vmovscalar_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vmovscalar_i(n, src);
            else 
                return vmovscalar_f(n, src);
        }

        /// <summary>
        /// Loads a scalar into the first component of a 256-bit vector
        /// </summary>
        /// <param name="a">The scalar to load</param>
        [MethodImpl(Inline)]
        public static Vector256<T> vmovscalar<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vmovscalar_u(n, src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vmovscalar_i(n, src);
            else 
                return vmovscalar_f(n, src);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmovscalar_i<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return As.vgeneric<T>(dinx.vmovscalar(n, int8(src)));
            else if(typeof(T) == typeof(short))
                return As.vgeneric<T>(dinx.vmovscalar(n, int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vmovscalar(n,int32(src)));
            else
                return vgeneric<T>(dinx.vmovscalar(n,int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmovscalar_u<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return As.vgeneric<T>(dinx.vmovscalar(n, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.movscalar(n,uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vmovscalar(n,uint32(src)));
            else 
                return vgeneric<T>(dinx.vmovscalar(n,uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vmovscalar_f<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vmovscalar(n,float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vmovscalar(n,float64(src)));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmovscalar_i<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return vgeneric<T>(dinx.vmovscalar(n,int8(src)));
            else if(typeof(T) == typeof(short))
                return vgeneric<T>(dinx.vmovscalar(n,int16(src)));
            else if(typeof(T) == typeof(int))
                return vgeneric<T>(dinx.vmovscalar(n,int32(src)));
            else
                return vgeneric<T>(dinx.vmovscalar(n,int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmovscalar_u<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return vgeneric<T>(dinx.vmovscalar(n,uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return vgeneric<T>(dinx.vmovscalar(n,uint16(src)));
            else if(typeof(T) == typeof(uint))
                return vgeneric<T>(dinx.vmovscalar(n,uint32(src)));
            else 
                return vgeneric<T>(dinx.vmovscalar(n,uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vmovscalar_f<T>(N256 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return vgeneric<T>(dinx.vmovscalar(n,float32(src)));
            else if(typeof(T) == typeof(double))
                return vgeneric<T>(dinx.vmovscalar(n,float64(src)));
            else 
                throw unsupported<T>();
        }
    }
}