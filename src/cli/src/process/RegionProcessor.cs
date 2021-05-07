//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;
    using static ProcessMemory;

    public readonly struct AddressBank
    {
        readonly Index<Address16> Selectors;

        readonly Index<List<Paired<Address32,uint>>> Bases;

        internal AddressBank(Index<Address16> selectors, Index<List<Paired<Address32,uint>>> bases)
        {
            Selectors = selectors;
            Bases =  bases;
        }

        public uint SegmentCount
        {
            [MethodImpl(Inline)]
            get => Selectors.Count;
        }

        public ReadOnlySpan<Paired<Address32,uint>> Segment(uint index)
        {
            return Bases[index].ViewDeposited();
        }

        [MethodImpl(Inline)]
        public Address16 Selector(uint index)
            => Selectors[index];
    }

    public sealed class RegionProcessor : SpanProcessor<RegionProcessor,MemoryRegion>
    {
        List<Address16> Selectors;

        List<List<Paired<Address32,uint>>> Bases;

        AddressBank _Product;

        protected override void Complete()
        {
            _Product = new AddressBank(Selectors.ToArray(), Bases.ToArray());
        }

        public ref readonly AddressBank Product
        {
            [MethodImpl(Inline)]
            get => ref _Product;
        }

        public RegionProcessor()
        {
            Selectors = new();
            Bases = new();
        }

        int Index(Address16 selector)
        {
            var index = Selectors.IndexOf(selector);
            if(index == NotFound)
            {
                Selectors.Add(selector);
                index = Selectors.Count - 1;
                Bases.Add(root.list<Paired<Address32,uint>>());
            }
            return index;
        }

        void Add(Address16 selector, Address32 @base, uint size)
            => Bases[Index(selector)].Add(root.paired(@base, size));

        protected override void Process(uint index, in MemoryRegion src)
        {
            if(src.Type != 0 && src.Protection != 0)
                Add(src.BaseAddress.Quadrant(n2), src.BaseAddress.Lo, (uint)(src.EndAddress - src.BaseAddress));
        }
    }
}