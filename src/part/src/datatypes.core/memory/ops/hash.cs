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
        /// Hashes an address
        /// </summary>
        /// <param name="count">The number of addresses in the bucket</param>
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
                if(address == 0)
                    continue;

                target.Index = i;
                target.Address = address;
                target.HashCode = hash(count, address);
            }
            return count;
        }

        public static MemoryLookup lookup(Index<MemorySymbol> symbols)
        {
            var count = (uint)symbols.Length;
            var keys = alloc<uint>(count);
            ref var k = ref first(keys);
            ref var s = ref symbols.First;
            for(var i=0; i<count; i++)
            {
                ref var symbol = ref seek(s,i);
                symbol.HashCode = memory.hash(count, symbol.Address);
                seek(k, symbol.HashCode) = symbol.Index;

            }
            return new MemoryLookup(symbols,keys);
        }
    }
}