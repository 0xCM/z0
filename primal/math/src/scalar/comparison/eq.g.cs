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
        public static bool eq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return equ(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return eqi(lhs,rhs);
            else 
                return gfp.eq(lhs,rhs);
        }

        [MethodImpl(Inline)]
        public static bool neq<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return nequ(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return neqi(lhs,rhs);
            else return gfp.neq(lhs,rhs);
        }

        [MethodImpl(Inline)]
        static bool neqi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.neq(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.neq(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.neq(int32(lhs), int32(rhs));
            else
                 return math.neq(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static bool nequ<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.neq(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.neq(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                return math.neq(uint32(lhs), uint32(rhs));
            else 
                return math.neq(uint64(lhs), uint64(rhs));
        }

        [MethodImpl(Inline)]
        static bool eqi<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.eq(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.eq(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.eq(int32(lhs), int32(rhs));
            else
                 return math.eq(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static bool equ<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.eq(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                return math.eq(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                return math.eq(uint32(lhs), uint32(rhs));
            else 
                return math.eq(uint64(lhs), uint64(rhs));
        }

    }
}