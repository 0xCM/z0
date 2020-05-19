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
        /// Defines the test gt:bit := a > b, succeeding if the left operand is larger than the right operand
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The operand type</typeparam>
        [MethodImpl(Inline), Gt, Closures(Integers)]
        public static bit gt<T>(T a, T b)
            where T : unmanaged
                => gt_u(a,b);

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
    }
}