//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    [WfCmdKind]
    public enum ApiCmdKind : byte
    {
        None = 0,

        [Alias("check-bitmasks")]
        CheckBitMasks,
    }
}