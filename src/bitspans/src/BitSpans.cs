//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost("api")]
    public partial class BitSpans
    {
        const NumericKind Closure = Konst.UnsignedInts;
    }

    [ApiHost("direct")]
    public partial class SpannedBits
    {

    }


    public static partial class XTend
    {

    }

    public static partial class XBitSpans
    {
        const NumericKind Closure = Konst.UnsignedInts;
    }
}