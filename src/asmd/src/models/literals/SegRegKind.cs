//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm.Data
{
    using System;

    public enum SegRegKind : byte
    {
        None = 0,

        CS = 1,

        DS = 2,

        SS = 3,

        ES = 4,

        FS = 5,

        GS = 6
    }

}