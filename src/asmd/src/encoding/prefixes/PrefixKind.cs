//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{        
    public enum PrefixKind : byte
    {
        Legacy = 1,

        Rex = 2,

        Vex = 3,

        EVex = 4
    }
}