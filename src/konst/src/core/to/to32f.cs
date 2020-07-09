//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    using static core;
    
    partial class ToNumeric
    {
        [MethodImpl(Inline), Op]
        public static float to32f(sbyte src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float to32f(byte src)        
            => (float)(int)src;
        
        [MethodImpl(Inline), Op]
        public static float to32f(short src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float to32f(ushort src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float to32f(int src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float to32f(uint src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float to32f(long src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float to32f(ulong src)        
            => (float)(int)src;

        [MethodImpl(Inline), Op]
        public static float to32f(float src)        
            => (float)src;

        [MethodImpl(Inline), Op]
        public static float to32f(double src)        
            => (float)src;

        [MethodImpl(Inline)]
        static T to_u<T>(float src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(to8u(src));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(to16u(src));
            else if(typeof(T) == typeof(uint))
                return generic<T>(to32u(src));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(to64u(src));
            else
                return to_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<T>(float src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(to8i(src));
            else if(typeof(T) == typeof(short))
                return generic<T>(to16i(src));
            else if(typeof(T) == typeof(int))
                return generic<T>(to32i(src));
            else if(typeof(T) == typeof(long))
                return generic<T>(to64i(src));
            else
                return to_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_x<T>(float src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>((double)src);
            else if(typeof(T) == typeof(char))
                return generic<T>((char)(int)src);
            else            
                return Unsupported.define<float,T>(src);
        }
    }
}