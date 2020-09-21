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
        public static void copy<S,T>(in S src, ref T dst, int count, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
                => sys.copy(z.view<S,byte>(src), ref edit<T,byte>(add(dst, dstOffset)), (uint)count);

        [MethodImpl(Inline), Op, Closures(AllNumeric)]
        public static void copy<T>(in T src, uint count, ref T dst, ref uint index)
        {
            for(var j=0u; j<count; j++)
                z.seek(dst, index++) = z.skip(src, j);
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
        /// Reads 16 bits from a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort read16(in byte src)
            => *(ushort*)gptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read32(in byte src)
            => *(uint*)gptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read32(in ushort src)
            => *(uint*)gptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read64(in byte src)
            => *(ulong*)gptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read64(in ushort src)
            => *gptr<ulong>(src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read64(in uint src)
            => *gptr<ulong>(src);

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
        /// Projects 16 source bits onto a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte store16(ushort src, ref byte dst)
        {
            *(gptr<ushort>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte store32(uint src, ref byte dst)
        {
             *(gptr<uint>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort store32(uint src, ref ushort dst)
        {
            *(gptr<uint>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte store64(ulong src, ref byte dst)
        {
             *(gptr<ulong>(dst)) = src;
             return ref dst;
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort store64(ulong src, ref ushort dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint store64(ulong src, ref uint dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
        }


        /// <summary>
        /// Copies a byte
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte read(W8 w, in byte src)
            => *(byte*)gptr(in src);

        /// <summary>
        /// Reads 16 bits from a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort read(W16 w, in byte src)
            => *(ushort*)gptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read(W32 w, in byte src)
            => *(uint*)gptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read(W32 w, in ushort src)
            => *(uint*)gptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read(W64 w, in byte src)
            => *(ulong*)gptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="w">The target width selector</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read(W16 w, in ushort src)
            => *gptr<ulong>(src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="w">The target width selector</param>
        /// <param name="src">The data source</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read(W32 w, in uint src)
            => *gptr<ulong>(src);

        /// <summary>
        /// Reads 16 bits from a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort read(in byte src, out ushort dst)
        {
            dst = *(ushort*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint read(W32 w, in byte src, out uint dst)
        {
            dst = *(uint*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint read(in ushort src, out uint dst)
        {
            dst = *(uint*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>

        [MethodImpl(Inline), Op]
        public static unsafe ref ulong read(in byte src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ulong read(in ushort src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The data source</param>
         /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ulong read(in uint src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }


        /// <summary>
        /// Projects a source byte onto a byte reference
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(byte src, ref byte dst)
        {
            *(gptr(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 16 source bits onto a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(ushort src, ref byte dst)
        {
            *(gptr<ushort>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte write(uint src, ref byte dst)
        {
             *(gptr<uint>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort write(uint src, ref ushort dst)
        {
            *(gptr<uint>(dst)) = src;
            return ref dst;
        }

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

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort write(ulong src, ref ushort dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint write(ulong src, ref uint dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
        }
    }
}