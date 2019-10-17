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
        public static Vector128<T> vnand<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnand_128u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnand_128i(x,y);
            else 
                return vnand_128f(x,y);
        }

        [MethodImpl(Inline)]
        public static Vec128<T> vnand<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnand_128u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnand_128i(x,y);
            else 
                return vnand_128f(x,y);
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vnand<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnand_256u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnand_256i(x,y);
            else 
                return vnand_256f(x,y);
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vnand<T>(in Vec256<T> x, Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vnand_256u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vnand_256i(x,y);
            else 
                return vnand_256f(x,y);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnand_128u<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnand(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnand(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnand(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vnand(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vnand_128u<T>(Vec128<T> x, Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnand(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnand(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnand(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vnand(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vnand_128i<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnand(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnand(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnand(int32(x), int32(y)));
            else
                return generic<T>(dinx.vnand(int64(x), int64(y)));
        }


        [MethodImpl(Inline)]
        static Vector128<T> vnand_128i<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnand(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnand(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnand(int32(x), int32(y)));
            else
                return generic<T>(dinx.vnand(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> vnand_128f<T>(Vector128<T> x, Vector128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vnand(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vnand(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vec128<T> vnand_128f<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vnand(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vnand(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnand_256u<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnand(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnand(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnand(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vnand(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vnand_256u<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vnand(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vnand(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vnand(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vnand(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vnand_256i<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnand(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnand(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnand(int32(x), int32(y)));
            else
                return generic<T>(dinx.vnand(int64(x), int64(y)));
        }


        [MethodImpl(Inline)]
        static Vector256<T> vnand_256i<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vnand(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vnand(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vnand(int32(x), int32(y)));
            else
                return generic<T>(dinx.vnand(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> vnand_256f<T>(Vector256<T> x, Vector256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vnand(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vnand(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

       [MethodImpl(Inline)]
        static Vec256<T> vnand_256f<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vnand(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vnand(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

    }
}