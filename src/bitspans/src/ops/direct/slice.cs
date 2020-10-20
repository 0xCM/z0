//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static z;
    using static Konst;

    partial class SpannedBits
    {
        /// <summary>
        /// Materializes an 8-bit unsigned integer from a bitspan segment
        /// </summary>
        /// <param name="src">The source bitspan</param>
        /// <param name="w">The width selector</param>
        /// <param name="offset">The bit position at which the slice begins</param>
        /// <param name="count">The number of bits, at most 8, to pull</param>
        [MethodImpl(Inline), Op]
        public static byte slice(in BitSpan src, W8 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w64);
            var unpacked = Stacks.span<Bit32>(ref buffer);
            ref var dst = ref Stacks.head<Bit32>(ref buffer);
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
        public static ushort slice(in BitSpan src, W16 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w128);
            var unpacked = Stacks.span<Bit32>(ref buffer);
            ref var dst = ref Stacks.head<Bit32>(ref buffer);
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
        public static uint slice(in BitSpan src, W32 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w256);
            var unpacked = Stacks.span<Bit32>(ref buffer);
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
        public static ulong slice(in BitSpan src, W64 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w512);
            var unpacked = Stacks.span<Bit32>(ref buffer);
            ref var dst = ref Stacks.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z64);
        }

        [MethodImpl(Inline)]
        internal static sbyte islice(in BitSpan src, W8 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w64);
            var unpacked = Stacks.span<Bit32>(ref buffer);
            ref var dst = ref Stacks.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z8i);
        }

        [MethodImpl(Inline)]
        internal static short islice(in BitSpan src, W16 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w128);
            var unpacked = Stacks.span<Bit32>(ref buffer);
            ref var dst = ref Stacks.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z16i);
        }

        [MethodImpl(Inline)]
        internal static int islice(in BitSpan src, W32 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w256);
            var unpacked = Stacks.span<Bit32>(ref buffer);
            ref var dst = ref Stacks.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked,z32i);
        }

        [MethodImpl(Inline)]
        internal static long islice(in BitSpan src, W64 w, int offset, int count)
        {
            var buffer = Stacks.alloc(w512);
            var unpacked = Stacks.span<Bit32>(ref buffer);
            ref var dst = ref Stacks.head<Bit32>(ref buffer);
            MemCopy.copy(in skip(src.Edit, offset), ref dst, count);
            return BitPack.pack(unpacked, z64i);
        }
    }
}