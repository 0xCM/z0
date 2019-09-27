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
        public static bool gt<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return gtu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return gti(lhs,rhs);
            else return gfp.gt(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static bool gteq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return gtequ(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return gteqi(lhs,rhs);
            else return gfp.gteq(lhs,rhs);
        }

        [MethodImpl(Inline)]
        static bool gti<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.gt(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.gt(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.gt(int32(lhs), int32(rhs));
            else
                 return math.gt(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static bool gtu<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.gt(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.gt(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                return math.gt(uint32(lhs), uint32(rhs));
            else 
                return math.gt(uint64(lhs), uint64(rhs));
        }

        [MethodImpl(Inline)]
        static bool gteqi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.gteq(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.gteq(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.gteq(int32(lhs), int32(rhs));
            else
                 return math.gteq(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static bool gtequ<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.gteq(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.gteq(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                return math.gteq(uint32(lhs), uint32(rhs));
            else 
                return math.gteq(uint64(lhs), uint64(rhs));
        }
    }
}