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
        [MethodImpl(Inline)]
        public static bool divides<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return dividesu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return dividesi(lhs,rhs);
            else return gfp.divides(lhs,rhs);
        }

        [MethodImpl(Inline)]
        static bool dividesi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.divides(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.divides(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.divides(int32(lhs), int32(rhs));
            else
                 return math.divides(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static bool dividesu<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.divides(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.divides(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                return math.divides(uint32(lhs), uint32(rhs));
            else 
                return math.divides(uint64(lhs), uint64(rhs));
        }

    }
}