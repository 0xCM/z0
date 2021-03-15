//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static Rules;

    [ApiHost("api")]
    public readonly partial struct BitFields
    {
        const NumericKind Closure = UnsignedInts;
   }
}