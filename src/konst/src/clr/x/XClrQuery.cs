//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost(ApiNames.XClrQuery, true)]
    public static partial class XClrQuery
    {
        const NumericKind Closure = AllNumeric;
    }
}