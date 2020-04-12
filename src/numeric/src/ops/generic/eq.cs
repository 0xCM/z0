//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;
    using static As;

    partial class Numeric
    {
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
                => eq_u(a,b);

        [MethodImpl(Inline)]
        static bit eq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Z0.Scalar.eq(uint8(a), uint8(b));
            else if(typeof(T) == typeof(ushort))
                return Z0.Scalar.eq(uint16(a), uint16(b));
            else if(typeof(T) == typeof(uint))
                return Z0.Scalar.eq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return Z0.Scalar.eq(uint64(a), uint64(b));
            else
                return eq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit eq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return Z0.Scalar.eq(int8(a), int8(b));
            else if(typeof(T) == typeof(short))
                 return Z0.Scalar.eq(int16(a), int16(b));
            else if(typeof(T) == typeof(int))
                 return Z0.Scalar.eq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return Z0.Scalar.eq(int64(a), int64(b));
             else 
                return eq_f(a,b);
       }

        [MethodImpl(Inline)]
        static bit eq_f<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Z0.Scalar.eq(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return Z0.Scalar.eq(float64(a), float64(b));
            else            
                throw Unsupported.define<T>();
        }
    }
}