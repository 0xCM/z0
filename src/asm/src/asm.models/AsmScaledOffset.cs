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
        public ulong Base {get;}

        public ushort Offset {get;}

        public byte Scale {get;}

        [MethodImpl(Inline)]
        public AsmScaledOffset(ulong @base, ushort offset, byte scale)
        {
            Base = @base;
            Offset = offset;
            Scale = scale;
        }
    }
}