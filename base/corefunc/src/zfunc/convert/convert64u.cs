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
        public static T convert<T>(ulong src)
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
        static T converti<T>(ulong src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return generic<T>((int)src);
            else  
                return generic<T>((long)src);           
        }

        [MethodImpl(Inline)]
        static T convertu<T>(ulong src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)src);
            else  
                return generic<T>((ulong)src);
        }

        [MethodImpl(Inline)]
        static ref T convertx<T>(ulong src, out T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                dst = g32f<T>((float)src);
            else if(typeof(T) == typeof(double))
                dst = g64f<T>((double)(long)src);
            else if(typeof(T) == typeof(char))
                dst = g16ch<T>((char)(short)src);
            else            
                throw unsupported<T>();
            return ref dst;
        }

        [MethodImpl(Inline)]
        static T convertx<T>(ulong src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return g32f<T>((float)src);
            else if(typeof(T) == typeof(double))
                return g64f<T>((double)(long)src);
            else if(typeof(T) == typeof(char))
                return g16ch<T>((char)src);
            else            
                throw unsupported<T>();
        }
    }
}