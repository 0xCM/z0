//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

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