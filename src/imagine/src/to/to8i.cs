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
        public static sbyte to8i(sbyte src)        
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte to8i(byte src)        
            => (sbyte)src;
        
        [MethodImpl(Inline), Op]
        public static sbyte to8i(short src)        
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte to8i(ushort src)        
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte to8i(int src)        
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte to8i(uint src)        
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte to8i(long src)        
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte to8i(ulong src)        
            => (sbyte)src;

        [MethodImpl(Inline), Op]
        public static sbyte to8i(float src)
            => (sbyte)((int)src);

        [MethodImpl(Inline), Op]
        public static sbyte to8i(double src)
            => (sbyte)((long)src);
         
        [MethodImpl(Inline)]
        static T to_u<T>(sbyte src)
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
        static T to_i<T>(sbyte src)
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
        static T to_x<T>(sbyte src)
        {
            if(typeof(T) == typeof(float))
                return generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return generic<T>((double)((long)src));
            else if(typeof(T) == typeof(char))
                return generic<T>((char)src);
            else            
                return Unsupported.define<sbyte,T>(src);
       }
   }
}