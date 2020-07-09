//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    
    using static Konst;
    
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
                return core.generic<T>((byte)src);
            else if(typeof(T) == typeof(ushort))
                return core.generic<T>((ushort)src);
            else if(typeof(T) == typeof(uint))
                return core.generic<T>((uint)src);
            else if(typeof(T) == typeof(ulong)) 
                return core.generic<T>((ulong)src);
            else 
                return to_i<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_i<T>(sbyte src)
        {
            if(typeof(T) == typeof(sbyte))
                return core.generic<T>((sbyte)src);
            else if(typeof(T) == typeof(short))
                return core.generic<T>((short)src);
            else if(typeof(T) == typeof(int))
                return core.generic<T>((int)src);
            else if(typeof(T) == typeof(long))
                return core.generic<T>((long)src);           
            else 
                return to_x<T>(src);
        }

        [MethodImpl(Inline)]
        static T to_x<T>(sbyte src)
        {
            if(typeof(T) == typeof(float))
                return core.generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return core.generic<T>((double)((long)src));
            else if(typeof(T) == typeof(char))
                return core.generic<T>((char)src);
            else            
                return Unsupported.define<sbyte,T>(src);
       }
   }
}