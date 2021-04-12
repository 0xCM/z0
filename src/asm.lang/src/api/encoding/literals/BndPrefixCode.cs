//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    [PrefixCodes]
    public enum BndPrefixCode : byte
    {
        None = 0,

        [PrefixCode]
        BND = xf2
    }
}