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
    using static AsIn;    
    using static As;

    partial class ginx
    {
        [MethodImpl(Inline)]
        public static Vector128<T> vbroadcast<T>(N128 n, T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return broadcast128u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return broadcast128i(src);
            else
                return broadcast128f(src);
        }


        [MethodImpl(Inline)]
        public static Vector256<T> vbroadcast<T>(N256 n, T src)
            where T : unmanaged
        {
             if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return broadcast256u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return broadcast256i(src);
            else
                return broadcast256f(src);
       }

        [MethodImpl(Inline)]
        static Vector128<T> broadcast128i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vbroadcast(n128, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vbroadcast(n128, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vbroadcast(n128, int32(src)));
            else 
                return generic<T>(dinx.vbroadcast(n128, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> broadcast128u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vbroadcast(n128, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbroadcast(n128, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vbroadcast(n128, uint32(src)));
            else 
                return generic<T>(dinx.vbroadcast(n128, uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector128<T> broadcast128f<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return  generic<T>(dfp.vbroadcast(n128, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vbroadcast(n128, float64(src)));
            else 
                throw unsupported<T>();
        }
 
        [MethodImpl(Inline)]
        static Vector256<T> broadcast256i<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vbroadcast(n256, int8(src)));
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vbroadcast(n256, int16(src)));
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vbroadcast(n256, int32(src)));
            else 
                return  generic<T>(dinx.vbroadcast(n256, int64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> broadcast256u<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vbroadcast(n256, uint8(src)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vbroadcast(n256, uint16(src)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vbroadcast(n256, uint32(src)));
            else 
                return generic<T>(dinx.vbroadcast(n256, uint64(src)));
        }

        [MethodImpl(Inline)]
        static Vector256<T> broadcast256f<T>(T src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vbroadcast(n256, float32(src)));
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vbroadcast(n256, float64(src)));
            else 
                throw unsupported<T>();
        }

 
    }

}