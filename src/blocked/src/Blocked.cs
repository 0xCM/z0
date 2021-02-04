
//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost("api")]
    public partial class Blocked
    {
        const NumericKind Closure = Integers;
    }

    public partial class BSvcHosts
    {

    }

    [FunctionalService]
    public partial class BSvc : ISFxRoot<BSvc,BSvcHosts>
    {

    }
}