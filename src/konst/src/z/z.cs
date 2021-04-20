//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Part;

    [ApiHost]
    public partial struct z
    {

        const NumericKind Closure = UnsignedInts;
    }

    public static partial class XTend
    {
        const NumericKind Closure = UnsignedInts;

    }
}