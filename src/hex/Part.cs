//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------

[assembly: PartId(PartId.Hex)]

namespace Z0.Parts
{
    public sealed class Hex : Part<Hex>
    {

    }
}

namespace Z0
{
    [ApiHost]
    public static partial class XTend
    {

    }

    struct Msg
    {
        public static MsgPattern<string> UnevenNibbles
            => "An even number of nibbles was not provided in the source text '{0}'";

    }
}

