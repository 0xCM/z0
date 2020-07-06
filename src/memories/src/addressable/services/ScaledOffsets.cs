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
}