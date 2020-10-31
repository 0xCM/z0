//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Linq.Expressions;

    using static Konst;

    [ApiHost(ApiNames.LinqXPress, true)]
    public partial class LinqXPress
    {
        const NumericKind Closure = UnsignedInts;
    }
}