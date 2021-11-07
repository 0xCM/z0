//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;

    using static Root;
    using static core;
    [ApiHost]
    public readonly partial struct BitFlow
    {
        const NumericKind Closure = UnsignedInts;

       [ApiHost("blit.meta")]
        public readonly partial struct Meta
        {

        }
    }
}