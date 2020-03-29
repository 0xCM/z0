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

    using static Core;

    public static unsafe class memory
    {
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

        [MethodImpl(Inline)]
        static unsafe void copy<S,T>(in S src, ref T dst, uint targets)
            where T : unmanaged
            where S : unmanaged
                =>  Unsafe.CopyBlock(refs.ptr(ref dst),  Unsafe.AsPointer(ref Unsafe.AsRef(in src)), targets*(uint)size<T>());

        /// <summary>
        /// Copies a contiguous segments of bytes from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint srcCount)
            => Unsafe.CopyBlock(pDst, pSrc, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint srcCount)
            where T : unmanaged
                => Unsafe.CopyBlock(pDst, pSrc, (uint)(size<T>()*srcCount));

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline)]
        public static unsafe void copy<T>(T* pSrc, Span<T> dst, int offset, uint srcCount)
            where T : unmanaged
                =>  copy(pSrc, refs.ptr(ref refs.head(dst), offset), srcCount); 

        /// <summary>
        /// Copies a contiguous segments of bytes from a source location to a target span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="dst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline)]
        public static unsafe void copy(byte* pSrc, Span<byte> dst, int offset, uint srcCount)
            => copy(pSrc, (byte*)Unsafe.AsPointer(ref refs.seek(dst, offset)) , srcCount);

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
        /// Constructs a mutable memory segment from a readonly memory segment
        /// </summary>
        /// <param name="src">The source memory</param>
        /// <typeparam name="T">The memory cell type</typeparam>
        [MethodImpl(Inline)]
        public static Memory<T> edit<T>(ReadOnlyMemory<T> src)
            => MemoryMarshal.AsMemory(src);

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
    }
}