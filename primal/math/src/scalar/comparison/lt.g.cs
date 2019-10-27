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
        public static bool lt<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return lt_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return lt_i(a,b);
            else 
                return gfp.lt(a,b);
        }

        [MethodImpl(Inline)]
        public static bool lteq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return lteq_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return lteq_i(a,b);
            else 
                return gfp.lteq(a,b);
        }

        [MethodImpl(Inline)]
        static bool lt_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.lt(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return math.lt(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return math.lt(int32(a), int32(b));
            else
                 return math.lt(int64(a), int64(b));
        }

        [MethodImpl(Inline)]
        static bool lt_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.lt(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return math.lt(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                return math.lt(uint32(a), uint32(b));
            else 
                return math.lt(uint64(a), uint64(b));
        }

        [MethodImpl(Inline)]
        static bool lteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.lteq(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return math.lteq(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return math.lteq(int32(a), int32(b));
            else
                 return math.lteq(int64(a), int64(b));
        }

        [MethodImpl(Inline)]
        static bool lteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.lteq(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return math.lteq(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                return math.lteq(uint32(a), uint32(b));
            else 
                return math.lteq(uint64(a), uint64(b));
        }
    }
}