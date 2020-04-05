//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;    
    using System.Collections.Generic;
    using System.Buffers;

    using static Seed;
    using static refs;

    [ApiHost]
    public static unsafe class memory
    {
        /// <summary>
        /// Allocates an array
        /// </summary>
        /// <param name="length">The numer of array elements</param>
        /// <typeparam name="T">The cell type</typeparam>
        public static T[] alloc<T>(int length)
            => new T[length];

        /// <summary>
        /// Allocates a span
        /// </summary>
        /// <param name="length">The numer of array elements</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Span<T> span<T>(int length)
            => alloc<T>(length);

        /// <summary>
        /// Copies a specified number of source values to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        /// <param name="srcCount">The number of source values to copy</param>
        /// <param name="dst">The target reference</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(in S src, ref T dst, int srcCount, int dstOffset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input = ref Unsafe.As<S,byte>(ref Unsafe.AsRef(in src));
            ref var target = ref Unsafe.As<T,byte>(ref Unsafe.Add(ref dst, dstOffset));
            var srcBytes =  (uint)(srcCount*Unsafe.SizeOf<S>());
            Unsafe.CopyBlock(ref target, ref input, srcBytes);
            return srcBytes;
        }

        /// <summary>
        /// Copies data from an unmanaged value to a target span
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="dst">The target span</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]   
        public static void copy<S,T>(ref S src, Span<T> dst)
            where T : unmanaged
        {
            ref var dstBytes = ref Unsafe.As<T, byte>(ref refs.head(dst));
            Unsafe.WriteUnaligned<S>(ref dstBytes, src);
        }

        /// <summary>
        /// Copies a contiguous segments of bytes from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint srcCount)
            => Unsafe.CopyBlock(pDst, pSrc, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint srcCount)
            where T : unmanaged
                => Unsafe.CopyBlock(pDst, pSrc, (uint)(size<T>()*srcCount));

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(UnsignedInts)]
        public static unsafe void copy<T>(T* pSrc, Span<T> dst, int offset, uint srcCount)
            where T : unmanaged
                =>  copy(pSrc, refs.ptr(ref refs.head(dst), offset), srcCount); 

        /// <summary>
        /// Copies a contiguous segments of bytes from a source location to a target span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="dst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op]
        public static unsafe void copy(byte* pSrc, Span<byte> dst, int offset, uint srcCount)
            => copy(pSrc, (byte*)Unsafe.AsPointer(ref refs.seek(dst, offset)) , srcCount);

        /// <summary>
        /// Copies a byte
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe byte read8(in byte src)
            => *(byte*)constptr(in src);

        /// <summary>
        /// Reads 16 bits from a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ushort read16(in byte src)
            => *(ushort*)constptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read32(in byte src)
            => *(uint*)constptr(in src);

        /// <summary>
        /// Reads 32 bits from a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The bit source</param>
        [MethodImpl(Inline), Op]
        public static unsafe uint read32(in ushort src)
            => *(uint*)constptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read64(in byte src)
            => *(ulong*)constptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read64(in ushort src)
            => *(ulong*)constptr(in src);

        /// <summary>
        /// Reads 64 bits from a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The source reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe ulong read64(in uint src)
            => *(ulong*)constptr(in src);

        /// <summary>
        /// Projects a source byte onto a byte reference
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe void store8(byte src, ref byte dst)
            => *((byte*)ptr(ref dst)) = src;

        /// <summary>
        /// Projects 16 source bits onto a contiguous sequence of 2 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe void store16(ushort src, ref byte dst)
            => *((ushort*)ptr(ref dst)) = src;

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 4 bytes
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe void store32(uint src, ref byte dst)
            => *((uint*)ptr(ref dst)) = src;

        /// <summary>
        /// Projects 32 source bits onto a contiguous sequence of 2 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe void store32(uint src, ref ushort dst)
            => *((uint*)ptr(ref dst)) = src;

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 8 bytes
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe void store64(ulong src, ref byte dst)
            => *((ulong*)ptr(ref dst)) = src;        

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 4 16-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe void store64(ulong src, ref ushort dst)
            => *((ulong*)ptr(ref dst)) = src;        

        /// <summary>
        /// Projects 64 source bits onto a contiguous sequence of 2 32-bit integers
        /// </summary>
        /// <param name="src">The source data</param>
        /// <param name="dst">The target reference</param>
        [MethodImpl(Inline), Op]
        public static unsafe void store64(ulong src, ref uint dst)
            => *((ulong*)ptr(ref dst)) = src;        

        /// <summary>
        /// Casts memory cells of one type to another
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> cast<S,T>(Memory<S> src)
            where S : unmanaged
            where T : unmanaged
        {
            if (typeof(S) == typeof(T)) 
                return (Memory<T>)(object)src;
            return new MemoryCast<S,T>(src).Memory;
        }

        /// <summary>
        /// Constructs a mutable memory segment from a readonly memory segment
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> edit<T>(ReadOnlyMemory<T> src)
            => MemoryMarshal.AsMemory(src);

        /// <summary>
        /// Reverses the memory cells in-place
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> reverse<T>(Memory<T> src)
        {
            src.Span.Reverse();
            return src;
        }

        /// <summary>
        /// Enumerates the content of a readonly memory segment
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static IEnumerable<T> enumerate<T>(ReadOnlyMemory<T> src)
            => MemoryMarshal.ToEnumerable(src);

        /// <summary>
        /// Projects a memory source to target via a supplied transformation
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="f">The transformation</param>
        /// <typeparam name="S">The source type</typeparam>
        /// <typeparam name="T">The target type</typeparam>
        public static Span<T> map<S,T>(Memory<S> src, Func<S, T> f)
        {
            var dst = new T[src.Length];
            for(var i= 0; i<src.Length; i++)
                dst[i] = f(src.Span[i]);
            return dst;
        }

        [MethodImpl(Inline)]
        internal static int size<T>()
            => Unsafe.SizeOf<T>();

    }

    //https://stackoverflow.com/questions/54511330/how-can-i-cast-memoryt-to-another
    public sealed class MemoryCast<S, T> : MemoryManager<T>
        where S : unmanaged
        where T : unmanaged
    {
        readonly Memory<S> source;

        [MethodImpl(Inline)]
        public MemoryCast(Memory<S> source) 
            => this.source = source;

        public override Span<T> GetSpan()
            => MemoryMarshal.Cast<S, T>(source.Span);

        protected override void Dispose(bool disposing) {}

        public override MemoryHandle Pin(int elementIndex = 0)
            => throw new NotSupportedException();

        public override void Unpin()
            => throw new NotSupportedException();
    }    
}