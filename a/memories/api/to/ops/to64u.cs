//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Collections.Generic;
    using System.Linq;

    using static Components;
    using static As;

    partial class ToNumeric
    {
        /// <summary>
        /// Unconditionally converts the source value to a value of parametric numeric type
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.All)]
        public static T to<T>(ulong src)
            => to_u<T>(src);

        /// <summary>
        /// Unconditionally converts the source values to values of parametric numeric type
        /// </summary>
        /// <param name="src">The source values</param>
        /// <typeparam name="T">The numeric type</typeparam>
        public static IEnumerable<T> to<T>(IEnumerable<ulong> src)
            => src.Select(to<T>);

        [MethodImpl(Inline)]
        static T to_u<T>(ulong src)
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
        static T to_i<T>(ulong src)
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
        static T to_x<T>(ulong src)
        {
            if(typeof(T) == typeof(float))
                return As.generic<T>((float)src);
            else if(typeof(T) == typeof(double))
                return As.generic<T>((double)(long)src);
            else if(typeof(T) == typeof(char))
                return As.generic<T>((char)src);
            else            
                return Unsupported.define<ulong,T>(src);
        }

        [MethodImpl(Inline), Op]
        public static ulong to64u(sbyte src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(byte src)        
            => (ulong)src;
        
        [MethodImpl(Inline), Op]
        public static ulong to64u(short src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(ushort src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(int src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(uint src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(long src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(ulong src)        
            => (ulong)src;

        [MethodImpl(Inline), Op]
        public static ulong to64u(float src)        
            => (ulong)((long)src);

        [MethodImpl(Inline), Op]
        public static ulong to64u(double src)
            => (ulong)((long)src);
    }
}