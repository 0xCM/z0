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
        public static uint to32u(sbyte src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(byte src)        
            => (uint)src;
        
        [MethodImpl(Inline), Op]
        public static uint to32u(short src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(ushort src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(int src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(uint src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(long src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(ulong src)        
            => (uint)src;

        [MethodImpl(Inline), Op]
        public static uint to32u(float src)        
            => (uint)((long)src);

        [MethodImpl(Inline), Op]
        public static uint to32u(double src)
            => (uint)((long)src);

        [MethodImpl(Inline)]
        static T to_u<T>(uint src)
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
        static T to_i<T>(uint src)
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
        static T to_x<T>(uint src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>(to32f(src));
            else if(typeof(T) == typeof(double))
                return generic<T>(to64f(src));
            else if(typeof(T) == typeof(char))
                return generic<T>((char)src);
            else            
                 return Unsupported.define<uint,T>(src);
        }
    }
}