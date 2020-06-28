//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static HexKind8;

    public enum SegRegOverride : byte
    {
        None = 0,

        CS = x2e,

        SS = x36,

        DS = x3e,

        ES = x26,

        FS = x64,

        GS = x65        
    }
}