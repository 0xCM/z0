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
    using System.Diagnostics;
    
    using static zfunc;    
    using static As;

    partial class gmath
    {

        [MethodImpl(Inline)]
        public static bool divides<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typematch<T,sbyte>())
                return math.divides(int8(lhs), int8(rhs));
            else if(typematch<T,byte>())
                return math.divides(uint8(lhs), uint8(rhs));
            else if(typematch<T,short>())
                return math.divides(int16(lhs), int16(rhs));
            else if(typematch<T,ushort>())
                return math.divides(uint16(lhs), uint16(rhs));
            else if(typematch<T,int>())
                return math.divides(int32(lhs), int32(rhs));
            else if(typematch<T,uint>())
                return math.divides(uint32(lhs), uint32(rhs));
            else if(typematch<T,long>())
                return math.divides(int64(lhs), int64(rhs));
            else if(typematch<T,ulong>())
                return math.divides(uint64(lhs), uint64(rhs));
            else if(typeof(T) == typeof(float))
                return fmath.divides(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                return fmath.divides(float64(lhs), float64(rhs));
            else            
                throw unsupported<T>();
        }

    }
}