//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Memories;
    using static As;
    using static CastNumeric;

    partial class Numeric
    {
        [MethodImpl(Inline)]
        public static bit lteq<T>(T a, T b)
            where T : unmanaged
                => lteq_u(a,b);

        [MethodImpl(Inline)]
        static bit lteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return LtEq.lteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return LtEq.lteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return LtEq.lteq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return LtEq.lteq(uint64(a), uint64(b));
            else
                return lteq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit lteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return LtEq.lteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return LtEq.lteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                 return LtEq.lteq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return LtEq.lteq(int64(a), int64(b));
            else
                return lteq_f(a,b);
        }

        [MethodImpl(Inline)]
        static bit lteq_f<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return LtEq.lteq(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return LtEq.lteq(float64(lhs), float64(rhs));
            else            
                throw Unsupported.define<T>();
        }

        static class LtEq
        {
            [MethodImpl(Inline)]
            public static bit lteq(sbyte a, sbyte b)
                => a <= b;

            [MethodImpl(Inline)]
            public static bit lteq(byte a, byte b)
                => a <= b;

            [MethodImpl(Inline)]
            public static bit lteq(short a, short b)
                => a <= b;

            [MethodImpl(Inline)]
            public static bit lteq(ushort a, ushort b)
                => a <= b;

            [MethodImpl(Inline)]
            public static bit lteq(int a, int b)
                => a <= b;

            [MethodImpl(Inline)]
            public static bit lteq(uint a, uint b)
                => a <= b;

            [MethodImpl(Inline)]
            public static bit lteq(long a, long b)
                => a <= b;

            [MethodImpl(Inline)]
            public static bit lteq(ulong a, ulong b)
                => a <= b; 

            [MethodImpl(Inline)]
            public static bit lteq(float lhs, float rhs)
                => lhs <= rhs;

            [MethodImpl(Inline)]
            public static bit lteq(double lhs, double rhs)
                => lhs <= rhs;                    
        }
    }
}