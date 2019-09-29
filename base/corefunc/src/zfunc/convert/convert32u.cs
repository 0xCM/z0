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
        public static T convert<T>(uint src, out T dst)
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
        public static T convert<T>(uint src)
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
        static T converti<T>(uint src)
        {
            if(typeof(T) == typeof(sbyte))
                return g8i<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return g16i<T>((short)src);
            else if(typeof(T) == typeof(int))
                return g32i<T>((int)src);
            else  
                return g64i<T>((long)src);           
        }

        [MethodImpl(Inline)]
        static T convertu<T>(uint src)
        {
            if(typeof(T) == typeof(byte))
                return g8u<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return g16u<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return g32u<T>((uint)src);
            else  
                return g64u<T>((ulong)src);
        }

        [MethodImpl(Inline)]
        static T convertx<T>(uint src)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return g32f<T>(((float)(int)src));
            else if(typeof(T) == typeof(double))
                return g64f<T>((double)(long)src);
            else if(typeof(T) == typeof(char))
                return g16ch<T>((char)src);
            else            
                throw unsupported<T>();
        }
    }
}