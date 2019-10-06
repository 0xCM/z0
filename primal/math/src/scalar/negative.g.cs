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
        /// Determines whether a value is strictly less than zero
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static bool negative<T>(T src)
            where T : unmanaged
        {                        
            if(typeof(T) == typeof(sbyte))
                return int8(src) < 0;
            else if(typeof(T) == typeof(short))
                return int16(src) < 0;
            else if(typeof(T) == typeof(int))
                return int32(src) < 0;
            else if(typeof(T) == typeof(long))
                return int64(src) < 0;
            else if(typematch<T,float>())
                return float32(src) < 0;
            else if(typematch<T,double>())
                return float64(src) < 0;
            else            
                 return false;
       }           
    }

}