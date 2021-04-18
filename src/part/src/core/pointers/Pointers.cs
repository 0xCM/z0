//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.Pointers, true)]
    public unsafe readonly partial struct Pointers
    {
        const NumericKind Closure = UnsignedInts;
    }
}