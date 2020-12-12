//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.Widths, true)]
    public static partial class Widths
    {
        const NumericKind Closure = UnsignedInts;
    }
}