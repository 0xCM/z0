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
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit lt<T>(T a, T b)
            where T : unmanaged
                => lt_u(a,b);

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static T ltz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gmath.lt(a,b)),gmath.ones<T>());

        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit lteq<T>(T a, T b)
            where T : unmanaged
                => lteq_u(a,b);

        [MethodImpl(Inline)]
        static bit lt_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.lt(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return math.lt(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return math.lt(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return math.lt(uint64(a), uint64(b));
            else
                return lt_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit lt_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.lt(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return math.lt(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                 return math.lt(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return math.lt(int64(a), int64(b));
            else
                return gfp.lt(a,b);
        }

        [MethodImpl(Inline)]
        static bit lteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.lteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return math.lteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return math.lteq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return math.lteq(uint64(a), uint64(b));
            else
                return lteq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit lteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.lteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return math.lteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                 return math.lteq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return math.lteq(int64(a), int64(b));
            else
                return gfp.lteq(a,b);
        }
    }
}