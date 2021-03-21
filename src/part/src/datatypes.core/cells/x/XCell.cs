//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost(ApiNames.XCell, true)]
    public static partial class XCell
    {
        const NumericKind Closure = Part.Integers;
    }
}