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
    using static AsIn;


    partial class gmath
    {
        /// <summary>
        /// Computes the bitwise and c := a & b for primal operands a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <typeparam name="T">The primal operand type</typeparam>
        [MethodImpl(Inline)]
        public static T and<T>(T a, T b)
            where T : unmanaged
                => and_u(a,b);

        [MethodImpl(Inline)]
        static T and_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.and(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.and(uint16(a), uint16(b)));
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
                 return generic<T>(math.and(int8(a), int8(b)));
            else if(typeof(T) == typeof(short))
                 return generic<T>(math.and(int16(a), int16(b)));
            else if(typeof(T) == typeof(int))
                 return generic<T>(math.and(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                 return generic<T>(math.and(int64(a), int64(b)));
            else
                return gfp.and(a,b);
        }

    }
}