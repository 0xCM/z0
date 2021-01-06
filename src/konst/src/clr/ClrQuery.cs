//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.ClrQuery, true)]
    public static partial class ClrQuery
    {
        const NumericKind Closure = AllNumeric;
    }
}