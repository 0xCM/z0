//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    /// <summary>
    /// Represents an address A as a base address B with a byte-scaled O-offset, A := Base + Scale*Offset
    /// </summary>
    public readonly struct AsmScaledOffset
    {
        public MemoryAddress Base {get;}

        public Address16 Offset {get;}

        public byte Scale {get;}

        [MethodImpl(Inline)]
        public AsmScaledOffset(MemoryAddress @base, Address16 offset, byte scale)
        {
            Base = @base;
            Offset = offset;
            Scale = scale;
        }
    }
}