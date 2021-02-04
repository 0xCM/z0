//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Part;
    using static memory;

    partial struct gcpu
    {
        /// <summary>
        /// Shifts each source vector component leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vsll<T>(Vector128<T> x, [Imm] byte count)
            where T : unmanaged
            => vsll_u(x,count);

        /// <summary>
        /// Shifts each source vector component leftwards by a specified number of bits
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The shift offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vsll<T>(Vector256<T> x, [Imm] byte count)
            where T : unmanaged
            => vsll_u(x,count);

        [MethodImpl(Inline)]
        static Vector128<T> vsll_u<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsll(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsll(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsll(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsll(v64u(x), count));
            else
                return vsll_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsll_i<T>(Vector128<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsll(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsll(v16i(x), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsll(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsll(v64i(x), count));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_u<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsll(v8u(x), count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsll(v16u(x), count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsll(v32u(x), count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsll(v64u(x), count));
            else
                return vsll_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsll_i<T>(Vector256<T> x, byte count)
            where T : unmanaged
        {
             if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsll(v8i(x), count));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsll(v16i(x), count));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsll(v32i(x), count));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsll(v64i(x), count));
            else
                throw no<T>();
       }
    }
}