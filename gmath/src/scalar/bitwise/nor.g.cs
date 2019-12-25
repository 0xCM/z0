//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
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
        /// Computes the bitwise nor c := ~(a | b) for unsigned integers a and b
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        [MethodImpl(Inline)]
        public static T nor<T>(T a, T b)
            where T : unmanaged
                => nor_u(a,b);

        [MethodImpl(Inline)]
        static T nor_u<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(math.nor(uint8(a), uint8(b)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(math.nor(uint16(a), uint16(b)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(math.nor(uint32(a), uint32(b)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(math.nor(uint64(a), uint64(b)));
            else
                return nor_i(a,b);
        }

        [MethodImpl(Inline)]
        static T nor_i<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(math.nor(int8(a), int8(b)));
            else if(typeof(T) == typeof(short))
                return generic<T>(math.nor(int16(a), int16(b)));
            else if(typeof(T) == typeof(int))
                return generic<T>(math.nor(int32(a), int32(b)));
            else if(typeof(T) == typeof(long))
                return generic<T>(math.nor(int64(a), int64(b)));
            else
                throw unsupported<T>();
        }
    }
}