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
        public static bool between<T>(T x, T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return betweenu(x,a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return betweeni(x,a,b);
            else
                return gfp.between(x,a,b);
        }


        [MethodImpl(Inline)]
        static bool betweeni<T>(T x, T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.between(int8(x), int8(a), int8(b));
            if(typeof(T) == typeof(short))
                return math.between(int16(x), int16(a), int16(b));
            if(typeof(T) == typeof(int))
                return math.between(int32(x), int32(a), int32(b));
            else 
                return math.between(int64(x), int64(a), int64(b));
        }

        [MethodImpl(Inline)]
        static bool betweenu<T>(T x, T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.between(uint8(x), uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return math.between(int32(x), int32(a), int32(b));
            else if(typeof(T) == typeof(uint))
                return math.between(uint32(x), uint32(a), uint32(b));
            else 
                return math.between(uint64(x), uint64(a), uint64(b));
        }

    }

}