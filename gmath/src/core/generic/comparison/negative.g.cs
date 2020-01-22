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
        /// Determines whether a value is less than zero
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline), Op, PrimalClosures(PrimalKind.Integers)]
        public static bit negative<T>(T src)
            where T : unmanaged
        {                        
            if(typeof(T) == typeof(sbyte))
                return math.negative(int8(src));
            else if(typeof(T) == typeof(short))
                return math.negative(int16(src));
            else if(typeof(T) == typeof(int))
                return math.negative(int32(src));
            else if(typeof(T) == typeof(long))
                return math.negative(int64(src));
            else if(typeof(T) == typeof(float))
                return math.negative(float32(src));
            else if(typeof(T) == typeof(double))
                return math.negative(float64(src));
            else            
                 return false;
       }           
    }

}