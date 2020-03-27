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
        public static bit lt<T>(T a, T b)
            where T : unmanaged
                => lt_u(a,b);

        [MethodImpl(Inline)]
        static bit lt_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Lt.lt(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return Lt.lt(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return Lt.lt(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return Lt.lt(uint64(a), uint64(b));
            else
                return lt_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit lt_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Lt.lt(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return Lt.lt(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                 return Lt.lt(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return Lt.lt(int64(a), int64(b));
            else
                return lt_f(a,b);
        }

        [MethodImpl(Inline)]
        static bit lt_f<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Lt.lt(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return Lt.lt(float64(lhs), float64(rhs));
            else            
                throw Unsupported.define<T>();
        }

        static class Lt
        {
            [MethodImpl(Inline)]
            public static bit lt(sbyte a, sbyte b)
                => a < b;

            [MethodImpl(Inline)]
            public static bit lt(byte a, byte b)
                => a < b;

            [MethodImpl(Inline)]
            public static bit lt(short a, short b)
                => a < b;

            [MethodImpl(Inline)]
            public static bit lt(ushort a, ushort b)
                => a < b;

            [MethodImpl(Inline)]
            public static bit lt(int a, int b)
                => a < b;

            [MethodImpl(Inline)]
            public static bit lt(uint a, uint b)
                => a < b;

            [MethodImpl(Inline)]
            public static bit lt(long a, long b)
                => a < b;

            [MethodImpl(Inline)]
            public static bit lt(ulong a, ulong b)
                => a < b;        

            [MethodImpl(Inline)]
            public static bit lt(float lhs, float rhs)
                => lhs < rhs;

            [MethodImpl(Inline)]
            public static bit lt(double lhs, double rhs)
                => lhs < rhs;                    
        }
    }
}