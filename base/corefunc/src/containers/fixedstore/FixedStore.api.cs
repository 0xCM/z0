//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static zfunc;
    using static As;
    using static AsIn;
    using static FixedContainers;

    public static class FixedStore
    {
        /// <summary>
        /// Allocates 128 bits = 16 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed128 alloc(N128 n)
            => default;

        /// <summary>
        /// Allocates 256 bits = 32 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed256 alloc(N256 n)
            => default;

        /// <summary>
        /// Allocates 512 bits = 64 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed512 alloc(N512 n)
            => default;

        /// <summary>
        /// Allocates 1024 bits = 128 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed1024 alloc(N1024 n)
            => default;

        /// <summary>
        /// Allocates 2048 bits = 256 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed2048 alloc(N2048 n)
            => default;

        /// <summary>
        /// Allocates 4096 bits = 512 bytes of fixed storage
        /// </summary>
        /// <param name="n">The width selector</param>
        [MethodImpl(Inline)]
        public static Fixed4096 alloc(N4096 n)
            => default;

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed128 src)
            => BitConvert.GetBytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed256 src)
            => BitConvert.GetBytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed512 src)
            => BitConvert.GetBytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed1024 src)
            => BitConvert.GetBytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed2048 src)
            => BitConvert.GetBytes(src);

        /// <summary>
        /// Presents fixed storage as a bytespan
        /// </summary>
        /// <param name="src">The storage block</param>
        [MethodImpl(Inline)]
        public static Span<byte> bytes(in Fixed4096 src)
            => BitConvert.GetBytes(src);
 
        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed128 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed256 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed512 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed1024 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed2048 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Returns a generic reference to the leading storage cell of a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T head<T>(ref Fixed4096 src)
            where T : unmanaged
                => ref Unsafe.As<ulong,T>(ref head64(ref src));

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed128 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed256 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed512 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed1024 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed2048 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);

        /// <summary>
        /// Gets or sets a cell value within a fixed storage block
        /// </summary>
        /// <param name="src">The storage block</param>
        /// <param name="index">The 0-based type-relative cell index</param>
        /// <typeparam name="T">The reference cell type</typeparam>
        [MethodImpl(Inline)]
        public static ref T cell<T>(ref Fixed4096 src, int index)
            where T : unmanaged
                => ref Unsafe.Add(ref head<T>(ref src), index);
        
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

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed128 src)
            => ref src.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed256 src)
            => ref src.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed512 src)
            => ref src.X0.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed1024 src)
            => ref src.X0.X0.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed2048 src)
            => ref src.X0.X0.X0.X0.X0;

        [MethodImpl(Inline)]
        static ref ulong head64(ref Fixed4096 src)
            => ref src.X0.X0.X0.X0.X0.X0;

    }

}