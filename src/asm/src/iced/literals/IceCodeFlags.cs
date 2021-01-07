//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    using System;

    [Flags]
    public enum IceCodeFlags : uint
    {
        CodeBits = 0x0000000D,

        CodeMask = 0x00001FFF,

        RoundingControlMask = 0x00000007,

        RoundingControlShift = 0x0000000D,

        OpMaskMask = 0x00000007,

        OpMaskShift = 0x00000010,

        InstrLengthMask = 0x0000000F,

        InstrLengthShift = 0x00000013,

        SuppressAllExceptions = 0x02000000,

        ZeroingMasking = 0x04000000,

        XacquirePrefix = 0x08000000,

        XreleasePrefix = 0x10000000,

        RepePrefix = 0x20000000,

        RepnePrefix = 0x40000000,

        LockPrefix = 0x80000000,

        EqualsIgnoreMask = 0x00780000,
    }

}