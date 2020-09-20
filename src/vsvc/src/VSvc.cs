//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Konst;

    public partial class VServices
    {

    }

    [FunctionalService]
    public partial class VSvc : ISFxRoot<VSvc,VServices>
    {
        const NumericKind Closure = UInt64k;
    }
}