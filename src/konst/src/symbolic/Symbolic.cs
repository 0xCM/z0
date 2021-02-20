//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.Symbolic, true)]
    public readonly partial struct Symbolic
    {
        const NumericKind Closure = UnsignedInts;
    }
}