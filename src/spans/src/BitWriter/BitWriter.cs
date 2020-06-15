//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{        
    using System;
    using System.Runtime.CompilerServices;

    using static Seed;

    [ApiHost]
    public readonly partial struct BitWriter : IApiHost<BitWriter>
    {
        [MethodImpl(Inline)]
        static uint enable(uint src, int pos)
            =>  src |= (1u << pos);

        [MethodImpl(Inline)]
        static uint disable(uint src, int pos)        
            => src & ~((1u << pos));

    }
}