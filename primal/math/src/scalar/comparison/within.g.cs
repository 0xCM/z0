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
        /// Returns true if the difference between two operands is within a specified tolerance
        /// </summary>
        /// <param name="x">The left operand</param>
        /// <param name="y">The right operand</param>
        /// <param name="epsilon">The tolerance</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool within<T>(T x, T y, T epsilon)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.within(int8(x), int8(y), int8(epsilon));
            else if(typeof(T) == typeof(byte))
                return math.within(uint8(x), uint8(y), uint8(epsilon));
            else if(typeof(T) == typeof(short))
                return math.within(int16(x), int16(y), int16(epsilon));
            else if(typeof(T) == typeof(ushort))
                return math.within(uint16(x), uint16(y), uint16(epsilon));
            else if(typeof(T) == typeof(int))
                return math.within(int32(x), int32(y), int32(epsilon));
            else if(typeof(T) == typeof(uint))
                return math.within(uint32(x), uint32(y), uint32(epsilon));
            else if(typeof(T) == typeof(long))
                return math.within(int64(x), int64(y), int64(epsilon));
            else if(typeof(T) == typeof(ulong))
                return math.within(uint64(x), uint64(y), uint64(epsilon));
            else if(typeof(T) == typeof(float))
                return fmath.within(float32(x), float32(y), float32(epsilon));
            else if(typeof(T) == typeof(double))
                return fmath.within(float64(x), float64(y), float64(epsilon));
            else            
                throw unsupported<T>();

        }

    }
}