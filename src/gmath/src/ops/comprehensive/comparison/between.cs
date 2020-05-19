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
        /// <summary>
        /// Defines the test between:bit := (x >= min) && (x <= max)
        /// </summary>
        /// <param name="src">The test value</param>
        /// <param name="min">The lower bound</param>
        /// <param name="max">The uppper bound</param>
        [MethodImpl(Inline), Between, Closures(Integers)]
        public static bit between<T>(T src, T min, T max)
            where T : unmanaged
                => between_u(src,min,max);

        [MethodImpl(Inline)]
        static bit between_u<T>(T x, T min, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.between(convert<T,uint>(x), convert<T,uint>(min), convert<T,uint>(max));
            else if(typeof(T) == typeof(ushort))
                return math.between(convert<T,uint>(x), convert<T,uint>(min), convert<T,uint>(max));
            else if(typeof(T) == typeof(uint))
                return math.between(uint32(x), uint32(min), uint32(max));
            else if(typeof(T) == typeof(ulong))
                return math.between(uint64(x), uint64(min), uint64(max));
            else
                return between_i(x,min,max);
        }

        [MethodImpl(Inline)]
        static bit between_i<T>(T x, T min, T max)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.between(convert<T,int>(x), convert<T,int>(min), convert<T,int>(max));
            else if(typeof(T) == typeof(short))
                return math.between(convert<T,int>(x), convert<T,int>(min), convert<T,int>(max));
            else if(typeof(T) == typeof(int))
                return math.between(int32(x), int32(min), int32(max));
            else if(typeof(T) == typeof(long))
                return math.between(int64(x), int64(min), int64(max));
            else
                return gfp.between(x,min,max);
        }
    }
}