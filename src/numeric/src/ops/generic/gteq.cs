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
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
                => gteq_u(a,b);

        [MethodImpl(Inline)]
        static bit gteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Z0.Scalar.gteq(convert<T, uint>(a), convert<T, uint>(b));
            else if(typeof(T) == typeof(ushort))
                return Z0.Scalar.gteq(convert<T, uint>(a), convert<T, uint>(b));
            else if(typeof(T) == typeof(uint))
                return Z0.Scalar.gteq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return Z0.Scalar.gteq(uint64(a), uint64(b));
            else
                return gteq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit gteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Z0.Scalar.gteq(convert<T, int>(a), convert<T, int>(b));
            else if(typeof(T) == typeof(short))
                return Z0.Scalar.gteq(convert<T, int>(a), convert<T, int>(b));
            else if(typeof(T) == typeof(int))
                return Z0.Scalar.gteq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                return Z0.Scalar.gteq(int64(a), int64(b));
            else
                return gteq_f(a,b);
        }

        [MethodImpl(Inline)]
        static bit gteq_f<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Z0.Scalar.gteq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return Z0.Scalar.gteq(float64(a), float64(b));
            else            
                throw Unsupported.define<T>();
        }
    }
}