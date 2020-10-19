//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Security;

    using static Konst;

    [SuppressUnmanagedCodeSecurity]
    [ApiHost(ApiNames.Cells, true)]
    public partial class Cells
    {
        const NumericKind Closure = UnsignedInts;
    }
}