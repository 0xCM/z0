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

    [ApiHost(ApiNames.MemCopy, true)]
    public readonly struct MemCopy
    {
        const NumericKind Closure = UnsignedInts;

        // [MethodImpl(Inline), Op]
        // public static void copy(in byte src, uint count, ref byte dst, ref uint index)
        // {
        //     for(var j=0u; j<count; j++)
        //         z.seek(dst, index++) = z.skip(src, j);
        // }

        /// <summary>
        /// Concatenates an array sequence
        /// </summary>
        /// <param name="src">The source arrays</param>
        [Op]
        public static void concat(byte[][] src, byte[] dst)
        {
            ref var target = ref first(span(dst));
            var k = 0u;

            var members = span(src);
            var terms = members.Length;
            for(uint i=0u; i<terms; i++)
            {
                var term = span(z.skip(members,i));
                copy(first(term), (uint)term.Length, ref target, ref k);
            }
        }

        /// <summary>
        /// Concatenates an array sequence
        /// </summary>
        /// <param name="src">The source arrays</param>
        [MethodImpl(Inline), Op]
        public static byte[] concat(byte[][] src)
        {
            var members = span(src);
            var terms = members.Length;
            var items = 0;

            for(var i=0; i<terms; i++)
                items += members[i].Length;

            var dst = alloc<byte>(items);
            concat(src,dst);
            return dst;
        }


        [MethodImpl(Inline), Op, Closures(Closure)]
        public static ref T copy<T>(in T src, uint count, ref T dst, ref uint index)
        {
            for(var j=0u; j<count; j++)
                seek(dst, index++) = skip(src, j);
            return ref dst;
        }

        /// <summary>
        /// Copies 8 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W8 w, in byte src, ref byte dst)
        {
            *(gptr(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Copies 16 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W16 w, in byte src, ref byte dst)
        {
            *(gptr(@as<ushort>(src))) = @as<ushort>(src);
            return ref dst;
        }

        /// <summary>
        /// Copies 32 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W32 w, in byte src, ref byte dst)
        {
            *(gptr(@as<uint>(src))) = @as<uint>(src);
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W64 w, in byte src, ref byte dst)
        {
            *(gptr(@as<ulong>(src))) = @as<ulong>(src);
            return ref dst;
        }

        /// <summary>
        /// Copies 128 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W128 w, in byte src, ref byte dst)
        {
            *(gptr(@as<Cell128>(src))) = @as<Cell128>(src);
            return ref dst;
        }

        /// <summary>
        /// Copies 256 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W256 w, in byte src, ref byte dst)
        {
            *(gptr(@as<Cell256>(src))) = @as<Cell256>(src);
            return ref dst;
        }

        /// <summary>
        /// Copies 512 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W512 w, in byte src, ref byte dst)
        {
            *(gptr(@as<Cell512>(src))) = @as<Cell512>(src);
            return ref dst;
        }

        /// <summary>
        /// Copies 512 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W1024 w, in byte src, ref byte dst)
        {
            ref var x = ref @as<byte,Cell512>(src);
            ref var y = ref @as<byte,Cell512>(dst);
            seek(x,0) = skip(y,0);
            seek(x,1) = skip(y,1);
            return ref dst;
        }

        /// <summary>
        /// Copies 16 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W16 w, in ushort src, ref byte dst)
        {
            *(gptr<ushort>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Copies 32 bits from the source to the target
        /// </summary>
        /// <param name="src">The bit source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint copy(W32 w, in ushort src, out uint dst)
        {
            dst = *(uint*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ulong copy(W64 w, in byte src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ulong copy(W64 w, in ushort src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Copies 16 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort copy(W16 w,in byte src, out ushort dst)
        {
            dst = *(ushort*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Copies 32 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint copy(W32 w,in byte src, out uint dst)
        {
            dst = *(uint*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
         /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ulong copy(W64 w, in uint src, out ulong dst)
        {
            dst = *(ulong*)gptr(in src);
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W32 w, in uint src, ref byte dst)
        {
             *(gptr<uint>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort copy(W32 w, in uint src, ref ushort dst)
        {
            *(gptr<uint>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref byte copy(W64 w, in ulong src, ref byte dst)
        {
             *(gptr<ulong>(dst)) = src;
             return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref ushort copy(W64 w, in ulong src, ref ushort dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
        }

        /// <summary>
        /// Copies 64 bits from the source to the target
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="dst">The target</param>
        [MethodImpl(Inline), Op]
        public static unsafe ref uint copy(W64 w, in ulong src, ref uint dst)
        {
            *(gptr<ulong>(dst)) = src;
            return ref dst;
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

        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(SegRef src, Span<T> dst)
            where T : unmanaged
                => MemoryReader.create<T>(src).ReadAll(dst);

        /// <summary>
        /// Copies the source to the target using 128-bit intrinsic operations
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vcopy<T>(W128 w, ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var seg = (uint)vcount<T>(w);
            var blocks = length(src,dst)/seg;
            for(var i=0u; i<blocks; i++)
            {
                var offset = i*seg;
                var vSrc = vload(w, skip(src, offset));
                vsave(vSrc, ref seek(dst,offset));
            }
        }

        /// <summary>
        /// Copies the source to the target using 256-bit intrinsic operations
        /// </summary>
        /// <param name="w">The vector width selector</param>
        /// <param name="src">The source</param>
        /// <param name="dst">The target</param>
        /// <typeparam name="T">The cell type</typeparam>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static void vcopy<T>(W256 w, ReadOnlySpan<T> src, Span<T> dst)
            where T : unmanaged
        {
            var seg = (uint)vcount<T>(w);
            var blocks = length(src,dst)/seg;
            for(var i=0u; i<blocks; i++)
            {
                var offset = i*seg;
                var vSrc = vload(w, skip(src, offset));
                vsave(vSrc, ref seek(dst,offset));
            }
        }

        /// <summary>
        /// Copies a contiguous segments of bytes from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy(byte* pSrc, byte* pDst, uint srcCount)
            => sys.copy(pSrc, pDst, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values from one location to another
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(T* pSrc, T* pDst, uint srcCount)
            where T : unmanaged
                => sys.copy(pSrc, pDst, srcCount);

        /// <summary>
        /// Copies a contiguous segments of values to a span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="pDst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op, Closures(Closure)]
        public static unsafe void copy<T>(T* pSrc, Span<T> dst, int offset, uint srcCount)
            where T : unmanaged
                =>  copy(pSrc, gptr(first(dst), offset), srcCount);

        /// <summary>
        /// Copies a contiguous segments of bytes from a source location to a target span
        /// </summary>
        /// <param name="pSrc">The location of the source bytes</param>
        /// <param name="dst">The location of the target</param>
        /// <param name="srcCount">The number of values to copy</param>
        [MethodImpl(Inline), Op]
        public static unsafe void copy(byte* pSrc, Span<byte> dst, int offset, uint srcCount)
            => copy(pSrc, gptr(seek(dst, (uint)offset)) , srcCount);

        /// <summary>
        /// Copies a specified number source cells to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="start">The source start index</param>
        /// <param name="count">The source cell count</param>
        /// <param name="dst">The data target</param>
        /// <param name="offset">The target offset</param>
        /// <typeparam name="S">The source cell type</typeparam>
        /// <typeparam name="T">The target cell type</typeparam>
        [MethodImpl(Inline)]
        public static uint copy<S,T>(ReadOnlySpan<S> src, int start, int count, Span<T> dst, int offset = 0)
            where S: unmanaged
            where T :unmanaged
        {
            ref var input =  ref u8(skip(src, (uint)start));
            ref var target = ref u8(seek(dst, (uint)offset));
            var bytecount =  (uint)(count*size<S>());
            sys.copy(input, ref target, bytecount);
            return bytecount;
        }

        /// <summary>
        /// Copies a specified number source cells to the target and returns the count of copied bytes
        /// </summary>
        /// <param name="src">The data source</param>
        /// <param name="start">The source start index</param>
        /// <param name="count">The source cell count</param>
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