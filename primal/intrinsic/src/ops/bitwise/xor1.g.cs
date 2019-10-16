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
        [MethodImpl(Inline)]
        public static Vector128<T> vxor1<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vxor1_128u(x);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vxor1_128i(x);
            else 
                return vxor1_128f(x);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vxor1<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vxor1_256u(x);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vxor1_256i(x);
            else 
                return vxor1_256f(x);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxor1_128u<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxor1(uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxor1(uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vxor1(uint32(x)));
            else
                return generic<T>(dinx.vxor1(uint64(x)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxor1_128i<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vxor1(int8(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vxor1(int16(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vxor1(int32(x)));
            else
                return generic<T>(dinx.vxor1(int64(x)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vxor1_128f<T>(Vector128<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxor1(float32(x)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxor1(float64(x)));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vector256<T> vxor1_256u<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vxor1(uint8(x)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vxor1(uint16(x)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vxor1(uint32(x)));
            else
                return generic<T>(dinx.vxor1(uint64(x)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxor1_256i<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vxor1(int8(x)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vxor1(int16(x)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vxor1(int32(x)));
            else
                return generic<T>(dinx.vxor1(int64(x)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vxor1_256f<T>(Vector256<T> x)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vxor1(float32(x)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vxor1(float64(x)));
            else
                throw unsupported<T>();
        }
    }
}