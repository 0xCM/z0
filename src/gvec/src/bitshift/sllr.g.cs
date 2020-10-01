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
        /// <param name="offset">The offset vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Sll, Closures(Integers)]
        public static Vector128<T> vsllr<T>(Vector128<T> x, Vector128<T> offset)
            where T : unmanaged
                => vsllr_u(x,offset);

        /// <summary>
        /// A register-based shift (as opposed to immediate-based) that shifts each source vector component rightwards
        /// by an amount specified in the first component of the offset vector
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset vector</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Sll, Closures(Integers)]
        public static Vector256<T> vsllr<T>(Vector256<T> x, Vector256<T> offset)
            where T : unmanaged
                => vsllr_u(x,offset);

        /// <summary>
        /// Shifts each source vector component rightwards by a specified offset via the register-based shift-right instruction
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Sll, Closures(Integers)]
        public static Vector128<T> vsllr<T>(Vector128<T> x, T offset)
            where T : unmanaged
                => vsllr_u(x,offset);

        /// <summary>
        /// Shifts each source vector component rightwards by a specified offset via the register-based shift-right instruction
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="offset">The offset amount</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Sll, Closures(Integers)]
        public static Vector256<T> vsllr<T>(Vector256<T> x, T offset)
            where T : unmanaged
                => vsllr_u(x,offset);

        [MethodImpl(Inline)]
        static Vector128<T> vsllr_u<T>(Vector128<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(z.vsllr(v8u(x), v8u(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(z.vsllr(v16u(x), v16u(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(z.vsllr(v32u(x), v32u(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(z.vsllr(v64u(x), v64u(offset)));
            else
                return vsllr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsllr_i<T>(Vector128<T> x, Vector128<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(z.vsllr(v8i(x), v8i(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>(z.vsllr(v16i(x), v16i(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(z.vsllr(v32i(x), v32i(offset)));
            else if(typeof(T) == typeof(long))
                return generic<T>(z.vsllr(v64i(x), v64i(offset)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsllr_u<T>(Vector128<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(z.vsllr(v8u(x), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(z.vsllr(v16u(x), uint16(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(z.vsllr(v32u(x), uint32(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(z.vsllr(v64u(x), uint64(offset)));
            else
                return vsllr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector128<T> vsllr_i<T>(Vector128<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(z.vsllr(v8i(x), int8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>(z.vsllr(v16i(x), int16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(z.vsllr(v32i(x), int32(offset)));
            else if(typeof(T) == typeof(long))
                return generic<T>(z.vsllr(v64i(x), int64(offset)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsllr_u<T>(Vector256<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(z.vsllr(v8u(x), uint8(offset)));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(z.vsllr(v16u(x), uint16(offset)));
            else if(typeof(T) == typeof(uint))
                return generic<T>(z.vsllr(v32u(x), uint32(offset)));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(z.vsllr(v64u(x), uint64(offset)));
            else
                return vsllr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsllr_i<T>(Vector256<T> x, T offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(z.vsllr(v8i(x), int8(offset)));
            else if(typeof(T) == typeof(short))
                return generic<T>(z.vsllr(v16i(x), int16(offset)));
            else if(typeof(T) == typeof(int))
                return generic<T>(z.vsllr(v32i(x), int32(offset)));
            else if(typeof(T) == typeof(long))
                return generic<T>(z.vsllr(v64i(x), int64(offset)));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsllr_u<T>(Vector256<T> x, Vector256<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(z.vsllr(v8u(x), v8u(vlo(offset))));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(z.vsllr(v16u(x), v16u(vlo(offset))));
            else if(typeof(T) == typeof(uint))
                return generic<T>(z.vsllr(v32u(x), v32u(vlo(offset))));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(z.vsllr(v64u(x), v64u(vlo(offset))));
            else
                return vsllr_i(x,offset);
        }

        [MethodImpl(Inline)]
        static Vector256<T> vsllr_i<T>(Vector256<T> x, Vector256<T> offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(z.vsllr(v8i(x), v8i(vlo(offset))));
            else if(typeof(T) == typeof(short))
                return generic<T>(z.vsllr(v16i(x), v16i(vlo(offset))));
            else if(typeof(T) == typeof(int))
                return generic<T>(z.vsllr(v32i(x), v32i(vlo(offset))));
            else if(typeof(T) == typeof(long))
                return generic<T>(z.vsllr(v64i(x), v64i(vlo(offset))));
            else
                throw no<T>();
        }
    }
}