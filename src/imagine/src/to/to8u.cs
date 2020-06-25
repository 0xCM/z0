//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    using static As;
    
    partial class ToNumeric
    {
        [MethodImpl(Inline), Op]
        public static byte to8u(sbyte src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte to8u(byte src)        
            => (byte)src;
        
        [MethodImpl(Inline), Op]
        public static byte to8u(short src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte to8u(ushort src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte to8u(int src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte to8u(uint src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte to8u(long src)        
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static uint to8u(ulong src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static byte to8u(float src)
            => (byte)src;

        [MethodImpl(Inline), Op]
        public static byte to8u(double src)
            => (byte)src;
        
        [MethodImpl(Inline)]
        static T to_u<T>(byte src)
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
        static T to_i<T>(byte src)
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
        static T to_x<T>(byte src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>(to64f(src));
            else if(typeof(T) == typeof(char))
                return generic<T>((char)src);
            else            
                return Unsupported.define<byte,T>(src);
       }        
    }
}