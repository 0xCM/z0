//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Konst;

    [ApiHost(ApiNames.GridCells, true)]
    public readonly partial struct GridCells
    {
        const NumericKind Closure = UnsignedInts;
    }
}