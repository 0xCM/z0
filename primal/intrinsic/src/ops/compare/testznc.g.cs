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
        [MethodImpl(Inline)]
        public static bool vtestznc<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return testznc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return testznc_i(src,mask);
            else 
                return testznc_f(src,mask);
        }

        [MethodImpl(Inline)]
        public static bool vtestznc<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return testznc_u(src,mask);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return testznc_i(src,mask);
            else 
                return testznc_f(src,mask);
        }

        [MethodImpl(Inline)]
        static bool testznc_i<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestznc(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestznc(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestznc(int32(src), int32(mask));
            else 
                return dinx.vtestznc(int64(src), int64(mask));
        }

        [MethodImpl(Inline)]
        static bool testznc_u<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestznc(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestznc(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestznc(uint32(src), uint32(mask));
            else 
                return dinx.vtestznc(uint64(src), uint64(mask));
        }

        [MethodImpl(Inline)]
        static bool testznc_f<T>(Vector128<T> src, Vector128<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinx.vtestznc(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dinx.vtestznc(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static bool testznc_i<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return dinx.vtestznc(int8(src), int8(mask));
            else if(typeof(T) == typeof(short))
                return dinx.vtestznc(int16(src), int16(mask));
            else if(typeof(T) == typeof(int))
                return dinx.vtestznc(int32(src), int32(mask));
            else 
                return dinx.vtestznc(int64(src), int64(mask));
        }

        [MethodImpl(Inline)]
        static bool testznc_u<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return dinx.vtestznc(uint8(src), uint8(mask));
            else if(typeof(T) == typeof(ushort))
                return dinx.vtestznc(uint16(src), uint16(mask));
            else if(typeof(T) == typeof(uint))
                return dinx.vtestznc(uint32(src), uint32(mask));
            else 
                return dinx.vtestznc(uint64(src), uint64(mask));
        }

        [MethodImpl(Inline)]
        static bool testznc_f<T>(Vector256<T> src, Vector256<T> mask)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return dinx.vtestznc(float32(src), float32(mask));
            else if(typeof(T) == typeof(double))
                return dinx.vtestznc(float64(src), float64(mask));
            else 
                throw unsupported<T>();
        }
    }
}