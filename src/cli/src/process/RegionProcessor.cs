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
    using static core;

    public sealed class RegionProcessor : SpanProcessor<RegionProcessor,MemoryRegion>
    {
        List<Address16> Selectors;

        List<List<Paired<Address32,uint>>> Bases;

        Index<SegmentSelection> _Selection;

        AddressBank _Bank;

        public RegionProcessor()
        {
            Selectors = new();
            Bases = new();
            _Selection = new();
        }

        protected override void Complete()
        {
            _Bank = new AddressBank(Selectors.ToArray(), Bases.ToArray());
        }

        public ref readonly AddressBank Bank
        {
            [MethodImpl(Inline)]
            get => ref _Bank;
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

        public Index<SegmentSelection> Selection
            => _Selection;

        protected override uint Process(ReadOnlySpan<MemoryRegion> src)
        {
            var count = (uint)src.Length;
            _Selection = core.alloc<SegmentSelection>(count);
            for(var i=0u; i<count; i++)
                Include(i,skip(src,i));
            return count;
        }

        void Add(uint index, utf8 label, Address16 selector, Address32 @base, uint offset)
        {
            var sidx = (ushort)Index(selector);
            Bases[sidx].Add(root.paired(@base, offset));
            ref var selection = ref _Selection[index];
            selection.Index = index;
            selection.Selector = selector;
            selection.SelectorIndex = sidx;
            selection.Base = @base;
            selection.Offset = offset;
            selection.Target = ((ulong)selection.Selector << 32) + ((ulong)selection.Base + (ulong)selection.Offset);
            selection.Label = label;
        }

        void Include(uint index, in MemoryRegion src)
        {
            var id = src.Identity.Format();
            if(text.empty(id))
                id = src.FullIdentity;
            if(src.Type != 0 && src.Protection != 0)
                Add(index, id, src.BaseAddress.Quadrant(n2), src.BaseAddress.Lo, (uint)(src.EndAddress - src.BaseAddress));
        }
    }
}