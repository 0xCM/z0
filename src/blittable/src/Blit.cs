//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Root;

    [ApiHost]
    public readonly partial struct Blit
    {
        const NumericKind Closure = UnsignedInts;

        [ApiHost("blit.factory")]
        public readonly partial struct Factory
        {

        }

        [ApiHost("blit.operate")]
        public readonly partial struct Operate
        {

        }

        [ApiHost("blit.meta")]
        public readonly partial struct Meta
        {

        }
    }
}