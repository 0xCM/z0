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
        public static uint hash(ReadOnlySpan<MemoryAddress> src, Span<AddressHash> dst)
        {
            var count = (uint)src.Length;
            for(var i=0u; i<count; i++)
            {
                ref readonly var address = ref skip(src,i);
                ref var target = ref seek(dst,i);
                target.Index = i;
                target.Address = address;
                target.HashCode = hash(count, address);
            }
            return count;
        }
    }
}