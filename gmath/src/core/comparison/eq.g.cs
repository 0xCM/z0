//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
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
        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return eq_u(a,b);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return eq_i(a,b);
            else 
                return gfp.eq(a,b);
        }

        [MethodImpl(Inline), ZFunc(PrimalKind.All)]
        public static T eqz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.eq(a,b)),gmath.ones<T>());

        [MethodImpl(Inline)]
        static bit eq_i<T>(T a, T b)
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
        static bit eq_u<T>(T a, T b)
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