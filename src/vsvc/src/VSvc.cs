//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public partial class VSvcHosts
    {

    }

    [FunctionalService]
    public partial class VSvc : IFunctional<VSvc,VSvcHosts>
    {
        const NumericKind Closure = UInt64k;
    }
}