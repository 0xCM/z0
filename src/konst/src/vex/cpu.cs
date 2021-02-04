//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    using static Part;

    [ApiHost(ApiSetKind.Cpu)]
    public readonly partial struct cpu
    {
        const NumericKind Closure = UnsignedInts;
    }

    [ApiHost(ApiSetKind.Cpu | ApiSetKind.Generic)]
    public readonly partial struct gcpu
    {
        const NumericKind Closure = UnsignedInts;
    }
}