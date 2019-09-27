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
        public static bool positive<T>(T src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return int8(src) > 0;
            else if(typematch<T,byte>())
                return uint8(src) > 0;
            else if(typematch<T,short>())
                return int16(src) > 0;
            else if(typematch<T,ushort>())
                return uint16(src) > 0;
            else if(typematch<T,int>())
                return int32(src) > 0;
            else if(typematch<T,uint>())
                return uint32(src) > 0;
            else if(typematch<T,long>())
                return int64(src) > 0;
            else if(typematch<T,ulong>())
                return uint64(src) > 0;
            else if(typeof(T) == typeof(float))
                return float32(src) > 0;
            else if(typeof(T) == typeof(double))
                return float64(src) > 0;
            else            
                 throw unsupported<T>();                
       }           
    }

}