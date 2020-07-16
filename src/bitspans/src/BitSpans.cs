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
        const NumericKind Closure = Konst.UnsignedInts;
    }
    

    public static partial class XTend
    {

    }
}