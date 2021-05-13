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
        /// <param name="capacity">The number slots in the bucket</param>
        /// <param name="src">The address to hash</param>
        [MethodImpl(Inline), Op]
        public static uint hash(MemoryAddress src)
            => (uint)src;

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
                target.HashCode = hash(address);
            }
            return count;
        }

        [MethodImpl(Inline), Op]
        public static uint bucket(MemoryAddress src, uint capacity)
            => hash(src) % (capacity - 1);

        [MethodImpl(Inline), Op]
        public static uint bucket(Hash32 hash, uint capacity)
            => hash % (capacity - 1);

        public static MemoryLookup lookup(Index<MemorySymbol> symbols, uint count)
        {
            var capacity = (uint)symbols.Length;
            var keys = alloc<uint>(capacity);
            ref var k = ref first(keys);
            ref var s = ref symbols.First;
            for(var i=0; i<count; i++)
            {
                ref var symbol = ref seek(s,i);
                symbol.HashCode = memory.hash(symbol.Address);
                seek(k,  bucket(symbol.HashCode, capacity)) = symbol.Index;

            }
            return new MemoryLookup(symbols, keys, capacity);
        }
    }
}