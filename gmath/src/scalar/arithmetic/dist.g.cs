//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static zfunc;    
    using static As;

    partial class gmath
    {        
        [MethodImpl(Inline)]
        public static ulong dist<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return dist_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return dist_i(a,b);
            else 
                throw unsupported<T>();
        }

        [MethodImpl(Inline)]
        static ulong dist_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.dist(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return math.dist(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return math.dist(int32(a), int32(b));
            else
                 return math.dist(int64(a), int64(b));
        }

        [MethodImpl(Inline)]
        static ulong dist_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                 return math.dist(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                 return math.dist(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                 return math.dist(uint32(a), uint32(b));
            else
                 return math.dist(uint64(a), uint64(b));
        }
    }
}