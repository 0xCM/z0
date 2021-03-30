//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using static Part;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost(ApiNames.Spans, true)]
    public static partial class Spans
    {
        const NumericKind Closure = UnsignedInts;

    }

    public static partial class XSpan
    {
        const NumericKind Closure = UnsignedInts;
    }
}