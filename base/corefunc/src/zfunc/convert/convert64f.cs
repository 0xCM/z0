//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    

    using static zfunc;
    using static As;

    partial class Converter
    {
        [MethodImpl(Inline)]
        public static T convert<T>(double src, out T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                dst = converti<T>(src);
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                dst = convertu<T>(src);
            else
                dst = convertx<T>(src);
            return dst;
        }

        [MethodImpl(Inline)]
        public static T convert<T>(double src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return converti<T>(src);
            else if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return convertu<T>(src);
            else
                return convertx<T>(src);
        }

        [MethodImpl(Inline)]
        static T converti<T>(double src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(Float64Convert.to8i(src));
            else if(typeof(T) == typeof(short))
                return generic<T>(Float64Convert.to16i(src));
            else if(typeof(T) == typeof(int))
                return generic<T>(Float64Convert.to32i(src));
            else  
                return generic<T>(Float64Convert.to64i(src));           
        }

        [MethodImpl(Inline)]
        static T convertu<T>(double src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(Float64Convert.to8u(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(Float64Convert.to16u(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(Float64Convert.to32u(src));
            else  
                return generic<T>(Float64Convert.to64u(src));
        }

        [MethodImpl(Inline)]
        static T convertx<T>(in double src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return g32f<T>((float)src);
            else if(typeof(T) == typeof(double))
                return g64f<T>(src);
            else if(typeof(T) == typeof(char))
                return g16ch<T>((char)src);
            else            
                throw unsupported<T>();
        }
    }
}