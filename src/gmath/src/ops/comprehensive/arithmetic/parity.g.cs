//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static As;

    partial class gmath
    {
        /// <summary>
        /// Returns true if a primal integer is odd; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Bit32 odd<T>(T a)
            where T : unmanaged
                => odd_u(a);

        /// <summary>
        /// Returns true if a primal integer is even; false otherwise
        /// </summary>
        /// <param name="a">The value to test</param>
        /// <typeparam name="T">The primal integer type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Bit32 even<T>(T a)
            where T : unmanaged
                => even_u(a);

        [MethodImpl(Inline)]
        static Bit32 odd_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.odd(uint8(a));
            else if(typeof(T) == typeof(ushort))
                return math.odd(uint16(a));
            else if(typeof(T) == typeof(uint))
                return math.odd(uint32(a));
            else if(typeof(T) == typeof(ulong))
                return math.odd(uint64(a));
            else
                return odd_i(a);
        }

        [MethodImpl(Inline)]
        static Bit32 odd_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.odd(int8(a));
            else if(typeof(T) == typeof(short))
                return math.odd(int16(a));
            else if(typeof(T) == typeof(int))
                return math.odd(int32(a));
            else if(typeof(T) == typeof(long))
                return math.odd(int64(a));
            else
                throw Unsupported.define<T>();
        }

        [MethodImpl(Inline)]
        static Bit32 even_u<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return math.even(uint8(a));
            else if(typeof(T) == typeof(ushort))
                return math.even(uint16(a));
            else if(typeof(T) == typeof(uint))
                return math.even(uint32(a));
            else if(typeof(T) == typeof(ulong))
                return math.even(uint64(a));
            else
                return even_i(a);
        }

        [MethodImpl(Inline)]
        static Bit32 even_i<T>(T a)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return math.even(int8(a));
            else if(typeof(T) == typeof(short))
                return math.even(int16(a));
            else if(typeof(T) == typeof(int))
                return math.even(int32(a));
            else if(typeof(T) == typeof(long))
                return math.even(int64(a));
            else
                throw Unsupported.define<T>();
        }
    }
}