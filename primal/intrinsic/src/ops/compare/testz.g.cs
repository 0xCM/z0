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
        /// Determines whether all mask-identified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bit vtestz<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestz_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestz_i(src,mask);
            else 
                return vtestz_f<T>(src,mask);
         }

        /// <summary>
        /// Determines whether all mask-identified source bits are off
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="mask">The mask</param>
        [MethodImpl(Inline)]
        public static bit vtestz<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vtestz_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vtestz_i(src,mask);
            else 
                return vtestz_f<T>(src,mask);
       }

        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestz(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestz(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestz(uint32(src), uint32(mask));
            else
                return dinx.vtestz(uint64(src), uint64(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestz(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestz(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestz(int32(src), int32(mask));
            else
                return dinx.vtestz(int64(src), int64(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.vtestz(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.vtestz(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bit vtestz_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestz(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestz(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestz(uint32(src), uint32(mask));
            else
                return dinx.vtestz(uint64(src), uint64(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestz(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestz(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestz(int32(src), int32(mask));
            else
                return dinx.vtestz(int64(src), int64(mask));
        }

        [MethodImpl(Inline)]
        static bit vtestz_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dfp.vtestz(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dfp.vtestz(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

    }
}