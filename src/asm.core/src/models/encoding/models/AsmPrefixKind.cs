//-----------------------------------------------------------------------------
// Copyright   :  (c) Chris Moore, 2020
// License     :  MIT
//-----------------------------------------------------------------------------
namespace Z0.Asm
{
    /// <summary>
    /// Classifies prefix domains
    /// </summary>
    public enum AsmPrefixKind : byte
    {
        None = 0,

        SegOverride = 2,

        SizeOverride = 3,

        Escape = 4,

        Lock = 5,

        Bnd = 6,

        BranchHint = 7,

        Rep = 8,

        Mandatory = 9,

        Rex = 10,

        Vex = 11,
    }
}