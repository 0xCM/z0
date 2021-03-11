//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static memory;
    using static Part;

    partial struct ClrPrimitives
    {
        /// <summary>
        /// Determines equality for unmanaged primitive values
        /// </summary>
        /// <param name="a">The first operand</param>
        /// <param name="b">The second operand</param>
        /// <typeparam name="T">The numeric type</typeparam>
        [MethodImpl(Inline), Eq, Closures(AllNumeric)]
        public static bit eq<T>(T a, T b)
            where T : unmanaged
                => eq_1(a,b);

        [MethodImpl(Inline)]
        static bit eq_1<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return uint8(a) == uint8(b);
            else if(typeof(T) == typeof(ushort))
                return uint16(a) == uint16(b);
            else if(typeof(T) == typeof(uint))
                return (uint32(a) == uint32(b));
            else if(typeof(T) == typeof(ulong))
                return (uint64(a) == uint64(b));
            else
                return eq_2(a,b);
        }

        [MethodImpl(Inline)]
        static bit eq_2<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                 return int8(a) == int8(b);
            else if(typeof(T) == typeof(short))
                 return int16(a) == int16(b);
            else if(typeof(T) == typeof(int))
                 return int32(a) == int32(b);
            else if(typeof(T) == typeof(long))
                 return int64(a) == int64(b);
             else
                return eq_3(a,b);
       }

        [MethodImpl(Inline)]
        static bit eq_3<T>(T a, T b)
            where T : unmanaged
        {
            if(typeof(T) == typeof(bool))
                 return @byte(a) == @byte(b);
            else if(typeof(T) == typeof(char))
                 return c16(a) == c16(b);
            else if(typeof(T) == typeof(float))
                 return float32(a) == float32(b);
            else if(typeof(T) == typeof(double))
                 return float64(a) == float64(b);
            else
                throw no<T>();
        }
    }
}