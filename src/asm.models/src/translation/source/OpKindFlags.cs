//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Ice
{
    using System;

    [Flags]
    public enum OpKindFlags : uint
    {
        OpKindBits = 0x00000005,

        OpKindMask = 0x0000001F,

        Op1KindShift = 0x00000005,

        Op2KindShift = 0x0000000A,

        Op3KindShift = 0x0000000F,

        DataLengthMask = 0x0000000F,

        DataLengthShift = 0x00000014,

        CodeSizeMask = 0x00000003,

        CodeSizeShift = 0x0000001E,

        EqualsIgnoreMask = 0xC0000000,
    }
}