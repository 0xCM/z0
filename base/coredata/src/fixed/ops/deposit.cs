//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Runtime.Intrinsics;

    using static zfunc;
    
    partial class Fixed
    {
        /// <summary>
        /// Writes 128 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, ref Fixed128 dst)
            where S : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes a specified number of elements from the source to the target beginning at an element-relative offset
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, int count, ref Fixed128 dst, int offset)
            where S : unmanaged
                => store(src, count, ref dst, offset);

        /// <summary>
        /// Writes 128 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<T>(in Fixed128 src, ref T dst)
            where T : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes 256 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, ref Fixed256 dst)
            where S : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes a specified number of elements from the source to the target beginning at an element-relative offset
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, int count, ref Fixed256 dst, int offset)
            where S : unmanaged
                => store(src, count, ref dst, offset);

        /// <summary>
        /// Writes 256 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<T>(in Fixed256 src, ref T dst)
            where T : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes 512 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, ref Fixed512 dst)
            where S : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes a specified number of elements from the source to the target beginning at an element-relative offset
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, int count, ref Fixed512 dst, int offset)
            where S : unmanaged
                => store(src, count, ref dst, offset);

        /// <summary>
        /// Writes 512 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<T>(in Fixed512 src, ref T dst)
            where T : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes 1024 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, ref Fixed1024 dst)
            where S : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes a specified number of elements from the source to the target beginning at an element-relative offset
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, int count, ref Fixed1024 dst, int offset)
            where S : unmanaged
                => store(src, count, ref dst, offset);

        /// <summary>
        /// Writes 1024 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<T>(in Fixed1024 src, ref T dst)
            where T : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes 2048 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, ref Fixed2048 dst)
            where S : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes a specified number of elements from the source to the target beginning at an element-relative offset
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, int count, ref Fixed2048 dst, int offset)
            where S : unmanaged
                => store(src, count, ref dst, offset);

        /// <summary>
        /// Writes 2048 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<T>(in Fixed2048 src, ref T dst)
            where T : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes 4096 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, ref Fixed4096 dst)
            where S : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes a specified number of elements from the source to the target beginning at an element-relative offset
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="count">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <param name="offset">The element-relative offset into the target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<S>(in S src, int count, ref Fixed4096 dst, int offset)
            where S : unmanaged
                => store(src, count, ref dst, offset);

        /// <summary>
        /// Writes 4096 source bits to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static unsafe void deposit<T>(in Fixed4096 src, ref T dst)
            where T : unmanaged
                => store(src, ref dst);

        /// <summary>
        /// Writes a specified number of elements from the source to the target, beginning at a source-relative offset
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="src">The number of source elements to write</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The source cell type</typeparam>
        [MethodImpl(Inline)]
        static unsafe void store<S,T>(in S src, int count, ref T dst, int offset)            
            where S : unmanaged
            where T : unmanaged
                => store(src, sizeof(S) * count, ref Unsafe.Add(ref Unsafe.As<T,byte>(ref dst), sizeof(S) * offset));

        /// <summary>
        /// Writes source data to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        static unsafe void store<S,T>(in S src, ref T dst)
            where S : unmanaged
            where T : unmanaged
        {
            ref var dstBytes = ref Unsafe.As<T,byte>(ref dst);
            ref var srcBytes = ref Unsafe.As<S,byte>(ref Unsafe.AsRef(in src));            
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)sizeof(T));
        }

        [MethodImpl(Inline)]
        static unsafe void store<S,T>(in S src, int bytecount, ref T dst)
            where S : unmanaged
            where T : unmanaged
        {
            ref var dstBytes = ref Unsafe.As<T,byte>(ref dst);
            ref var srcBytes = ref Unsafe.As<S,byte>(ref Unsafe.AsRef(in src));            
            Unsafe.CopyBlockUnaligned(ref dstBytes, ref srcBytes, (uint)bytecount);
        }
    }
}
