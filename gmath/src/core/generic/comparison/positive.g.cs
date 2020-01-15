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
        [MethodImpl(Inline), PrimalClosures(PrimalKind.All)]
        public static bit positive<T>(T a)
            where T : unmanaged 
                => positive_u(a);

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
            else if(typeof(T) == typeof(ulong))
                return math.positive(uint64(a));
            else 
                return positive_i(a);
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
            else if(typeof(T) == typeof(long))
                return math.positive(int64(a));
            else 
                return positive_f(a);
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