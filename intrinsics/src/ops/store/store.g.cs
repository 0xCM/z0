//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;    
    using System.Runtime.Intrinsics;    

    using static zfunc;    
    using static As;    

    partial class ginx
    {
        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector128<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged
                => vstore(src, ref head(dst), offset);

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector256<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged
                => vstore(src, ref head(dst), offset);

        /// <summary>
        /// Stores vector content to a span
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="offset">The target offset at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector512<T> src, Span<T> dst, int offset = 0)
            where T : unmanaged
                => vstore(src, ref head(dst), offset);

        /// <summary>
        /// Stores the source vector to the head of a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector128<T> src, in Block128<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector cell type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector128<T> src, in Block128<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector256<T> src, in Block256<T> dst)
            where T : unmanaged
                => vstore(src, ref dst.Head);

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector256<T> src, in Block256<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a specified block in a blocked container
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target block</param>
        /// <param name="block">The 0-based block index at which storage should begin</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector512<T> src, in Block512<T> dst, int block)
            where T : unmanaged
                => vstore(src, ref dst.BlockRef(block));

        /// <summary>
        /// Stores the source vector to a reference cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target reference</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector128<T> src, ref T dst, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore128_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore128_i(src, ref dst, offset);
            else 
                vstore128_f(src, ref dst, offset);
        }

        /// <summary>
        /// Stores the source vector to a reference cell
        /// </summary>
        /// <param name="src">The source vector</param>
        /// <param name="dst">The target reference</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="T">The vector component type</typeparam>
        [MethodImpl(Inline)]
        public static void vstore<T>(Vector256<T> src, ref T dst, int offset = 0)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte) 
            || typeof(T) == typeof(ushort) 
            || typeof(T) == typeof(uint) 
            || typeof(T) == typeof(ulong))
                vstore256_u(src, ref dst, offset);
            else if(typeof(T) == typeof(sbyte) 
            || typeof(T) == typeof(short) 
            || typeof(T) == typeof(int) 
            || typeof(T) == typeof(long))
                vstore256_i(src, ref dst, offset);
            else 
                vstore256_f(src, ref dst, offset);
        }

        [MethodImpl(Inline)]
        public static void vstore<T>(Vector512<T> src, ref T dst, int offset = 0)
            where T : unmanaged
        {
            vstore(src.Lo, ref dst, offset);
            vstore(src.Hi, ref dst, offset + CpuVector.count<T>(n256));
        }

        [MethodImpl(Inline)]
        static void vstore128_u<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dinx.vstore(vcast8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                dinx.vstore(vcast16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                dinx.vstore(vcast32u(src), ref uint32(ref dst), offset);
            else
                dinx.vstore(vcast64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore128_i<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dinx.vstore(vcast8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                dinx.vstore(vcast16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                dinx.vstore(vcast32i(src), ref int32(ref dst), offset);
            else
                dinx.vstore(vcast64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore128_f<T>(Vector128<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                dinx.vstore(vcast32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                dinx.vstore(vcast64f(src), ref float64(ref dst), offset);
            else 
                throw unsupported<T>();                
        }

        [MethodImpl(Inline)]
        static void vstore256_u<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                dinx.vstore(vcast8u(src), ref uint8(ref dst), offset);
            else if(typeof(T) == typeof(ushort))
                dinx.vstore(vcast16u(src), ref uint16(ref dst), offset);
            else if(typeof(T) == typeof(uint))
                dinx.vstore(vcast32u(src), ref uint32(ref dst), offset);
            else
                dinx.vstore(vcast64u(src), ref uint64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore256_i<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                dinx.vstore(vcast8i(src), ref int8(ref dst), offset);
            else if(typeof(T) == typeof(short))
                dinx.vstore(vcast16i(src), ref int16(ref dst), offset);
            else if(typeof(T) == typeof(int))
                dinx.vstore(vcast32i(src), ref int32(ref dst), offset);
            else
                dinx.vstore(vcast64i(src), ref int64(ref dst), offset);
        }

        [MethodImpl(Inline)]
        static void vstore256_f<T>(Vector256<T> src, ref T dst, int offset)
            where T : unmanaged
        {
            if(typeof(T) == typeof(float))
                dinx.vstore(vcast32f(src), ref float32(ref dst), offset);
            else if(typeof(T) == typeof(double))
                dinx.vstore(vcast64f(src), ref float64(ref dst), offset);
            else 
                throw unsupported<T>();                
        }

    }
}