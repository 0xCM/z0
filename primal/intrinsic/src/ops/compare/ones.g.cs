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
        public static Vec128<T> ones128<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return ones_128u<T>();
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return ones_128i<T>();
            else 
                return ones_128f<T>();

        }

        [MethodImpl(Inline)]
        public static Vec256<T> ones256<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return ones_256u<T>();
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return ones_256i<T>();
            else 
                return ones_256f<T>();

        }

        [MethodImpl(Inline)]
        static Vec128<T> ones_128i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.ones_128x8i());
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.ones_128x16i());
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.ones_128x32i());
            else 
                return generic<T>(dinx.ones_128x64i());
        }

        [MethodImpl(Inline)]
        static Vec128<T> ones_128u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.ones_128x8u());
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.ones_128x16u());
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.ones_128x16u());
            else 
                return generic<T>(dinx.ones_128x16u());
        }


        [MethodImpl(Inline)]
        static Vec128<T> ones_128f<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return generic<T>(dfp.ones_128x32f());
            else if(typeof(T) == typeof(double))
                return generic<T>(dfp.ones_128x64f());
            else 
                throw unsupported<T>();
        }



        [MethodImpl(Inline)]
        static Vec256<T> ones_256i<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(dinx.ones_256x8i());
            else if(typeof(T) == typeof(short))
                return generic<T>(dinx.ones_256x16i());
            else if(typeof(T) == typeof(int))
                return generic<T>(dinx.ones_256x32i());
            else 
                return generic<T>(dinx.ones_256x64i());
        }

        [MethodImpl(Inline)]
        static Vec256<T> ones_256u<T>()
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(dinx.ones_256x8u());
            else if(typeof(T) == typeof(ushort))
                return generic<T>(dinx.ones_256x16u());
            else if(typeof(T) == typeof(uint))
                return generic<T>(dinx.ones_256x16u());
            else 
                return generic<T>(dinx.ones_256x16u());
        }


        [MethodImpl(Inline)]
        static Vec256<T> ones_256f<T>()
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