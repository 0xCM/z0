//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    using static HexKind;

    public enum SegOverride : byte
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