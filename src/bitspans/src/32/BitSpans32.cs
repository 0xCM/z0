//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;
    using static memory;

    using SB = BitSpan32Scalars;

    [ApiHost]
    public partial class BitSpans32
    {
        const NumericKind Closure = UnsignedInts;
   }
}