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
        public static Vec128<T> vor<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor_128u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor_128i(x,y);
            else 
                return vor_128f(x,y);
        }

        [MethodImpl(Inline)]
        public static Vec256<T> vor<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vor_256u(x,y);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vor_256i(x,y);
            else 
                return vor_256f(x,y);
        }

        [MethodImpl(Inline)]
        static Vec128<T> vor_128u<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vor(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vor(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vor(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vor(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vor_128i<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vor(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vor(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vor(int32(x), int32(y)));
            else
                return generic<T>(dinx.vor(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vec128<T> vor_128f<T>(in Vec128<T> x, in Vec128<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vor(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vor(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }


        [MethodImpl(Inline)]
        static Vec256<T> vor_256u<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vor(uint8(x), uint8(y)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vor(uint16(x), uint16(y)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vor(uint32(x), uint32(y)));
            else
                return generic<T>(dinx.vor(uint64(x), uint64(y)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vor_256i<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vor(int8(x), int8(y)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vor(int16(x), int16(y)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vor(int32(x), int32(y)));
            else
                return generic<T>(dinx.vor(int64(x), int64(y)));
        }

        [MethodImpl(Inline)]
        static Vec256<T> vor_256f<T>(in Vec256<T> x, in Vec256<T> y)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dinx.vor(float32(x), float32(y)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dinx.vor(float64(x), float64(y)));
            else
                throw unsupported<T>();
        }

 
    }
}