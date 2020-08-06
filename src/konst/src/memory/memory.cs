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
    public unsafe partial class memory
    {
        [MethodImpl(Inline), Op]
        public static void copy(in byte src, uint count, ref byte dst, ref uint index)
        {
            for(var j=0u; j<count; j++)
                z.seek(dst, index++) = z.skip(src, j);
        }

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<T> edit<T>(MemoryAddress src, uint count)
            => z.cover(src.Ref<T>(), count);

        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe Span<byte> edit(MemoryAddress src, ByteSize size)
            => z.cover(src.Ref<byte>(), size);
                    
        /// <summary>
        /// Copies a specified number of source values to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="srcCount">The number of source values to copy</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static void copy<S,T>(in S src, ref T dst, int srcCount, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged  
                => sys.copy(z.view<S,byte>(src), ref edit<T,byte>(add(dst, dstOffset)), (uint)srcCount);

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
    }
}