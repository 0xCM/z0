//-----------------------------------------------------------------------------
// Derivative Work
// Copyright  : Microsoft/.Net foundation
// Copyright  : (c) Chris Moore, 2020
// License    :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{
    using System;

    public enum CilOperandType : byte
    {
        InlineBrTarget = 0,

        InlineField = 1,

        InlineI = 2,

        InlineI8 = 3,

        InlineMethod = 4,

        InlineNone = 5,

        InlinePhi = 6,

        InlineR = 7,

        InlineSig = 9,

        InlineString = 10,

        InlineSwitch = 11,

        InlineTok = 12,

        InlineType = 13,

        InlineVar = 14,

        ShortInlineBrTarget = 15,

        ShortInlineI = 16,

        ShortInlineR = 17,

        ShortInlineVar = 18,
    }
}