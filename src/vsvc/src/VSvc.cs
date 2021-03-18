//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    public partial class VSvcHosts
    {

    }

    [FunctionalService]
    public partial class VSvc : ISFxRoot<VSvc,VSvcHosts>
    {
        const NumericKind Closure = UInt64k;
    }
}