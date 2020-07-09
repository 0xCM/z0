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
        public static long to64i(sbyte src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(byte src)        
            => (long)src;
        
        [MethodImpl(Inline), Op]
        public static long to64i(short src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(ushort src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(int src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(uint src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(long src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(ulong src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(float src)        
            => (long)src;

        [MethodImpl(Inline), Op]
        public static long to64i(double src)
            => (long)src;

        [MethodImpl(Inline)]
        static T to_u<T>(long src)
        {
            if(typeof(T) == typeof(byte))
                return generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return generic<T>((uint)src);
            else if(typeof(T) == typeof(ulong)) 
                return generic<T>((ulong)src);
            else
                return to_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<T>(long src)
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return generic<T>((int)src);
            else if(typeof(T) == typeof(long))
                return generic<T>((long)src);           
            else
                return to_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_x<T>(long src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>(to32f(src));
            else if(typeof(T) == typeof(double))
                return generic<T>(to64f(src));
            else if(typeof(T) == typeof(char))
                return  generic<T>((char)src);
            else            
                return Unsupported.define<long,T>(src);
        }


    }
}