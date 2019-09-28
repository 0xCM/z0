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
        /// Computes the sign of a primal operand
        /// </summary>
        /// <param name="src">The source value</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static Sign signum<T>(T src)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return math.signum(int8(src));
            else if(typematch<T,byte>())
                return math.signum(uint8(src));
            else if(typematch<T,short>())
                return math.signum(int16(src));
            else if(typematch<T,ushort>())
                return math.signum(uint16(src));
            else if(typematch<T,int>())
                return math.signum(int32(src));
            else if(typematch<T,uint>())
                return math.signum(uint32(src));
            else if(typematch<T,long>())
                return math.signum(int64(src));
            else if(typematch<T,ulong>())
                return math.signum(uint64(src));
            else if(typeof(T) == typeof(float))
                return fmath.signum(float32(src));
            else if(typeof(T) == typeof(double))
                return fmath.signum(float64(src));
            else            
                throw unsupported<T>();
        }           
    }

}