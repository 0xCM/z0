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
        public static short to16i(sbyte src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short to16i(byte src)        
            => (short)src;
        
        [MethodImpl(Inline), Op]
        public static short to16i(short src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short to16i(ushort src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short to16i(int src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short to16i(uint src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short to16i(long src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short to16i(ulong src)        
            => (short)src;

        [MethodImpl(Inline), Op]
        public static short to16i(float src)
            => (short)((int)src);

        [MethodImpl(Inline), Op]
        public static short to16i(double src)
            => (short)((long)src);        


        [MethodImpl(Inline)]
        static T to_u<T>(short src)
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
        static T to_i<T>(short src)
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
        static T to_x<T>(short src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>(to64f(src));
            else if(typeof(T) == typeof(char))
                return  generic<T>((char)src);
            else            
                return Unsupported.raise<T>();
        }    
    }
}