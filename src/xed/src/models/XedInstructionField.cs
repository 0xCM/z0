//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0
{

    using System;
    using System.Runtime.CompilerServices;

    using static Konst;

    public enum XedInstructionField : uint
    {
        Sequence = 0 | 16 << WidthOffset,

        Mnemonic = 1 | 16 << WidthOffset,

        Extension = 2 | 16 << WidthOffset,

        BaseCode = 3 | 8 << WidthOffset,

        Mod = 4 | 4 << WidthOffset,

        Reg = 5 | 8 << WidthOffset,
    }

}