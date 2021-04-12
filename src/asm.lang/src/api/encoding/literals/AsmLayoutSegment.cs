//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;

    [Flags]
    public enum AsmLayoutSegment : byte
    {
        None = 0,

        LegacySeg = 1,

        RexSeg = 2,

        OpCodeSeg = 4,

        ModRmSeg = 8,

        SibSeg = 16,

        DxSeg = 32,

        ImmSeg = 64
    }
}