//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public readonly struct ScaledOffsets
    {
        [MethodImpl(Inline)]
        public static ScaledOffset<B,O,S> define<B,O,S>(B @base, O offset, S scale)
            => new ScaledOffset<B,O,S>(@base, offset, scale);
    }    

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

    /// <summary>
    /// Represents an address A as a base address B with a byte-scaled O-offset, A := Base + Scale*Offset
    /// </summary>
    public readonly struct ScaledOffset<B,O>
    {
        public readonly B Base;

        public readonly O Offset;
        
        public readonly byte Scale;

        [MethodImpl(Inline)]
        public ScaledOffset(B @base, O offset, byte scale)
        {
            Base = @base;
            Offset = offset;
            Scale = scale;
        }
    }
    
    /// <summary>
    /// Represents an address A as a base address B with an S-scaled O-offset, A := Base + Scale*Offset
    /// </summary>
    public readonly struct ScaledOffset<B,O,S>
    {
        public readonly B Base;

        public readonly O Offset;

        public readonly S Scale;        

        [MethodImpl(Inline)]
        public ScaledOffset(B @base, O offset, S scale)
        {
            Base = @base;
            Offset = offset;
            Scale = scale;
        }
    }
}