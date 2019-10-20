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
        public static Vector128<T> vones128<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vones_128u<T>();
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vones_128i<T>();
            else 
                return vones_128f<T>();
        }

        [MethodImpl(Inline)]
        public static Vector256<T> vones256<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return vones_256u<T>();
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return vones_256i<T>();
            else 
                return vones_256f<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vones_128i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vones_128x8i());
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vones_128x16i());
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vones_128x32i());
            else 
                return generic<T>(dinx.vones_128x64i());
        }

        [MethodImpl(Inline)]
        static Vector128<T> vones_128u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vones_128x8u());
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vones_128x16u());
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vones_128x32u());
            else 
                return generic<T>(dinx.vones_128x64u());
        }


        [MethodImpl(Inline)]
        static Vector128<T> vones_128f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.vones_128x32f());
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.vones_128x64f());
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vones_256i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.vones_256x8i());
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.vones_256x16i());
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.vones_256x32i());
            else 
                return generic<T>(dinx.vones_256x64i());
        }

        [MethodImpl(Inline)]
        static Vector256<T> vones_256u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.vones_256x8u());
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.vones_256x16u());
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.vones_256x32u());
            else 
                return generic<T>(dinx.vones_256x64u());
        }


        [MethodImpl(Inline)]
        static Vector256<T> vones_256f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.ones_256x32f());
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.ones_256x64f());
            else 
                throw unsupported<T>();
        }
    }

}