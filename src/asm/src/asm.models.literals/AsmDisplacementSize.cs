//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    using System;
    using System.Runtime.CompilerServices;

    public enum AsmDisplacementSize : byte
    {
        None,

        y1 = 1,

        y2 = 2,

        y4 = 4,

        y8 = 8
    }
}