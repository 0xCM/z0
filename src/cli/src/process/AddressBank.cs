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
}