//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;

    using static Root;
    using static As;

    public static class Cells
    {
        /// <summary>
        /// Reads a generic value from the head of a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T cell<T>(ReadOnlySpan<byte> src)
            where T : unmanaged        
                => MemoryMarshal.Read<T>(src);

        /// <summary>
        /// Reads a generic value beginning at a specified offset
        /// </summary>
        /// <param name="src">The source span</param>
        /// <param name="offset">The index at which span consumption should begin</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T cell<T>(ReadOnlySpan<byte> src, int offset)
            where T : unmanaged        
                => MemoryMarshal.Read<T>(src.Slice(offset));

        /// <summary>
        /// Reads a generic value from the head of a source span
        /// </summary>
        /// <param name="src">The source span</param>
        /// <typeparam name="T">The value type</typeparam>
        [MethodImpl(Inline)]
        public static T cell<T>(Span<byte> src)
            where T : unmanaged           
                => MemoryMarshal.Read<T>(src);

        /// <summary>
        /// Reads an unmanaged generic value from a bytespan beginning at a specified offset
        /// </summary>
        /// <param name="src">The source value</param>
        /// <param name="offset">The source array offset</param>
        /// <typeparam name="T">The source type</typeparam>
        [MethodImpl(Inline)]
        public static T cell<T>(Span<byte> src, int offset)
            where T : unmanaged
                => MemoryMarshal.Read<T>(src.Slice(offset));
   
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
            var bytecount =  (uint)(srcCount*Unsafe.SizeOf<S>());
            Unsafe.CopyBlock(ref target, ref input, bytecount);
            return bytecount;
        }

        /// <summary>
        /// Copies a specified number source cells to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="start">The source start index</param>
        /// <param name="count">The soruce cell count</param>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(ReadOnlySpan<S> src, int start, int count, Span<T> dst, int offset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input =  ref uint8(ref Unsafe.AsRef(in skip(src,start)));
            ref var target = ref uint8(ref seek(dst, offset));
            var bytecount =  (uint)(count*Unsafe.SizeOf<S>());
            Unsafe.CopyBlock(ref target, ref input, bytecount);
            return bytecount;
        }

        /// <summary>
        /// Copies a specified number source cells to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="start">The source start index</param>
        /// <param name="count">The soruce cell count</param>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(Span<S> src, int start, int count, Span<T> dst, int offset = 0)
            where S: unmanaged
            where T :unmanaged
                => copy(src.ReadOnly(),start,count,dst,offset);
    }
}