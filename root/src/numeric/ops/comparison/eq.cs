//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial class Numeric
    {
        [MethodImpl(Inline)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
                => eq_u(a,b);

        [MethodImpl(Inline)]
        static bit eq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Eq.eq(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return Eq.eq(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                return Eq.eq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return Eq.eq(uint64(a), uint64(b));
            else
                return eq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit eq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return Eq.eq(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return Eq.eq(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return Eq.eq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return Eq.eq(int64(a), int64(b));
             else 
                return eq_f(a,b);
       }

        [MethodImpl(Inline)]
        static bit eq_f<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Eq.eq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return Eq.eq(float64(a), float64(b));
            else            
                throw Unsupported.define<T>();
        }

        static class Eq
        {
            [MethodImpl(Inline)]
            public static bit eq(sbyte a, sbyte b)
                => a == b;

            [MethodImpl(Inline)]
            public static bit eq(byte a, byte b)
                => a == b;

            [MethodImpl(Inline)]
            public static bit eq(short a, short b)
                => a == b;

            [MethodImpl(Inline)]
            public static bit eq(ushort a, ushort b)
                => a == b;

            [MethodImpl(Inline)]
            public static bit eq(int a, int b)
                => a == b;

            [MethodImpl(Inline)]
            public static bit eq(uint a, uint b)
                => a == b;

            [MethodImpl(Inline)]
            public static bit eq(long a, long b)
                => a == b;

            [MethodImpl(Inline)]
            public static bit eq(ulong a, ulong b)
                => a == b;

            [MethodImpl(Inline), Op]
            public static bit eq(float a, float b)
                => a == b;

            [MethodImpl(Inline), Op]
            public static bit eq(double a, double b)
                => a == b;
        }


    }
}