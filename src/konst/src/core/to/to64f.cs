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
        public static double to64f(sbyte src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double to64f(byte src)        
            => (double)(long)src;
        
        [MethodImpl(Inline), Op]
        public static double to64f(short src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double to64f(ushort src)        
            => (double)(int)src;

        [MethodImpl(Inline), Op]
        public static double to64f(int src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double to64f(uint src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double to64f(long src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double to64f(ulong src)        
            => (double)(long)src;

        [MethodImpl(Inline), Op]
        public static double to64f(float src)        
            => (double)src;

        [MethodImpl(Inline), Op]
        public static double to64f(double src)                
            => (double)src;        

        [MethodImpl(Inline)]
        static T to_u<T>(double src)
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
        static T to_i<T>(double src)
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
                return convert_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T convert_x<T>(double src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>(to32f(src));
            else if(typeof(T) == typeof(double))
                return generic<T>(src);
            else if(typeof(T) == typeof(char))
                return generic<T>((char)(int)src);
            else            
                return Unsupported.define<double,T>(src);
        }       
    }
}