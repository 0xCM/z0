//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using static Hex8Seq;

    /// <summary>
    /// The segment override codes as specified by Intel Vol II, 2.1.1
    /// </summary>
    [PrefixCodes]
    public enum SegOverrideCode : byte
    {
        None = 0,

        [PrefixCode("CS segment override")]
        CS = x2e,

        [PrefixCode("SS segment override")]
        SS = x36,

        [PrefixCode("DS segment override")]
        DS = x3e,

        [PrefixCode("ES segment override")]
        ES = x26,

        [PrefixCode("FS segment override")]
        FS = x64,

        [PrefixCode("GS segment override")]
        GS = x65,
    }
}