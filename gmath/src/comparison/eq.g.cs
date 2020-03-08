//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
                => eq_u(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T eqz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.eq(a,b)),ones<T>());

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
            else if(typeof(T) == typeof(ulong))
                return math.eq(uint64(a), uint64(b));
            else
                return eq_i(a,b);
        }

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
            else if(typeof(T) == typeof(long))
                 return math.eq(int64(a), int64(b));
             else 
                return gfp.eq(a,b);
       }
    }
}