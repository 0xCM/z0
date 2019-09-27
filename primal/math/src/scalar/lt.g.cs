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
        public static bool lt<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return ltu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return lti(lhs,rhs);
            else return gfp.lt(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return ltequ(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return lteqi(lhs,rhs);
            else return gfp.lteq(lhs,rhs);
        }

        [MethodImpl(Inline)]
        static bool lti<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.lt(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.lt(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.lt(int32(lhs), int32(rhs));
            else
                 return math.lt(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static bool ltu<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.lt(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.lt(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                return math.lt(uint32(lhs), uint32(rhs));
            else 
                return math.lt(uint64(lhs), uint64(rhs));
        }

        [MethodImpl(Inline)]
        static bool lteqi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.lteq(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.lteq(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.lteq(int32(lhs), int32(rhs));
            else
                 return math.lteq(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static bool ltequ<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.lteq(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.lteq(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                return math.lteq(uint32(lhs), uint32(rhs));
            else 
                return math.lteq(uint64(lhs), uint64(rhs));
        }
    }
}