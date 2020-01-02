//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        /// <summary>
        /// Determines whether a value is strictly greater than zero
        /// </summary>
        /// <param name="a">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static bit positive<T>(T a)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return positive_u(a);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return positive_i(a);
            else 
                return positive_f(a);
        }

        [MethodImpl(Inline)]
        static bit positive_i<T>(T a)
            where T : unmanaged
        {                        
            if(typeof(T) == typeof(sbyte))
                return math.positive(int8(a));
            else if(typeof(T) == typeof(short))
                return math.positive(int16(a));
            else if(typeof(T) == typeof(int))
                return math.positive(int32(a));
            else
                return math.positive(int64(a));
       }           

        [MethodImpl(Inline)]
        static bit positive_u<T>(T a)
            where T : unmanaged
        {                        
            if(typeof(T) == typeof(byte))
                return math.positive(uint8(a));
            else if(typeof(T) == typeof(ushort))
                return math.positive(uint16(a));
            else if(typeof(T) == typeof(uint))
                return math.positive(uint32(a));
            else
                return math.positive(uint64(a));
       }           

        [MethodImpl(Inline)]
        static bit positive_f<T>(T src)
            where T : unmanaged
        {                        
            if(typeof(T) == typeof(float))
                return math.positive(float32(src));
            else if(typeof(T) == typeof(double))
                return math.positive(float64(src));
            else            
                 throw unsupported<T>();
       }           
    }
}