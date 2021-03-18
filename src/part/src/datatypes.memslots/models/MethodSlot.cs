//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    public readonly struct MethodSlot
    {
        public Name Name {get;}

        public MemoryAddress Address {get;}

        [MethodImpl(Inline)]
        public MethodSlot(Name name, MemoryAddress address)
        {
            Name = name;
            Address = address;
        }
    }
}