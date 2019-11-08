//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Linq;
    using System.Reflection;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {
        /// <summary>
        /// Determines whether a value is strictly greater than zero
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static bit positive<T>(T src)
            where T : unmanaged 
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return positive_u(src);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return positive_i(src);
            else 
                return positive_f(src);
        }

        [MethodImpl(Inline)]
        static bit positive_i<T>(T src)
            where T : unmanaged
        {                        
            if(typeof(T) == typeof(sbyte))
                return math.positive(int8(src));
            else if(typeof(T) == typeof(short))
                return math.positive(int16(src));
            else if(typeof(T) == typeof(int))
                return math.positive(int32(src));
            else
                return math.positive(int64(src));
       }           

        [MethodImpl(Inline)]
        static bit positive_u<T>(T src)
            where T : unmanaged
        {                        
            if(typeof(T) == typeof(byte))
                return math.positive(uint8(src));
            else if(typeof(T) == typeof(ushort))
                return math.positive(uint16(src));
            else if(typeof(T) == typeof(uint))
                return math.positive(uint32(src));
            else
                return math.positive(uint64(src));
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