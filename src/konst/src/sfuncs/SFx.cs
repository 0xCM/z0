//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost(ApiNames.SFx, true)]
    public readonly partial struct SFx
    {
        const NumericKind Closure = NumericKind.I8 | NumericKind.U64;
    }
}