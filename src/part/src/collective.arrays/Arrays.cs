//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;
    using System.Collections.Generic;

    using static Part;

    [ApiHost(ApiNames.Arrays, true)]
    public readonly partial struct Arrays
    {
        const NumericKind Closure = UnsignedInts;
    }
}