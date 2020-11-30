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

    partial class BitSpans
    {
        /// <summary>
        /// Materializes an integral value from a bitspan segment
        /// </summary>
        /// <param name="src">The source bitspan</param>
        /// <param name="offset">The bit position at which the slice begins</param>
        /// <param name="count">The number of bits, at most bitsize[T], to pull</param>
        /// <typeparam name="T">The integral numeric type</typeparam>
        [MethodImpl(Inline), Op, Closures(Integers)]
        public static T slice32<T>(in BitSpan32 src, int offset, int count)
            where T : unmanaged
                => slice32_u<T>(src,offset,count);

        [MethodImpl(Inline)]
        static T slice32_u<T>(in BitSpan32 src, int offset, int count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(byte))
                return generic<T>(slice32(src, w8, offset, count));
            else if(typeof(T) == typeof(ushort))
                return generic<T>(slice32(src, w16, offset, count));
            else if(typeof(T) == typeof(uint))
                return generic<T>(slice32(src, w32, offset, count));
            else if(typeof(T) == typeof(ulong))
                return generic<T>(slice32(src, w64, offset, count));
            else
                return slice32_i<T>(src,offset,count);
        }

        [MethodImpl(Inline)]
        static T slice32_i<T>(in BitSpan32 src, int offset, int count)
            where T : unmanaged
        {
            if(typeof(T) == typeof(sbyte))
                return generic<T>(slice32(src, w8i, offset, count));
            else if(typeof(T) == typeof(short))
                return generic<T>(slice32(src, w16i, offset,count));
            else if(typeof(T) == typeof(int))
                return generic<T>(slice32(src, w32i, offset,count));
            else if(typeof(T) == typeof(long))
                return generic<T>(slice32(src, w64i, offset, count));
            else
                throw no<T>();
        }

        /// <summary>
        /// Materializes an 8-bit unsigned integer from a bitspan segment
        /// </summary>
        /// <param name="src">The source bitspan</param>
        /// <param name="w">The width selector</param>
        /// <param name="offset">The bit position at which the slice begins</param>
        /// <param name="count">The number of bits, at most 8, to pull</param>
        [MethodImpl(Inline), Op]
        public static byte slice32(in BitSpan32 src, W8 w, int offset, int count)
        {
            var buffer = StackStores.alloc(w64);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            ref var dst = ref StackStores.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked,Konst.z8);
        }

        /// <summary>
        /// Materializes a 16-bit unsigned integer from a bitspan segment
        /// </summary>
        /// <param name="src">The source bitspan</param>
        /// <param name="w">The width selector</param>
        /// <param name="offset">The bit position at which the slice begins</param>
        /// <param name="count">The number of bits, at most 16, to pull</param>
        [MethodImpl(Inline), Op]
        public static ushort slice32(in BitSpan32 src, W16 w, int offset, int count)
        {
            var buffer = StackStores.alloc(w128);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            ref var dst = ref StackStores.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z16);
        }

        /// <summary>
        /// Materializes a 32-bit unsigned integer from a bitspan segment
        /// </summary>
        /// <param name="src">The source bitspan</param>
        /// <param name="w">The width selector</param>
        /// <param name="offset">The bit position at which the slice begins</param>
        /// <param name="count">The number of bits, at most 32, to pull</param>
        [MethodImpl(Inline), Op]
        public static uint slice32(in BitSpan32 src, W32 w, int offset, int count)
        {
            var buffer = StackStores.alloc(w256);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            var take = math.min(src.Edit.Length -offset, count);
            src.Edit.Slice(offset,take).CopyTo(unpacked);
            return BitPack.pack(unpacked, z32);
        }

        /// <summary>
        /// Materializes a 64-bit unsigned integer from a bitspan segment
        /// </summary>
        /// <param name="src">The source bitspan</param>
        /// <param name="w">The width selector</param>
        /// <param name="offset">The bit position at which the slice begins</param>
        /// <param name="count">The number of bits, at most 64, to pull</param>
        [MethodImpl(Inline), Op]
        public static ulong slice32(in BitSpan32 src, W64 w, int offset, int count)
        {
            var buffer = StackStores.alloc(w512);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            ref var dst = ref StackStores.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z64);
        }

        [MethodImpl(Inline), Op]
        public static sbyte slice32(in BitSpan32 src, W8i w, int offset, int count)
        {
            var buffer = StackStores.alloc(w64);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            ref var dst = ref StackStores.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z8i);
        }

        [MethodImpl(Inline), Op]
        public static short slice32(in BitSpan32 src, W16i w, int offset, int count)
        {
            var buffer = StackStores.alloc(w128);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            ref var dst = ref StackStores.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z16i);
        }

        [MethodImpl(Inline), Op]
        public static int slice32(in BitSpan32 src, W32i w, int offset, int count)
        {
            var buffer = StackStores.alloc(w256);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            ref var dst = ref StackStores.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked,z32i);
        }

        [MethodImpl(Inline), Op]
        public static long slice32(in BitSpan32 src, W64i w, int offset, int count)
        {
            var buffer = StackStores.alloc(w512);
            var unpacked = StackStores.span<Bit32>(ref buffer);
            ref var dst = ref StackStores.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z64i);
        }
    }
}