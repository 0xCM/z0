//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
        
    using static Root;    

    partial class gmath
    {
        /// <summary>
        /// Computes the bitwise and c := a & b for primal operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline), And, NumericClosures(NumericKind.Integers)]
        public static T and<T>(T a, T b)
            where T : unmanaged
                => and_u(a,b);

        [MethodImpl(Inline)]
        static T and_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return convert<T>(math.and(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(ushort))
                return convert<T>(math.and(convert<T,uint>(a), convert<T,uint>(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.and(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.and(uint64(a), uint64(b)));
            else
                return and_i(a,b);
        }

        [MethodImpl(Inline)]
        static T and_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return convert<T>(math.and(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(short))
                return convert<T>(math.and(convert<T,int>(a), convert<T,int>(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.and(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.and(int64(a), int64(b)));
            else
                throw unsupported<T>();
        }
    }
}