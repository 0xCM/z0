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
    using static As;

    partial struct V0
    {
        /// <summary>
        /// Stores the source vector to a reference cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target reference</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vsave<T>(Vector128<T> src, ref T dst, int offset)
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
        public static void vsave<T>(Vector256<T> src, ref T dst, int offset)
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

        [MethodImpl(Inline)]
        public static void vsave<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
                => vsave_u(src, ref dst);

        [MethodImpl(Inline)]
        public static void vsave<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
                => vsave_u(src, ref dst);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void vsave<T>(Vector512<T> src, ref T dst, int offset = 0)
            where T : unmanaged
        {
            vsave(src.Lo, ref dst, offset);
            vsave(src.Hi, ref dst, offset + V0.vcount<T>(Typed.w256));
        }

        [MethodImpl(Inline)]
        static unsafe void vsave_u<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                V0d.vsave(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                V0d.vsave(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                V0d.vsave(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                V0d.vsave(v64u(src), ref uint64(ref dst));
            else
                 vsave_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vsave_i<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                V0d.vsave(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                V0d.vsave(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                V0d.vsave(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                V0d.vsave(v64i(src), ref int64(ref dst));
            else
                vsave_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vsave_f<T>(Vector128<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                V0d.vsave(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                V0d.vsave(v64f(src), ref float64(ref dst));
            else 
                throw Unsupported.define<T>();                
        }

        [MethodImpl(Inline)]
        static unsafe void vsave_u<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                V0d.vsave(v8u(src), ref uint8(ref dst));
            else if(typeof(T) == typeof(ushort))
                V0d.vsave(v16u(src), ref uint16(ref dst));
            else if(typeof(T) == typeof(uint))
                V0d.vsave(v32u(src), ref uint32(ref dst));
            else if(typeof(T) == typeof(ulong))
                V0d.vsave(v64u(src), ref uint64(ref dst));
            else
                 vsave_i(src,ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vsave_i<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                V0d.vsave(v8i(src), ref int8(ref dst));
            else if(typeof(T) == typeof(short))
                V0d.vsave(v16i(src), ref int16(ref dst));
            else if(typeof(T) == typeof(int))
                V0d.vsave(v32i(src), ref int32(ref dst));
            else if(typeof(T) == typeof(long))
                V0d.vsave(v64i(src), ref int64(ref dst));
            else
                vsave_f(src, ref dst);
        }

        [MethodImpl(Inline)]
        static unsafe void vsave_f<T>(Vector256<T> src, ref T dst)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                V0d.vsave(v32f(src), ref float32(ref dst));
            else if(typeof(T) == typeof(double))
                V0d.vsave(v64f(src), ref float64(ref dst));
            else 
                throw Unsupported.define<T>();                
        }

        [MethodImpl(Inline)]
        static void vsave128_u<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                V0d.vsave(v8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                V0d.vsave(v16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                V0d.vsave(v32u(src), ref uint32(ref dst), offset);
            else
                V0d.vsave(v64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave128_i<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                V0d.vsave(v8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                V0d.vsave(v16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                V0d.vsave(v32i(src), ref int32(ref dst), offset);
            else
                V0d.vsave(v64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave128_f<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                V0d.vsave(v32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                V0d.vsave(v64f(src), ref float64(ref dst), offset);
            else 
                throw Unsupported.define<T>();                
        }

        [MethodImpl(Inline)]
        static void vsave256_u<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                V0d.vsave(v8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                V0d.vsave(v16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                V0d.vsave(v32u(src), ref uint32(ref dst), offset);
            else
                V0d.vsave(v64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave256_i<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                V0d.vsave(v8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                V0d.vsave(v16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                V0d.vsave(v32i(src), ref int32(ref dst), offset);
            else
                V0d.vsave(v64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vsave256_f<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                V0d.vsave(v32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                V0d.vsave(v64f(src), ref float64(ref dst), offset);
            else 
                throw Unsupported.define<T>();                
        }
    }
}