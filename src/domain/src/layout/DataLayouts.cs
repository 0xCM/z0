//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    using static Konst;
    using static z;

    [ApiHost("data.layouts")]
    public readonly partial struct DataLayouts
    {
        const NumericKind Closure = UnsignedInts;
    }
}