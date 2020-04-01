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
    using static CastNumeric;

    partial class Numeric
    {
        [MethodImpl(Inline)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
                => gt_u(a,b);

        [MethodImpl(Inline)]
        static bit gt_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return Z0.Scalar.gt(convert<T, uint>(a), convert<T, uint>(b));
            else if(typeof(T) == typeof(ushort))
                return Z0.Scalar.gt(convert<T, uint>(a), convert<T, uint>(b));
            else if(typeof(T) == typeof(uint))
                return Z0.Scalar.gt(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return Z0.Scalar.gt(uint64(a), uint64(b));
            else
                return gt_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit gt_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return Z0.Scalar.gt(convert<T, int>(a), convert<T, int>(b));
            else if(typeof(T) == typeof(short))
                return Z0.Scalar.gt(convert<T, int>(a), convert<T, int>(b));
            else if(typeof(T) == typeof(int))
                 return Z0.Scalar.gt(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return Z0.Scalar.gt(int64(a), int64(b));
            else
                return gt_f(a,b);
        }

        static bit gt_f<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                 return Z0.Scalar.gt(float32(a), float32(b));
            else if(typeof(T) == typeof(double))
                 return Z0.Scalar.gt(float64(a), float64(b));
            else            
                throw Unsupported.define<T>();
        }
    }

    partial class Scalar
    {
        [MethodImpl(Inline)]
        public static bit gt(sbyte a, sbyte b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(byte a, byte b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(short a, short b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(ushort a, ushort b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(int a, int b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(uint a, uint b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(long a, long b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(ulong a, ulong b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(float a, float b)
            => a > b;

        [MethodImpl(Inline)]
        public static bit gt(double a, double b)
            => a > b;        
    }            
}