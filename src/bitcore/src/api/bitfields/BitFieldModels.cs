//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.BitFieldModels, true)]
    public readonly partial struct BitFieldModels
    {
        const NumericKind Closure = UnsignedInts;
    }
}