//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiSetKind.Bits)]
    public partial class Bits
    {
        const NumericKind Closure = Konst.UnsignedInts;

    }

    [ApiHost(ApiSetKind.Bits | ApiSetKind.Generic)]
    public partial class gbits
    {
        const NumericKind Closure = UnsignedInts;
    }

    [ApiHost]
    public partial class BitLogixOps
    {

    }

    public static partial class XTend
    {

    }

    public static partial class XBits
    {

    }
}