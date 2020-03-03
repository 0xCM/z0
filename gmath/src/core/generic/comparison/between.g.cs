//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    
    using static As;

    partial class gmath
    {
        [MethodImpl(Inline)]
        public static S add<S,T>(S lhs, S rhs)
            where S : struct, IInterval<S,T>
            where T : unmanaged
            => lhs.WithEndpoints(gmath.add(lhs.Left, rhs.Left), gmath.add(lhs.Right, rhs.Right));

        [MethodImpl(Inline)]
        public static S sub<S,T>(S lhs, S rhs)
            where S : struct, IInterval<S,T>
            where T : unmanaged
                => lhs.WithEndpoints(gmath.sub(lhs.Left, rhs.Left), gmath.sub(lhs.Right, rhs.Right));

        /// <summary>
        /// Creates the same kind of interval with alternate endpoints
        /// </summary>
        /// <param name="left">The left endpoint</param>
        /// <param name="right">The right endpoint</param>
        [MethodImpl(Inline)]
        static S WithEndpoints<S,T>(this S src, T left, T right)
            where S : struct, IInterval<S,T>
            where T : unmanaged
                => default(S).New(left, right, src.Kind);

        /// <summary>
        /// Returns true if the the test value lies in the closed interval formed by supplied lower and upper bounds
        /// </summary>
        /// <param name="x">The test value</param>
        /// <param name="a">The lower bound</param>
        /// <param name="b">The uppper bound</param>
        [MethodImpl(Inline), Op, NumericClosures(NumericKind.Integers)]
        public static bit between<T>(T x, T min, T max)
            where T : unmanaged
                => between_u(x,min,max);

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