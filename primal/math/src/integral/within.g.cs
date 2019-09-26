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
        /// <param name="lhs">The left operand</param>
        /// <param name="rhs">The right operand</param>
        /// <param name="epsilon">The tolerance</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bool within<T>(T lhs, T rhs, T epsilon)
            where T : struct
        {
            if(typematch<T,sbyte>())
                return math.within(int8(lhs), int8(rhs), int8(epsilon));
            else if(typematch<T,byte>())
                return math.within(uint8(lhs), uint8(rhs), uint8(epsilon));
            else if(typematch<T,short>())
                return math.within(int16(lhs), int16(rhs), int16(epsilon));
            else if(typematch<T,ushort>())
                return math.within(uint16(lhs), uint16(rhs), uint16(epsilon));
            else if(typematch<T,int>())
                return math.within(int32(lhs), int32(rhs), int32(epsilon));
            else if(typematch<T,uint>())
                return math.within(uint32(lhs), uint32(rhs), uint32(epsilon));
            else if(typematch<T,long>())
                return math.within(int64(lhs), int64(rhs), int64(epsilon));
            else if(typematch<T,ulong>())
                return math.within(uint64(lhs), uint64(rhs), uint64(epsilon));
            else if(typematch<T,float>())
                return math.within(float32(lhs), float32(rhs), float32(epsilon));
            else if(typematch<T,double>())
                return math.within(float64(lhs), float64(rhs), float64(epsilon));
            else            
                throw unsupported<T>();

        }

    }
}