//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.Intrinsics;

    using static Konst;
    using static z;

    partial class gvec
    {
        /// <summary>
        /// A register-based shift (as opposed to immediate-based) that shifts each source vector component rightwards
        /// by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vsrlr<T>(Vector128<T> x, Vector128<T> count)
            where T : unmanaged
                => vsrlr_u(x,count);

        /// <summary>
        /// A register-based shift (as opposed to immediate-based) that shifts each source vector component rightwards
        /// by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vsrlr<T>(Vector256<T> x, Vector256<T> count)
            where T : unmanaged
                => vsrlr_u(x,count);

        /// <summary>
        /// Shifts each source vector component rightwards by a specified offset via the register-based shift-right instruction
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector128<T> vsrlr<T>(Vector128<T> x, T count)
            where T : unmanaged
                => vsrlr_u(x,count);

        /// <summary>
        /// Shifts each source vector component rightwards by a specified offset via the register-based shift-right instruction
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="count">The offset amount</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static Vector256<T> vsrlr<T>(Vector256<T> x, T count)
            where T : unmanaged
                => vsrlr_u(x,count);

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_u<T>(Vector128<T> x, Vector128<T> count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsrlr(v8u(x), v8u(count)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsrlr(v16u(x), v16u(count)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsrlr(v32u(x), v32u(count)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsrlr(v64u(x), v64u(count)));
            else
                return vsrlr_i(x,count);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_i<T>(Vector128<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsrlr(v8i(x), v8i(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsrlr(v16i(x), v16i(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsrlr(v32i(x), v32i(offset)));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsrlr(v64i(x), v64i(offset)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_u<T>(Vector128<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsrlr(v8u(x), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsrlr(v16u(x), uint16(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsrlr(v32u(x), uint32(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsrlr(v64u(x), uint64(offset)));
            else
                return vsrlr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsrlr_i<T>(Vector128<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsrlr(v8i(x), int8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsrlr(v16i(x), int16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsrlr(v32i(x), int32(offset)));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsrlr(v64i(x), int64(offset)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_u<T>(Vector256<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsrlr(v8u(x), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsrlr(v16u(x), uint16(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsrlr(v32u(x), uint32(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsrlr(v64u(x), uint64(offset)));
            else
                return vsrlr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_i<T>(Vector256<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsrlr(v8i(x), int8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsrlr(v16i(x), int16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsrlr(v32i(x), int32(offset)));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsrlr(v64i(x), int64(offset)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_u<T>(Vector256<T> x, Vector256<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(cpu.vsrlr(v8u(x), v8u(gcpu.vlo(offset))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(cpu.vsrlr(v16u(x), v16u(gcpu.vlo(offset))));
            else if(typeof(T) == typeof(uint))
                return generic<T>(cpu.vsrlr(v32u(x), v32u(gcpu.vlo(offset))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(cpu.vsrlr(v64u(x), v64u(gcpu.vlo(offset))));
            else
                return vsrlr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsrlr_i<T>(Vector256<T> x, Vector256<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(cpu.vsrlr(v8i(x), v8i(gcpu.vlo(offset))));
            else if(typeof(T) == typeof(short))
                return generic<T>(cpu.vsrlr(v16i(x), v16i(gcpu.vlo(offset))));
            else if(typeof(T) == typeof(int))
                return generic<T>(cpu.vsrlr(v32i(x), v32i(gcpu.vlo(offset))));
            else if(typeof(T) == typeof(long))
                return generic<T>(cpu.vsrlr(v64i(x), v64i(gcpu.vlo(offset))));
            else
                throw no<T>();
        }
    }
}