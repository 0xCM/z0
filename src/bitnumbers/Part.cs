//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
using System;
using System.Reflection;

[assembly: PartId(PartId.BitNumbers)]

namespace Z0.Parts
{
    public sealed partial class BitNumbers : Part<BitNumbers>
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