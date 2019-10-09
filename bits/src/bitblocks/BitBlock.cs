//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2019
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using static zfunc;

    public ref struct BitBlock<N>
        where N : ITypeNat, INatPow2, new()
    {
        Span<N,byte> bits;

        [MethodImpl(Inline)]
        public BitBlock(Span<N,byte> bits)
            => this.bits = bits;
    }

}