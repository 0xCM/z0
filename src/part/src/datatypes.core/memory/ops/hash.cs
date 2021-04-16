//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;

    partial struct memory
    {
        /// <summary>
        /// Hashes an address, perfectly
        /// </summary>
        /// <param name="count">The number of address the the perfect hash bucket</param>
        /// <param name="src">The address to hash</param>
        [MethodImpl(Inline), Op]
        public static uint hash(uint count, MemoryAddress src)
            => (uint)((ulong)src % (ulong)count);

        [Op]
        public static Index<MemoryAddress> hash(ReadOnlySpan<MemoryAddress> src)
        {
            var count = (uint)src.Length;
            var dst = alloc<MemoryAddress>(count);
            hash(src, dst);
            return dst;
        }

        [MethodImpl(Inline), Op]
        public static void hash(ReadOnlySpan<MemoryAddress> src, Span<MemoryAddress> dst)
        {
            var count = (uint)src.Length;
            for(var i=0; i<count; i++)
            {
                ref readonly var address = ref skip(src,i);
                seek(dst, hash(count,address)) = address;
            }
        }

        [Op]
        public static uint hash(ReadOnlySpan<MemoryAddress> src, Span<AddressHash> dst)
        {
            var count = (uint)src.Length;
            var h0 = memory.hash(src).View;
            ref var hashed = ref first(dst);
            for(var i=0u; i<count; i++)
            {
                ref readonly var address = ref skip(src,i);
                var h = memory.hash(count, address);
                ref readonly var found = ref skip(h0, h);
                ref var target = ref seek(hashed,i);
                target.Index = i;
                target.Address = address;
                target.HashCode = h;
            }
            return count;
        }
    }
}