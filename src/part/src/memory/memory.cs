//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;
    using System.Runtime.CompilerServices;

    [ApiHost(ApiNames.Memory)]
    public readonly partial struct memory
    {
        const NumericKind Closure = NumericKind.UnsignedInts;
    }
}