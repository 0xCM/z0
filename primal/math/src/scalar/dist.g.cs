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
        public static ulong dist<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return distu(lhs,rhs);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return disti(lhs,rhs);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static ulong disti<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.dist(int8(lhs), int8(rhs));
            else if(typeof(T) == typeof(short))
                 return math.dist(int16(lhs), int16(rhs));
            else if(typeof(T) == typeof(int))
                 return math.dist(int32(lhs), int32(rhs));
            else
                 return math.dist(int64(lhs), int64(rhs));
        }

        [MethodImpl(Inline)]
        static ulong distu<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return math.dist(uint8(lhs), uint8(rhs));
            else if(typeof(T) == typeof(ushort))
                 return math.dist(uint16(lhs), uint16(rhs));
            else if(typeof(T) == typeof(uint))
                 return math.dist(uint32(lhs), uint32(rhs));
            else
                 return math.dist(uint64(lhs), uint64(rhs));
        }

    }

}