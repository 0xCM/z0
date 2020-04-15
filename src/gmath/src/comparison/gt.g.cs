//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
                
    using static Seed; 
    using static Memories;

    partial class gmath
    {
        [MethodImpl(Inline), Gt, Closures(Integers)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
                => gt_u(a,b);

        [MethodImpl(Inline), GtEq, Closures(Integers)]
        public static bit gteq<T>(T a, T b)
            where T : unmanaged
                => gteq_u(a,b);

        [MethodImpl(Inline), Gtz, Closures(Integers)]
        public static T gtz<T>(T a, T b)
            where T : unmanaged
                => gmath.mul(convert<T>((uint)gt(a,b)),ones<T>());

        [MethodImpl(Inline)]
        static bit gt_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.gt(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return math.gt(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return math.gt(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return math.gt(uint64(a), uint64(b));
            else
                return gt_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit gt_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.gt(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return math.gt(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                 return math.gt(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return math.gt(int64(a), int64(b));
            else
                return gfp.gt(a,b);
        }

        [MethodImpl(Inline)]
        static bit gteq_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.gteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(ushort))
                return math.gteq(convert<T,uint>(a), convert<T,uint>(b));
            else if(typeof(T) == typeof(uint))
                return math.gteq(uint32(a), uint32(b));
            else if(typeof(T) == typeof(ulong))
                return math.gteq(uint64(a), uint64(b));
            else
                return gteq_i(a,b);
        }

        [MethodImpl(Inline)]
        static bit gteq_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.gteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(short))
                return math.gteq(convert<T,int>(a), convert<T,int>(b));
            else if(typeof(T) == typeof(int))
                 return math.gteq(int32(a), int32(b));
            else if(typeof(T) == typeof(long))
                 return math.gteq(int64(a), int64(b));
            else
                return gfp.gteq(a,b);
        }
    }
}