//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using static Part;

    [ApiHost(ApiNames.Cmd, true)]
    public readonly partial struct Cmd
    {
        const NumericKind Closure = UnsignedInts;
    }
}