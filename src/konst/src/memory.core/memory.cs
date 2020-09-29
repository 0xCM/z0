//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost]
    public unsafe class memory
    {
        [MethodImpl(Inline)]
        public static MemorySlots<E> slots<E>(Type src)
            where E : unmanaged, Enum
                => new MemorySlots<E>(slots(src));

        [MethodImpl(Inline)]
        public static MemorySlots<E> slots<E>(params SegRef[] src)
            where E : unmanaged, Enum
                => new MemorySlots<E>(src);

        [MethodImpl(Inline), Op]
        public static MemorySlots slots(Type src)
            => ApiDynamic.jit(src).Map(m => new SegRef(m.Address, m.Size));

        public static MemorySlots<E> slots<E,T>(T src)
            where E : unmanaged, Enum
                => slots<E>(typeof(T));


        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<T> @ref<T>(in T src, uint size)
            => new Ref<T>(new Ref(z.address(src), size));

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static Ref<byte> @ref(ReadOnlySpan<byte> src)
            => new Ref<byte>(new Ref(z.address(src), (uint)src.Length));

        [MethodImpl(Inline), Op]
        public static void copy(in byte src, uint count, ref byte dst, ref uint index)
        {
            for(var j=0u; j<count; j++)
                z.seek(dst, index++) = z.skip(src, j);
        }

        /// <summary>
        /// Copies a specified number of source values to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="count">The number of source cells to copy</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static ref T copy<S,T>(in S src, ref T dst, int count, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            sys.copy(z.view<S,byte>(src), ref edit<T,byte>(add(dst, dstOffset)), (uint)count);
            return ref dst;
        }

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(T* pSrc, Span<T> dst, int offset, uint srcCount)
            where T : unmanaged
                => Copier.copy(pSrc, dst, offset, srcCount);

        /// <summary>
        /// Copies a contiguous segments of bytes from a source location to a target span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="dst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op]
        public static unsafe void copy(byte* pSrc, Span<byte> dst, int offset, uint srcCount)
            => Copier.copy(pSrc, dst, offset, srcCount);

        /// <summary>
        /// Copies a byte
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte read8(in byte src)
            => *(byte*)gptr(in src);

        /// <summary>
        /// Projects a source byte onto a byte reference
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte store8(byte src, ref byte dst)
        {
            *(gptr(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read(W64 w, in byte src)
            => *(ulong*)gptr(in src);

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(ulong src, ref byte dst)
        {
             *(gptr<ulong>(dst)) = src;
             return ref dst;
        }
    }
}