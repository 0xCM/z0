//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.Relations, true)]
    public readonly partial struct Relations
    {
        const NumericKind Closure = UnsignedInts;
    }
}