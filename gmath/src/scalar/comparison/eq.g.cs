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
        public static bit eq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return equ(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return eqi(a,b);
            else 
                return gfp.eq(a,b);
        }


        [MethodImpl(Inline)]
        static bit eqi<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return math.eq(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return math.eq(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return math.eq(int32(a), int32(b));
            else
                 return math.eq(int64(a), int64(b));
        }

        [MethodImpl(Inline)]
        static bit equ<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.eq(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return math.eq(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                return math.eq(uint32(a), uint32(b));
            else 
                return math.eq(uint64(a), uint64(b));
        }

    }
}