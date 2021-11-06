//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Root;
    using static core;

    public unsafe class MemAlloc : IDisposable
    {
        public static MemAlloc alloc(uint pages)
            => new MemAlloc(pages);

        PageBank Memory;

        Index<uint> Allocations;

        public uint PageCapacity {get;}

        internal MemAlloc(uint pages)
        {
            Memory = PageBank.alloc(pages);
            PageCapacity = pages;
            Allocations = alloc<uint>(PageCapacity);
            for(var i=0; i<PageCapacity; i++)
                Allocations[i] = uint.MaxValue;
        }

        [MethodImpl(Inline)]
        MemoryAddress PageAddress(uint index)
            => Memory.PageAddress(index);

        public MemoryAddress AllocPage()
        {
            for(var i=0u; i<PageCapacity; i++)
            {
                ref readonly var index = ref Allocations[i];
                if(index < PageCapacity)
                {
                    Allocations[index] = i;
                    return PageAddress(i);
                }
            }
            return MemoryAddress.Zero;
        }

        public void FreePage(MemoryAddress src)
        {
            for(var i=0u; i<PageCapacity; i++)
            {
                ref readonly var index = ref Allocations[i];
                if(index < PageCapacity && PageAddress(index) == src)
                    Allocations[i] = uint.MaxValue;
            }
        }

        public void Dispose()
        {
            Memory.Dispose();
        }
    }
}