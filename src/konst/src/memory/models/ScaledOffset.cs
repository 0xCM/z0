//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    /// <summary>
    /// Represents an address A as a base address B with a byte-scaled O-offset, A := Base + Scale*Offset
    /// </summary>
    public readonly struct ScaledOffset
    {
        public readonly MemoryAddress Base;

        public readonly MemoryAddress Offset;
        
        public readonly byte Scale;

        [MethodImpl(Inline)]
        public ScaledOffset(MemoryAddress @base, MemoryAddress offset, byte scale)
        {
            Base = @base;
            Offset = offset;
            Scale = scale;
        }
    }
}