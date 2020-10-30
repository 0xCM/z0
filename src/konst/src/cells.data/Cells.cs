//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    using Free = System.Security.SuppressUnmanagedCodeSecurityAttribute;

    [Free, ApiHost(ApiNames.Cells, true)]
    public partial class Cells
    {
        const NumericKind Closure = UnsignedInts;
    }
}