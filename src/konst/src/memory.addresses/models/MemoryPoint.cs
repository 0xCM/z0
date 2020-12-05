//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct MemoryPoint32
    {
        public AddressSpace Space {get;}

        public Address32 Coordinate {get;}

        public MemoryPoint32(AddressSpace space, Address32 coord)
        {
            Space = space;
            Coordinate = coord;
        }
    }
}