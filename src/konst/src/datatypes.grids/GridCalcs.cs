//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.GridCalcs, true)]
    public readonly partial struct GridCalcs
    {
        const NumericKind Closure = UnsignedInts;
    }
}