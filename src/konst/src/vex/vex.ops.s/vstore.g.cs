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

    partial struct gcpu
    {
        /// <summary>
        /// Stores the source vector to a reference cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target reference</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                vsave128_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                vsave128_i(src, ref dst, offset);
            else
                vsave128_f(src, ref dst, offset);
        }

        /// <summary>
        /// Stores the source vector to a reference cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target reference</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte)
            || typeof(T) == typeof(ushort)
            || typeof(T) == typeof(uint)
            || typeof(T) == typeof(ulong))
                vsave256_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte)
            || typeof(T) == typeof(short)
            || typeof(T) == typeof(int)
            || typeof(T) == typeof(long))
                vsave256_i(src, ref dst, offset);
            else
                vsave256_f(src, ref dst, offset);
        }

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vstore_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vstore_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector512<T> src, ref T dst, int offset = 0)
            where T : unmanaged
        {
            vstore(src.Lo, ref dst, offset);
            vstore(src.Hi, ref dst, offset + cpu.vcount<T>(w256));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vstore(v64u(src), ref uint64(ref dst));
            else
                 vstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vstore(v64i(src), ref int64(ref dst));
            else
                vstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vstore(v64u(src), ref uint64(ref dst));
            else
                 vstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vstore(v64i(src), ref int64(ref dst));
            else
                vstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static void vsave128_u<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst), offset);
            else
                cpu.vstore(v64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave128_i<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstore(v8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst), offset);
            else
                cpu.vsave(v64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave128_f<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst), offset);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static void vsave256_u<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst), offset);
            else
                cpu.vstore(v64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave256_i<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vsave(v8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst), offset);
            else
                cpu.vstore(v64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave256_f<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst), offset);
            else
                throw no<T>();
        }
    }

    partial struct z
    {

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vstore_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vstore_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vstore<T>(Vector512<T> src, ref T dst, int offset = 0)
            where T : unmanaged
        {
            gcpu.vstore(src.Lo, ref dst, offset);
            gcpu.vstore(src.Hi, ref dst, offset + cpu.vcount<T>(w256));
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vstore(v64u(src), ref uint64(ref dst));
            else
                 vstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vstore(v64i(src), ref int64(ref dst));
            else
                vstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                cpu.vstore(v64u(src), ref uint64(ref dst));
            else
                 vstore_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstore(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                cpu.vstore(v64i(src), ref int64(ref dst));
            else
                vstore_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vstore_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst));
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static void vsave128_u<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst), offset);
            else
                cpu.vstore(v64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave128_i<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vstore(v8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst), offset);
            else
                cpu.vsave(v64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave128_f<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst), offset);
            else
                throw no<T>();
        }

        [MethodImpl(Inline)]
        static void vsave256_u<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                cpu.vstore(v8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                cpu.vstore(v16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                cpu.vstore(v32u(src), ref uint32(ref dst), offset);
            else
                cpu.vstore(v64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave256_i<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                cpu.vsave(v8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                cpu.vstore(v16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                cpu.vstore(v32i(src), ref int32(ref dst), offset);
            else
                cpu.vstore(v64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave256_f<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                cpu.vstore(v32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                cpu.vstore(v64f(src), ref float64(ref dst), offset);
            else
                throw no<T>();
        }
    }
}