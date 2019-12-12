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

    partial class gmath
    {
        /// <summary>
        /// Returns true if the difference between two operands is within a specified tolerance
        /// </summary>
        /// <param name="a">The left operand</param>
        /// <param name="b">The right operand</param>
        /// <param name="tolerance">The tolerance</param>
        /// <typeparam name="T">The primal type</typeparam>
        [MethodImpl(Inline)]
        public static bit within<T>(T a, T b, T tolerance)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                return within_u(a,b,tolerance);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                return within_i(a,b,tolerance);
            else
                return within_f(a,b,tolerance);
        }

        [MethodImpl(Inline)]
        static bit within_i<T>(T a, T b, T tolerance)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.within(int8(a), int8(b), int8(tolerance));
            else if(typeof(T) == typeof(short))
                return math.within(int16(a), int16(b), int16(tolerance));
            else if(typeof(T) == typeof(int))
                return math.within(int32(a), int32(b), int32(tolerance));
            else 
                return math.within(int64(a), int64(b), int64(tolerance));

        }

        [MethodImpl(Inline)]
        static bit within_u<T>(T a, T b, T tolerance)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.within(uint8(a), uint8(b), uint8(tolerance));
            else if(typeof(T) == typeof(ushort))
                return math.within(uint16(a), uint16(b), uint16(tolerance));
            else if(typeof(T) == typeof(uint))
                return math.within(uint32(a), uint32(b), uint32(tolerance));
            else 
                return math.within(uint64(a), uint64(b), uint64(tolerance));
        }

        [MethodImpl(Inline)]
        static bit within_f<T>(T a, T b, T epsilon)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                return fmath.within(float32(a), float32(b), float32(epsilon));
            else if(typeof(T) == typeof(double))
                return fmath.within(float64(a), float64(b), float64(epsilon));
            else            
                throw unsupported<T>();

        }
    }
}