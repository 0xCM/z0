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
    /// Represents a memory offset as described by Vol I 3-23 of Intel Manuals
    /// </summary>
    public readonly struct MemoryOffset
    {
        public uint Displacement {get;}

        public RegKind Base {get;}

        public RegKind Index {get;}

        public MemoryScale Scale {get;}

        [MethodImpl(Inline)]
        public MemoryOffset(uint dx, RegKind @base, RegKind index, MemoryScale scale)
        {
            Displacement = dx;
            Base = @base;
            Index = index;
            Scale = scale;
        }
    }
}