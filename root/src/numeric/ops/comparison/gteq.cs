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
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
                => gteq_u(a,b);

        [MethodImpl(Inline)]
        static bit gteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return GtEq.gteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return GtEq.gteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return GtEq.gteq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return GtEq.gteq(uint64(a), uint64(b));
            else
                return gteq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit gteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return GtEq.gteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return GtEq.gteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                return GtEq.gteq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                return GtEq.gteq(int64(a), int64(b));
            else
                return gteq_f(a,b);
        }

        [MethodImpl(Inline)]
        static bit gteq_f<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return GtEq.gteq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return GtEq.gteq(float64(a), float64(b));
            else            
                throw Unsupported.define<T>();
        }

        static class GtEq
        {
            [MethodImpl(Inline)]
            public static bit gteq(sbyte a, sbyte b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(byte a, byte b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(short a, short b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(ushort a, ushort b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(int a, int b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(uint a, uint b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(long a, long b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(ulong a, ulong b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(float a, float b)
                => a >= b;

            [MethodImpl(Inline)]
            public static bit gteq(double a, double b)
                => a >= b;                    
        }
    }
}