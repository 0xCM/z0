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
        public static ushort to16u(sbyte src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort to16u(byte src)        
            => (ushort)src;
        
        [MethodImpl(Inline), Op]
        public static ushort to16u(short src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort to16u(ushort src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort to16u(int src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort to16u(uint src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort to16u(long src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort to16u(ulong src)        
            => (ushort)src;

        [MethodImpl(Inline), Op]
        public static ushort to16u(float src)
            => (ushort)((int)src);

        [MethodImpl(Inline), Op]
        public static ushort to16u(double src)
            => (ushort)((ulong)src);        
 
        [MethodImpl(Inline)]
        static T to_u<T>(ushort src)
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
        static T to_i<T>(ushort src)
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
        static T to_x<T>(ushort src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>(to64f(src));
            else if(typeof(T) == typeof(char))
                return  generic<T>((char)src);
            else            
                return Unsupported.define<ushort,T>(src);
       }
    }
}