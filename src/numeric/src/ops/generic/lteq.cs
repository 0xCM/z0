//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static CastNumeric;
    using static As;
    
    partial class Numeric
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit lteq<T>(T a, T b)
            where T : unmanaged
                => lteq_u(a,b);

        [MethodImpl(Inline)]
        static bit lteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Z0.Scalar.lteq(convert<T, uint>(a), convert<T, uint>(b));
            else if(typeof(T) == typeof(ushort))
                return Z0.Scalar.lteq(convert<T, uint>(a), convert<T, uint>(b));
            else if(typeof(T) == typeof(uint))
                return Z0.Scalar.lteq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return Z0.Scalar.lteq(uint64(a), uint64(b));
            else
                return lteq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit lteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Z0.Scalar.lteq(convert<T, int>(a), convert<T, int>(b));
            else if(typeof(T) == typeof(short))
                return Z0.Scalar.lteq(convert<T, int>(a), convert<T, int>(b));
            else if(typeof(T) == typeof(int))
                 return Z0.Scalar.lteq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return Z0.Scalar.lteq(int64(a), int64(b));
            else
                return lteq_f(a,b);
        }

        [MethodImpl(Inline)]
        static bit lteq_f<T>(T lhs, T rhs)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Z0.Scalar.lteq(float32(lhs), float32(rhs));
            else if(typeof(T) == typeof(double))
                 return Z0.Scalar.lteq(float64(lhs), float64(rhs));
            else            
                throw Unsupported.define<T>();
        }
    }
}