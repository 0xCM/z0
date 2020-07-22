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