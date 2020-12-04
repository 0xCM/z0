//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [ApiHost(ApiNames.BitSeqApi)]
    public readonly partial struct BitSeq
    {
        public const NumericKind Closure = NumericKind.UnsignedInts;
    }
}